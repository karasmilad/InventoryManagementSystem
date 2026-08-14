using InventoryManagementSystem.Domain.Entities.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagementSystem.Infrastructure.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(s => s.Email)
                .IsUnique();
            builder.Property(s => s.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11);
            builder.HasIndex(s => s.PhoneNumber)
                .IsUnique();
        }
    }
}
