using Strategy.ShippingService.Factory.Companies;
using Strategy.ShippingService.Models;

namespace Strategy.ShippingService.Factory
{
    public class ShippingStrategyFactory : IShippingStrategyFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public ShippingStrategyFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IShippingStrategy GetStrategy(ShipmentDetails details)
        {
            if (details == null)
                throw new ArgumentNullException(nameof(details));

            if (details.ShippingCompany == ShippingCompany.DHL) { return _serviceProvider.GetRequiredService<DhlShippingStrategy>(); }
            if (details.ShippingCompany == ShippingCompany.ARAS) { return _serviceProvider.GetRequiredService<ArasShippingStrategy>(); }
            if (details.ShippingCompany == ShippingCompany.MNG) { return _serviceProvider.GetRequiredService<MngShippingStrategy>(); }
            if (details.ShippingCompany == ShippingCompany.Trendyol) { return _serviceProvider.GetRequiredService<TrendyolShippingStrategy>(); }
            return _serviceProvider.GetRequiredService<HepsiJetShippingStrategy>();
        }
    }
}
