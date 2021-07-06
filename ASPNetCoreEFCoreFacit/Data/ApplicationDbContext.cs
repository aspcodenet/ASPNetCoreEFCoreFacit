using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreEFCoreFacit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Bil> Bilar { get; set; }
    }
}