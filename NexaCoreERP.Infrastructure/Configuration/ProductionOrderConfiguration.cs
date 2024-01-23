
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration
{
    public class ProductionOrderConfiguration : IEntityTypeConfiguration<ProductionOrder>
    {
        public void Configure(EntityTypeBuilder<ProductionOrder> builder)
        {
            builder.ToTable("ProductionOrders");

            builder.HasOne(o=>o.Order)
                .WithOne(or=>or.ProductionOrder)
                .HasForeignKey<ProductionOrder>(o=>o.OrderId);

            builder.HasMany(p=>p.ProductionOrderDetails)
                .WithOne(d=>d.ProductionOrder)
                .HasForeignKey(r=>r.ProductionOrderId);

        }
    }
}
