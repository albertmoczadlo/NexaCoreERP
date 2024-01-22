
namespace NexaCoreERP.Domain.Entities
{
    public class Inventory
    {
        public int InventorId { get; set; }
        public int ProductId { get; set; }
        public int QuantityAvailable { get; set; } //dostepna ilosc opakowan
        public string Description { get; set; }
        public int SafetyStockLevel { get; set; }
    }
}
