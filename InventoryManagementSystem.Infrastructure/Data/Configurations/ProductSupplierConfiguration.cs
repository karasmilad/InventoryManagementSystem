using InventoryManagementSystem.Domain.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagementSystem.Infrastructure.Data.Configurations
{
    public class ProductSupplierConfiguration : IEntityTypeConfiguration<ProductSupplier>
    {
        public void Configure(EntityTypeBuilder<ProductSupplier> builder)
        {
            builder.HasKey(ps => new { ps.ProductId, ps.SupplierId });
            builder.HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSupplier)
                .HasForeignKey(ps => ps.ProductId);
            builder.HasOne(ps => ps.Supplier)
                .WithMany(s => s.ProductSupplier)
                .HasForeignKey(ps => ps.SupplierId);
        }
    }
}
