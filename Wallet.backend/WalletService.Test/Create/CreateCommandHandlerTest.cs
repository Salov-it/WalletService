using Microsoft.EntityFrameworkCore;
using WalletService.Application.CQRS.Command.Create;
using WalletService.Test.Common;

namespace WalletService.Test.Create
{
    public class CreateCommandHandlerTest : Base
    {
        [Fact]
        public async Task CreateSucces()
        {
            var handler = new CreateWalletCommandHandler(_context);

            var wallet = await handler.Handle(
                new CreateWalletСommand()
                {
                    OwnerId = 3
                },
                CancellationToken.None
            );
            Assert.NotNull(
                await _context.Wallets.SingleOrDefaultAsync(
                    w => w.id == 3
                    && w.balance == 0
                    && w.ownerId == 3)
                );
        }
    }
}
