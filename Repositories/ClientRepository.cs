using CMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public readonly ClientContext _context;
        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

        public async Task<Client> Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;   
        }

        public async Task Delete(int id)
        {
            var clientToDelete = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(clientToDelete);
            await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Client>> Get()
        {
            return await _context.Clients.ToListAsync();

            
        }

        public async Task<Client> Get(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
