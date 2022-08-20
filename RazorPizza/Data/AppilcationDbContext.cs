using Microsoft.EntityFrameworkCore;
using RazorPizza.Models;

namespace RazorPizza.Data
{
    public class AppilcationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrder { get; set; }

        public AppilcationDbContext(DbContextOptions<AppilcationDbContext>options
            ) :base(options)
        {

        }
    }
}
