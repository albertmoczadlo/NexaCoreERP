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
    }
}
