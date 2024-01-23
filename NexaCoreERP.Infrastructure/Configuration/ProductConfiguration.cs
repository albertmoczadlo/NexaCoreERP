using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Infrastructure.Configuration;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.Property(p=>p.ProductName).HasMaxLength(60).IsRequired();
    }
}
