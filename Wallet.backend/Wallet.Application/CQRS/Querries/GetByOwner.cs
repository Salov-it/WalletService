using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries
{
    public class GetByOwner : IRequest<Wallet>
    {
        public int OwnerId { get; set; }
    }
}
