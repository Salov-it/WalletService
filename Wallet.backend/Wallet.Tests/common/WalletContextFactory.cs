using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using WalletService.infrastructure;
namespace Wallet.Tests.common
{
    public class WalletContextFactory
    {
        public static WalletContext Create() 
        {
            var options = new DbContextOptionsBuilder<WalletContext>()
                .UseInMemoryDatabase(databaseName: "database_name");

            var context = new WalletContext();
            context.Database.EnsureCreated();

            context.Wallets.AddRange(new WalletService.Domain.Wallet
            {
                id = 1,
                ownerId = 12,
                balance = 0,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt= DateTime.Now.ToLocalTime().ToString(),
            },
            new WalletService.Domain.Wallet
            {
                id = 2,
                ownerId = 34,
                balance = 500,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),
            }
            );

            context.SaveChanges();
            return context;
        }

        public static void Destroy(WalletContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();  
        }
    }
}
