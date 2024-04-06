namespace Strategy.ShippingService.Models
{
    public class ShipmentDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
    }
}
