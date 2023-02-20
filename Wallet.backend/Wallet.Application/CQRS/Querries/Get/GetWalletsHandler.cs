using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WalletService.Application.Interface;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.Get
{
    public class GetWalletsHandler : IRequestHandler<GetWalletsQuery, List<Wallet>>
    {
        private readonly IWalletContext _context;
        public GetWalletsHandler(IWalletContext context)
        {
            _context = context;
        }

        public async Task<List<Wallet>> Handle(GetWalletsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Wallets.ToListAsync(cancellationToken);
        }
    }
}