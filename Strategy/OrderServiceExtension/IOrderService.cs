using Strategy.OrderServiceExtension.Models;
using Strategy.ShippingService.Models;

namespace Strategy.OrderServiceExtension
{
    public interface IOrderService
    {
        Task<TrackingInfo> ProcessOrderAsync(Order order);
    }
}
