using Microsoft.EntityFrameworkCore;
using MediatR;
using WalletService.Domain;
using System.Data;
using WalletService.Application.Interface;

namespace WalletService.Application.CQRS.command.UpdateBalance
{
    public class UpdateBalanceHandler : IRequestHandler<UpdateBalanceCommand, Wallet>
    {

        private IWalletContext _context;
        public UpdateBalanceHandler(IWalletContext context) {
            _context = context;
        }
        public async Task<Wallet> Handle(UpdateBalanceCommand request, CancellationToken cancellationToken)
        {
             var content = _context.Wallets.Find(request.id);
             
             if (content == null) 
             {
                //// ERROR
                return null;
             }

             content.balance = request.balance;
             content.updatedAt = DateTime.Now.ToLocalTime().ToString();
             await _context.SaveChangesAsync(cancellationToken);
            
            return content;
        }
    }
}
