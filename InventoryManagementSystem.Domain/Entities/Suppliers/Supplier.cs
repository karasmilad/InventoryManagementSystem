using InventoryManagementSystem.Domain.Entities.Relations;

namespace InventoryManagementSystem.Domain.Entities.Suppliers
{
    public class Supplier : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public ICollection<ProductSupplier> ProductSupplier { get; set; } = default!;

    }
}
