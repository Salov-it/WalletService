using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.Get
{
    public class GetWalletsQuery : IRequest<List<Wallet>>
    {
    }
}
