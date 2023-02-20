using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WalletService.Application.Interface;

namespace WalletService.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config) 
        {
            var connectionString = config["ConnectionString"];
            // ?
            services.AddDbContext<WalletContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<IWalletContext>(provider => provider.GetService<WalletContext>());
            return services;
        }
    }
}
