using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries
{
    public class GetWalletsQuery : IRequest<List<Wallet>>
    {
        public List<Wallet> WalletList { get; set; }
    }
}
