using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;



namespace WalletService.infrastructure
{
    public class WalletContext : DbContext, IWalletContext
    {
       public DbSet<Wallet> Wallets { get; set; }



       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
       }

       
    }
}
