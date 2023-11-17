using Application.Interfaces;
using Application.Request.ProviderRequest;
using Application.Response;
using Application.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;
        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }
        [HttpGet("id")]
        public ProviderResponse GetById(int id) 
        {
            return _providerService.Get(id);
        }

        [HttpPost]
        public void Add(CreateProviderRequest provider) {
            _providerService.Add(provider);
        }

        [HttpPut("id")]
        public void Update(int id ,UpdateProviderRequest provider) {
            _providerService.Update(id, provider);
        }

        [HttpDelete("id")]

        public void Delete(int id) {
            _providerService.Delete(id);
        }
    }
}
