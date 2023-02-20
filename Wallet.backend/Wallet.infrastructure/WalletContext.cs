using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;



namespace WalletService.infrastructure
{
    public class WalletContext : DbContext, IWalletContext
    {
        

        public DbSet<Wallet> Wallets { get; set; }

        public WalletContext(DbContextOptions options) : base(options) { }
        public WalletContext() => Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
       }

       
    }
}
