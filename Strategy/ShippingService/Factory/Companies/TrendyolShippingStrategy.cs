using Strategy.ShippingService.Models;

namespace Strategy.ShippingService.Factory
{
    public class TrendyolShippingStrategy : IShippingStrategy
    {
        public async Task<ShippingResponse> CreateShipmentAsync(ShipmentDetails shipmentDetails)
        {
            return new ShippingResponse { IsOperationSucces = true };
        }

        public async Task<TrackingInfo> TrackShipmentAsync(string trackingNumber)
        {
            return new TrackingInfo { TrackingNumber = trackingNumber, ShippingName = "Trendyol" };
        }
    }
}
