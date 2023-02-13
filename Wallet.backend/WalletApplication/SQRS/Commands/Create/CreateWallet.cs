using System;
using System.Data;
using MediatR;
using Wallet.Domain;
namespace Wallet.Application.SQRS.Commands.Create
{
    public class CreateWallet :IRequestHandler<CreateWalletCommand, Guid>
    {
        public async Task<Guid>Handle(CreateWalletCommand requestr, CancellationToken cancellationToken)
        {
            var wallet = new Wallets
            {
                ownerId = requestr.ownerId,
                balance = requestr.balance,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),
                
            };
            return  ;
        }
    }
}
