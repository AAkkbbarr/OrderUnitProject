using Application.Request.OrderItemRequest;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderItemService : IBaseService<Domain.Model.OrderItem, OrderItemRequest, OrderItemResponse>
    {
    }
}
