

namespace NexaCoreERP.Domain.Entities
{
    public class ProductionOrderDetail
    {
        public int Id { get; set; }
        public int ProductionOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }//zamowiona ilosc

        public Product Product { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
    }
}
