
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventories");

            builder.Property(i=>i.QuantityAvailable).IsRequired();

            builder.Property(i=>i.SafetyStockLevel).IsRequired();

            builder.HasOne(i => i.Product)
               .WithMany(p => p.Inventories)
               .HasForeignKey(i => i.ProductId);

            builder.HasOne(i => i.Department)
                   .WithMany(d => d.Inventories)
                   .HasForeignKey(i => i.DepartmentId);
        }
    }
}
