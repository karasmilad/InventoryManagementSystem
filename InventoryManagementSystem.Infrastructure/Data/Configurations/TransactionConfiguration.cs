using InventoryManagementSystem.Domain.Entities.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagementSystem.Infrastructure.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {

        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(t => t.TotalAmount)
                .HasPrecision(18, 2)
                .IsRequired();
            builder.Property(t => t.Type)
                .IsRequired();
        }
    }
}
