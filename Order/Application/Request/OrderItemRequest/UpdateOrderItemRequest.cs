using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.Request.OrderItemRequest
{
    public class UpdateOrderItemRequest : OrderItemRequest
    {
        public OrderUnit Order { get; set; }
        public int Id { get; set; }
    }
}
