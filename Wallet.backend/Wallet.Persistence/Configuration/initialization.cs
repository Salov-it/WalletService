using Microsoft.EntityFrameworkCore;

namespace Wallet.Persistence.Configuration
{
    public class initialization : DbContext
    {
        public initialization() => Database.EnsureCreated();
    }
}
