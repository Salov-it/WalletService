using MediatR;
using Wallet.Domain;
using Wallet.infrastructure;
namespace Wallet.Application.CQRS.command
{
    internal class CreateWalletCommandHandler: IRequestHandler<CreateWalletСommand,int>
    {
        
        public async Task<int> Handle(CreateWalletСommand request, CancellationToken cancellationToken)
        {
            var db = new WalletContext();

            var content = new Wallets
            {
                ownerId = request.OwnerId,
                balance = 0,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),

            };
       
            db.Add(content);
            await db.SaveChangesAsync();

            return request.OwnerId;
        }
    }
}
