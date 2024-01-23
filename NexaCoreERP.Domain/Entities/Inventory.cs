
namespace NexaCoreERP.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DepartmentId { get; set; } // Dodany klucz obcy dla Department
        public int QuantityAvailable { get; set; } // Dostępna ilość opakowań
        public string Description { get; set; }
        public int SafetyStockLevel { get; set; }

        // Właściwości nawigacyjne
        public Product Product { get; set; }
        public Department Department { get; set; } // Właściwość nawigacyjna do Department
    }

}
