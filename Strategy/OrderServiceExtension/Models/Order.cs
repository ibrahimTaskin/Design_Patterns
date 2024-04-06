using Strategy.ShippingService.Models;

namespace Strategy.OrderServiceExtension.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ShipmentDetails ShipmentDetail { get; set; }
        public string TrackingNumber { get; set; }
    }
}
