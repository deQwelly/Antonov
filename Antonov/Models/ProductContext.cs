using System.Data.Entity;

namespace Antonov.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Antonov")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}

