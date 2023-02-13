using Microsoft.EntityFrameworkCore;
using Wallet.Domain;

namespace Wallet.Application.Interfaces
{
    public class IWalletDbContext : DbContext
    {
        public DbSet<Wallets> wallets => Set<Wallets>();
        

    }
}
