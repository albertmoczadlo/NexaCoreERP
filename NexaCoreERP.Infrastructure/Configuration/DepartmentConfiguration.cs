using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.Property(n=>n.DepartmentName).HasMaxLength(60).IsRequired();

            builder.HasMany(o=>o.Orders)
                .WithOne(d=>d.Department)
                .HasForeignKey(r=>r.DepartmentId);

            builder.HasMany(p => p.ProductionOrders)
                .WithOne(d => d.Department)
                .HasForeignKey(r => r.DepartmentId);

            builder.HasMany(d => d.Inventories)
               .WithOne(i => i.Department)
               .HasForeignKey(i => i.DepartmentId);
        }
    }
}
