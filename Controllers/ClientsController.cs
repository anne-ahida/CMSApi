using CMS.Models;
using CMS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;

        }
        [HttpGet]
        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _clientRepository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClients(int id)
        {
            return await _clientRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient([FromBody] Client client)
        {
            var newClient = await _clientRepository.Create(client);
            return CreatedAtAction(nameof(GetClients), new {id = newClient.clientID}, newClient);
        }
        [HttpPut]
        public async Task<ActionResult<Client>> PutClient(int id,[FromBody] Client client)
        {
            if (id != client.clientID)
            {
                return BadRequest();
            }
            
            await _clientRepository.Update(client);
           

            return NoContent();
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client>> DeleteClient(int id)
        {
            var clientToDelete = await _clientRepository.Get(id);
            if(clientToDelete == null)
                return NotFound();

            await _clientRepository.Delete(clientToDelete.clientID);
            return NoContent();
        }
    }
}
