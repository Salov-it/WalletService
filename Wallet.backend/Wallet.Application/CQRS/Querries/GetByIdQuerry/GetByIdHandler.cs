
using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.GetByIdQuerry
{
    internal class GetByIdHandler : IRequestHandler<GetByIdQuerry, Wallet>
    {
        private readonly IWalletContext _walletContext;
        public GetByIdHandler(IWalletContext walletContext) 
        {
            _walletContext = walletContext;
        }
        public async Task<Wallet> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _walletContext.Wallets.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
