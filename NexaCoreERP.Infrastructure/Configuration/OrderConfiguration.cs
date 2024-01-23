using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.Property(x => x.OrderDate).IsRequired();

        builder.Property(x => x.Status).HasMaxLength(60).IsRequired();

        builder.HasOne(d => d.Department)
            .WithMany(o => o.Orders)
            .HasForeignKey(od => od.DepartmentId);
    }
}
