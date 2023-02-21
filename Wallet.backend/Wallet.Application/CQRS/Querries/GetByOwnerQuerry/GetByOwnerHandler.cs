using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.GetByOwnerQuerry
{
    internal class GetByOwnerHandler : IRequestHandler<GetByOwnerQuerry, Wallet>
    {
        private readonly IWalletContext _context;
        public GetByOwnerHandler(IWalletContext context)
        {
            _context = context;
        }
        public async Task<Wallet> Handle(GetByOwnerQuerry request, CancellationToken cancellationToken)
        {
            var wallet = await _context.Wallets.FirstOrDefaultAsync(w => w.ownerId == request.OwnerId);
            if (wallet == null)
            {
                return null;
            }
            return wallet;
        }
    }
}
