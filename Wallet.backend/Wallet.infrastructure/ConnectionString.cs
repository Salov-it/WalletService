using Microsoft.EntityFrameworkCore;

namespace Wallet.infrastructure
{
    public class ConnectionString : WalletContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WalletBasse.db");
        }
    }
}
