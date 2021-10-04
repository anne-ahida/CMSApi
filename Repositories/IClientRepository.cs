using CMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> Get();

        Task<Client> Get(int id);

        Task<Client> Create(Client client);
        Task Update(Client client);

        Task Delete(int id);

    }
}
