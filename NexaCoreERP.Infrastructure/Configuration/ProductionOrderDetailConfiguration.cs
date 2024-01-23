
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration
{
    public class ProductionOrderDetailConfiguration: IEntityTypeConfiguration<ProductionOrderDetail>
    {
        public void Configure(EntityTypeBuilder<ProductionOrderDetail> builder)
        {
            builder.ToTable("ProductionOrderDetails");

            builder.HasOne(d => d.ProductionOrder)
                .WithMany(o => o.ProductionOrderDetails)
                .HasForeignKey(od => od.ProductionOrderId);

            builder.HasOne(d => d.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId);
        }
    }
}
