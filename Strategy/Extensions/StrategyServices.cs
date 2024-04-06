using Strategy.OrderServiceExtension;
using Strategy.ShippingService.Factory;
using Strategy.ShippingService.Factory.Companies;

namespace Strategy.Extensions
{
    public static class StrategyServices
    {
        public static IServiceCollection ConfigureStrategyServices(this IServiceCollection services)
        {
            services.AddTransient<DhlShippingStrategy>();
            services.AddTransient<ArasShippingStrategy>();
            services.AddTransient<MngShippingStrategy>();
            services.AddTransient<TrendyolShippingStrategy>();
            services.AddTransient<HepsiJetShippingStrategy>();
            services.AddSingleton<IShippingStrategyFactory, ShippingStrategyFactory>();
            services.AddSingleton<IOrderService, OrderService>();
            // Add other dependencies...

            return services;
        }
    }
}
