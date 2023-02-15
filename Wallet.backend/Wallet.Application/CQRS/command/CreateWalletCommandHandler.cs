using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Wallet.Application;
using Wallet.Domain;
namespace Wallet.Application.CQRS.command
{
    internal class CreateWalletCommandHandler: IRequestHandler<CreateWalletСommand,int>
    {
        
        public async Task<int> Handle(CreateWalletСommand request, CancellationToken cancellationToken)
        {
            var entity = new Wallets
            {
                ownerId = request.OwnerId,
                balance = 0,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),
                id = 2
            };
            Console.WriteLine("id кошелька");
            Console.WriteLine(entity.ownerId);
            Console.WriteLine("баланс");
            Console.WriteLine(entity.balance);
            Console.WriteLine("дата");
            Console.WriteLine(entity.createdAt);
           
            return entity.id;
        }
    }
}
