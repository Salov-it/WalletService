using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WalletServic.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assemby = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assemby));
            return services;
        }
    }
}
