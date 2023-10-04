using Commy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Commy.Data
{
    public class CommyDBContext : IdentityDbContext
    {
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public CommyDBContext(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Commy.Models.Category> Categories { get; set;}
        public DbSet<Commy.Models.Product> Products { get; set;}
    }
}
