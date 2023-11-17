using Application.Interfaces;
using Application.Request.OrderRequest;
using Application.Request.ProviderRequest;
using Application.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Application.Response;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("id")]
        public OrderResponse GetById(int id)
        {
            return (OrderResponse)_orderService.Get(id);
        }

        [HttpPost]
        public void Add(CreateOrderRequest order)
        {
            _orderService.Add(order);
        }

        [HttpPut("id")]
        public void Update(int id, CreateOrderRequest order)
        {
            _orderService.Update(id, order);
        }

        [HttpDelete("id")]

        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}
