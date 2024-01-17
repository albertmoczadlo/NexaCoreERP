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
        public string OrderName { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
