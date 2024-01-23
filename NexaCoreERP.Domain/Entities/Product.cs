

namespace NexaCoreERP.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
