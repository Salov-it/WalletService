using Microsoft.EntityFrameworkCore;
using Wallet.Domain;

namespace Wallet.infrastructure
{
    public class WalletContext : DbContext
    {
        public DbSet<Wallets> wallets => Set<Wallets>();
       
    }
}
