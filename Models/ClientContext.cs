using Microsoft.EntityFrameworkCore;

namespace CMS.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients {  get; set; }
    }
}
