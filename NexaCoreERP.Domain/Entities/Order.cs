using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexaCoreERP.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; } //nowe, przyjete do realizacji, skonczone
        public DateTime OrderDate { get; set; }
        public int DepartmentId { get; set; }


        public Department Department { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
    }
}
