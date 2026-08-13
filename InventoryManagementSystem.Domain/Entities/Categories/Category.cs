using InventoryManagementSystem.Domain.Entities.Products;

namespace InventoryManagementSystem.Domain.Entities.Categories
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public ICollection<Product> Products { get; set; } = default!;
    }
}
