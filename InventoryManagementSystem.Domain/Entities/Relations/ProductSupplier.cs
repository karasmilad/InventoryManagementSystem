using InventoryManagementSystem.Domain.Entities.Products;
using InventoryManagementSystem.Domain.Entities.Suppliers;

namespace InventoryManagementSystem.Domain.Entities.Relations
{
    internal class ProductSupplier
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = default!;

    }
}
