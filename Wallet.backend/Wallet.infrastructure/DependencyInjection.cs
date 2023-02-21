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

            IWalletContext _context;
            switch(config["DbType"])
            {
                case "InMemory":
                    {
                        services.AddDbContext<WalletContext>(opt =>
                        {
                            opt.UseInMemoryDatabase("1");
                        });
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
                case "SQLite":
                    {
                        services.AddDbContext<WalletContext>(options =>
                        {
                            options.UseSqlite(connectionString);
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
