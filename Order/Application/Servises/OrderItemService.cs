using Application.Interfaces;
using Application.Request.OrderItemRequest;
using Application.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;

namespace Application.Servises
{
    public class OrderItemService : BaseService<Domain.Model.OrderItem, OrderItemRequest, OrderItemResponse>, IOrderItemService
    {
        public OrderItemService(IMapper mapper, IRepository<Domain.Model.OrderItem> repository) : base(mapper, repository)
        {
        }
    }
}
