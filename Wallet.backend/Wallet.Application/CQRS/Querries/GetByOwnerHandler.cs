using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries
{
    internal class GetByOwnerHandler : IRequestHandler<GetByOwner, Wallet>
    {
        private IWalletContext _context;
        public GetByOwnerHandler(IWalletContext context)
        {
            _context = context;
        }

        public async Task<Wallet> Handle(GetByOwner request, CancellationToken cancellationToken)
        {
            var wallet = await _context.Wallets.FirstOrDefaultAsync(w => w.ownerId == request.OwnerId);
            if (wallet == null)
            {
                //// ERROr
                return null;
            }
            return wallet;
        }
    }
}
