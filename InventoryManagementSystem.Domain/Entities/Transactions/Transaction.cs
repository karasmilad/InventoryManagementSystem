using InventoryManagementSystem.Domain.Entities.Enums;
using InventoryManagementSystem.Domain.Entities.Relations;

namespace InventoryManagementSystem.Domain.Entities.Transactions
{
    public class Transaction : BaseEntity<int>
    {
        public decimal TotalAmount { get; set; }
        public TransactionType Type { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; } = new HashSet<TransactionItem>();
    }
}
