using Microsoft.EntityFrameworkCore;
using MediatR;
using Wallet.Domain;
using Wallet.infrastructure;
using System.Data;


namespace Wallet.Application.CQRS.command.UpdateBalance
{
    public class UpdateBalanceHandler : IRequestHandler<UpdateBalanceCommand, int>
    {
       
        public async Task<int> Handle(UpdateBalanceCommand request, CancellationToken cancellationToken)
        {
             var db = new WalletContext();
             var content = db.wallets.Find(request.id);

             content.balance = request.balance;
             content.updatedAt = DateTime.Now.ToLocalTime().ToString();
             db.SaveChanges();
            
            return 1;
        }
    }
}
