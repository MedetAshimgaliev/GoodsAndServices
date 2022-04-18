using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using GoodsAndServices.Models;


namespace GoodsAndServices.Models
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Product> Product { get; set; } = null!;
    }
}
