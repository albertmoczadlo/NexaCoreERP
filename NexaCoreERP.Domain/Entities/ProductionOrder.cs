

namespace NexaCoreERP.Domain.Entities
{
    public class ProductionOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public Order Order { get; set; }
        public ICollection<ProductionOrderDetail> ProductionOrderDetails { get; set; }

    }
}
