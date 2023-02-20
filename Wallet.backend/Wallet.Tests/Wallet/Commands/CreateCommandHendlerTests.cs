using Xunit;
using System.Threading.Tasks;
using Wallet.Tests.common;
using WalletService.Application.CQRS.command.Create;
using Azure.Core;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Wallet.Tests.Wallet.Commands
{
    public class CreateCommandHendlerTests : TestCommandBase
    {
        [Fact]
        public async Task CreateCommandHendler_Success()
        {
            //Arrange
            var handler = new CreateWalletCommandHandler(context);
            var ownerId = 45;
            var balance = 1000;
            var createdAt = DateTime.Now.ToLocalTime().ToString();


        //Act
        var walletid = await handler.Handle(new CreateWalletСommand
           {
               OwnerId = ownerId,
          
           },
           CancellationToken.None);

           //Assert
           Assert.NotNull(
               await context.Wallets.SingleOrDefaultAsync(note => note.ownerId == ownerId&&
               note.balance == balance&&
               note.createdAt == createdAt));   
        }
    }
}
