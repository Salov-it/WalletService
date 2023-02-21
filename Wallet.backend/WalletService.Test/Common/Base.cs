
using WalletService.infrastructure;

namespace WalletService.Test.Common
{
    public class Base : IDisposable
    {
        protected readonly WalletContext _context;

        public Base()
        {
            _context = ContextFactory.Create();
        }
        public void Dispose()
        {
            ContextFactory.Destroy(_context);
        }
    }
}
