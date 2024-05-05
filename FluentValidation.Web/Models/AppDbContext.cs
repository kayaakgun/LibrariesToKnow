using Microsoft.EntityFrameworkCore;

namespace FluentValidationLibrary.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {
                
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
