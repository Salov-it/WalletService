using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Wallet.Application.Interfaces;



namespace Wallet.Persistence.EntityTypeConfiguration
{
    public class Configuration : DbContext
    {
        protected  void Configuring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WalletBasse.db");
        }

    }
}
