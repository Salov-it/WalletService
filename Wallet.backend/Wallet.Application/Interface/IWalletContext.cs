using Microsoft.EntityFrameworkCore;
using WalletService.Domain;

namespace WalletService.Application.Interface
{
    public interface IWalletContext 
    {
        public DbSet<Wallet> Wallets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);

    }
}
