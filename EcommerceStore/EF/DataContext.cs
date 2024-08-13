using EcommerceStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceStore.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        //Dbset here
        public DbSet<Category> Categories { get; set; }

        public DbSet<AddressDTO> Addresses { get; set; }
        public DbSet<User>Users { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
