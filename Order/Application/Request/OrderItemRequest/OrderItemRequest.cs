﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.OrderItemRequest
{
    public class OrderItemRequest : BaseRequest
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Unit { get; set; }
    }
}
