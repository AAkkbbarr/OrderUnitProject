using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class OrderItem : EntityBase
    {
        public string Name { get; set; }
        public int Unit { get; set; }
        public virtual OrderUnit Order { get; set; }
        public int OrderUnitId { get; set; }
    }
}
