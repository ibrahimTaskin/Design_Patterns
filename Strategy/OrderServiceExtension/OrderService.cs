using Strategy.OrderServiceExtension.Models;
using Strategy.ShippingService.Factory;
using Strategy.ShippingService.Models;

namespace Strategy.OrderServiceExtension
{
    public class OrderService : IOrderService
    {
        private readonly IShippingStrategyFactory _shippingStrategyFactory;

        public OrderService(IShippingStrategyFactory shippingStrategyFactory)
        {
            _shippingStrategyFactory = shippingStrategyFactory;
        }

        public async Task<TrackingInfo> ProcessOrderAsync(Order order)
        {
            var shippingStrategy = _shippingStrategyFactory.GetStrategy(order.ShipmentDetail);
            // Use shippingStrategy to create a shipment, track a shipment, etc.
            TrackingInfo trackingInfo = await shippingStrategy.TrackShipmentAsync(order.TrackingNumber);
            // ...
            return trackingInfo;
        }
    }
}
