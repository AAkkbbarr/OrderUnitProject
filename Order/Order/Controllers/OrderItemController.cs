using Application.Interfaces;
using Application.Request.OrderItemRequest;
using Application.Request.OrderRequest;
using Application.Response;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;

        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }
        [HttpGet("id")]
        public OrderItemResponse GetById(int id)
        {

            return _orderItemService.Get(id);
        }

        [HttpPost]
        public void Add(CreateOrderItemRequest orderItem)
        {
            _orderItemService.Add(orderItem);
        }

        [HttpPut("id")]
        public void Update(int id, CreateOrderItemRequest orderItem)
        {
            _orderItemService.Update(id, orderItem);
        }

        [HttpDelete("id")]

        public void Delete(int id)
        {
            _orderItemService.Delete(id);
        }
    }
}

