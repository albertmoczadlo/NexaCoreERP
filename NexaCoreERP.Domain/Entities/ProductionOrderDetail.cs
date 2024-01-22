using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexaCoreERP.Domain.Entities
{
    public class ProductionOrderDetail
    {
        public int ProductionOrderDetailId { get; set; }
        public int ProductionOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }//zamowiona ilosc
    }
}
