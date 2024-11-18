using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SklepInternetowy.Models;

namespace SklepInternetowy.Services
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
