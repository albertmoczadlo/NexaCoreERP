

namespace NexaCoreERP.Domain.Entities;

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public string Description { get; set; }

    public ICollection<Order> Orders { get; set; }
    public ICollection<ProductionOrder> ProductionOrders { get; set; }
    public ICollection<Inventory> Inventories { get; set; }
}
