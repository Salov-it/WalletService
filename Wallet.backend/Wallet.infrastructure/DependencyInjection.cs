using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Wallet.Application;

namespace Wallet.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var ConnectionString = configuration["DbConnection"];

            services.AddDbContext<WalletContext>(options =>
            {
                options.UseSqlite(ConnectionString);
            });

           // services.AddScoped<IWalletDbContext>(provider => (IWalletDbContext)provider.GetService<WalletContext>());

            return services;
        }
    }
}
