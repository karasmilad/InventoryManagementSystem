using InventoryManagementSystem.Domain.Common;
using InventoryManagementSystem.Domain.Entities.Products;
using InventoryManagementSystem.Domain.Entities.Transactions;

namespace InventoryManagementSystem.Domain.Entities.Relations
{
    internal class TransactionItem  : BaseEntity<int>
    {
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
