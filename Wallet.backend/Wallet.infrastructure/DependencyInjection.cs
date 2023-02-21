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
            var connectionString = config["DbConnection"];


            switch(config["DbType"])
            {
                case "InMemory":
                    {
                        var opt = new DbContextOptionsBuilder<WalletContext>()
                        .UseInMemoryDatabase("1")
                         .Options;
                        var context = new WalletContext(opt);
                        break;
                    }
                case "Postgres":
                    {
                        services.AddDbContext<WalletContext>(options =>
                        {
                            options.UseNpgsql(connectionString);
                        });
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }

            services.AddScoped<IWalletContext>(provider => provider.GetService<WalletContext>());
            return services;
        }
    }
}
