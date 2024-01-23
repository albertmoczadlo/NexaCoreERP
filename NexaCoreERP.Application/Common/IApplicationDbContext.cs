using Microsoft.EntityFrameworkCore;
using NexaCoreERP.Domain.Entities;

namespace NexaCoreERP.Application.Common;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderDetail> OrderDetails { get; set; }
    DbSet<ProductionOrder> ProductionOrders { get; set; }
    DbSet<ProductionOrderDetail> ProductionOrderDetails { get; set; }
    DbSet<Inventory> Inventories { get; set; }
    DbSet<Department> Departments { get; set; } 

    Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
}
