using InventoryManagementSystem.Domain.Entities.Categories;
using InventoryManagementSystem.Domain.Entities.Relations;
using InventoryManagementSystem.Domain.Entities.Suppliers;

namespace InventoryManagementSystem.Domain.Entities.Products
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumStock { get; set; }
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }
        public ICollection<ProductSupplier> ProductSupplier { get; set; } = new HashSet<ProductSupplier>();
        public ICollection<TransactionItem> TransactionItems { get; set; } =  new HashSet<TransactionItem>();

    }
}
