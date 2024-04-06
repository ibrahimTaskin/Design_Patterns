using Strategy.ShippingService.Models;

namespace Strategy.ShippingService.Factory
{
    public interface IShippingStrategy
    {
        Task<ShippingResponse> CreateShipmentAsync(ShipmentDetails shipmentDetails);
        Task<TrackingInfo> TrackShipmentAsync(string trackingNumber);
    }
}
