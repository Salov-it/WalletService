using System;
using System.Data;
using MediatR;
using Wallet.Application.Interfaces;
using Wallet.Domain;
namespace Wallet.Application.SQRS.Commands.Create
{
    public class CreateWalletCommandHandler :IRequestHandler<CreateWalletCommand, Guid>
    {
        private readonly IWalletDbContext _dbContext;
        public CreateWalletCommandHandler(IWalletDbContext dbContext) => _dbContext = dbContext;
        public async Task<Guid>Handle(CreateWalletCommand requestr, CancellationToken cancellationToken)
        {
            var wallet = new Wallets
            {
                ownerId = requestr.ownerId,
                balance = requestr.balance,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
                updatedAt = DateTime.Now.ToLocalTime().ToString(),
                
                
            };  

            await _dbContext.wallets.AddAsync(wallet, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Guid.NewGuid() ;
        }
    }
}
