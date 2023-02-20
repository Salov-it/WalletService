
using Microsoft.EntityFrameworkCore;
using WalletService.Domain;
using WalletService.infrastructure;

namespace WalletService.Test.Common
{
    public class ContextFactory
    {
        public static WalletContext Create()
        {
            var opt = new DbContextOptionsBuilder<WalletContext>()
                .UseInMemoryDatabase("1")
                .Options;
            var context = new WalletContext(opt);
            context.Database.EnsureCreated();

            context.Wallets.AddRange(
                getWallets()
                );
            return context;
        }

        public static void Destroy(WalletContext context ) 
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        public static Wallet[] getWallets()
        {
            var wallets = new Wallet[]
            {
                new Wallet()
                {
                    balance= 0,
                    createdAt = "",
                    updatedAt = "",
                    ownerId = 1
                },
                new Wallet()
                {
                    balance= 100,
                    createdAt = "",
                    updatedAt = "",
                    ownerId = 2
                }
            };
            return wallets;
        }
    }
}
