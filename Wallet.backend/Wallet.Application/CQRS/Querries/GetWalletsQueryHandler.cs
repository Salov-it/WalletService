using MediatR;
using WalletService.Application.Interface;
using WalletService.Domain;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoMapper;

namespace WalletService.Application.CQRS.Querries
{
    public class GetWalletsQueryHandler : IRequestHandler<GetWalletsQuery, List<Wallet>>
    {
        private IWalletContext _context;
        private MediatR.IMediator _mediator;
    
        public GetWalletsQueryHandler(IWalletContext context)
        {
            _context = context;
        }
      
        public async Task<List<Wallet>> Handle(GetWalletsQuery request, CancellationToken cancellationToken)
        {
          var content = _context.Wallets.ToList();

            if(content == null )
            {
                return null;
            }
            
            return content;
        }
    }
}
