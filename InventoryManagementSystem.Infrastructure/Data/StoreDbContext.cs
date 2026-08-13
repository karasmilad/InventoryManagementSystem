using InventoryManagementSystem.Domain.Entities.Categories;
using InventoryManagementSystem.Domain.Entities.Products;
using InventoryManagementSystem.Domain.Entities.Relations;
using InventoryManagementSystem.Domain.Entities.Suppliers;
using InventoryManagementSystem.Domain.Entities.Transactions;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Infrastructure.Data
{
    internal class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }    
    }
}
