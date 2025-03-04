using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.data
{
    public class AppDbContextcs : DbContext
    {
        public AppDbContextcs(DbContextOptions<AppDbContextcs>options):base(options)
        {
            
        }

        public DbSet<blog> blog { get; set; }

        public DbSet<catogries> catogries { get; set; }

    }
}
