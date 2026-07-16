using InventoryManagementSystem.Domain.Common;
using InventoryManagementSystem.Domain.Entities.Relations;

namespace InventoryManagementSystem.Domain.Entities.Transactions
{
    internal class Transaction : BaseEntity<int>
    {
        public decimal TotalAmount { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; } = new HashSet<TransactionItem>();
    }
}
