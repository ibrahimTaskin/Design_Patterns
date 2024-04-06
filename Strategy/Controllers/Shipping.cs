using Microsoft.AspNetCore.Mvc;
using Strategy.OrderServiceExtension;
using Strategy.OrderServiceExtension.Models;
using Strategy.ShippingService.Models;

namespace Strategy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Shipping : ControllerBase
    {

        private readonly ILogger<Shipping> _logger;
        public IOrderService _orderService { get; set; }

        public Shipping(ILogger<Shipping> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateShipping([FromBody] Order order)
        {
            TrackingInfo trackingInfo = await _orderService.ProcessOrderAsync(order);
            return Ok(trackingInfo);
        }
    }
}
