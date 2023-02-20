using Microsoft.Extensions.DependencyInjection;

namespace WalletServic.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, Type Startup)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Startup.Assembly));
            return services;
        }
    }
}
