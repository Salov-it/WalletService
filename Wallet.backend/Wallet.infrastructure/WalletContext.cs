using Microsoft.EntityFrameworkCore;
using Wallet.Domain;


namespace Wallet.infrastructure
{
    public class WalletContext : DbContext
    {
        
       public DbSet<Wallets> wallets { get; set; }
       public WalletContext() => Database.EnsureCreated();

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder.UseSqlite("Data Source=WalletBase.db");
       }

    }
}
