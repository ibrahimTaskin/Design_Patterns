using Strategy.ShippingService.Models;

namespace Strategy.ShippingService.Factory
{
    public interface IShippingStrategyFactory
    {
        IShippingStrategy GetStrategy(ShipmentDetails details);
    }
}
