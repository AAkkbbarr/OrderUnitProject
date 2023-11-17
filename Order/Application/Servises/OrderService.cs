using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Request.OrderRequest;
using Application.Response;
using AutoMapper;
using Domain.Model;

namespace Application.Servises
{
    public class OrderService : BaseService<OrderUnit, OrderRequest, OrderResponse>, IOrderService
    {
        public OrderService(IMapper mapper, IRepository<OrderUnit> repository) : base(mapper, repository)
        {
        }
    }
}
