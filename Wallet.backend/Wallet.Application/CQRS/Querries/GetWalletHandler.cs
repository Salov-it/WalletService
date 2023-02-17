using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries
{
    public class GetWalletHandler : IRequestHandler<GetWalletsQuery, List<Wallet>>
    {
        private IWalletContext _context;
        public GetWalletHandler(IWalletContext context)
        {
            _context = context;
        }

        public async Task<List<Wallet>> Handle(GetWalletsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Wallets.ToListAsync(cancellationToken);
        }
    }
}