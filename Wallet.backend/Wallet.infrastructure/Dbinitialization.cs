using Microsoft.EntityFrameworkCore;


namespace Wallet.infrastructure
{
    public class Dbinitialization
    {
        public static void Initialize(WalletContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
