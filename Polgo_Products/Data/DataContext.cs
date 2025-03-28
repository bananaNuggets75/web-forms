using Microsoft.EntityFrameworkCore;
using Polgo_Products.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Polgo_Products.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
        base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData(
            new Products { id = 1, productName = "Tapsilog", type = "Rice", manufacturer = "Kalye", price = 5 },
            new Products { id = 2, productName = "Carbonara", type = "Spaghetti", manufacturer = "Italian Mafia", price = 10 },
            new Products { id = 3, productName = "Pancit Canton", type = "Noodles", manufacturer = "Peenoise", price = 5 }
            );
        }
        public DbSet<Products> Products { get; set; }
    
}
}
