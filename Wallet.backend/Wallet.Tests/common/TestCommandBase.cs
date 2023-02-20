using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletService.infrastructure;

namespace Wallet.Tests.common
{
    public abstract class TestCommandBase : IDisposable
    {
        protected readonly WalletContext context;

        public TestCommandBase()
        {
            context = WalletContextFactory.Create();
        }

        public void Dispose()
        {
            WalletContextFactory.Destroy(context);
        }
    }
}
