using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.GetByOwnerQuerry
{
    public class GetByOwnerQuerry : IRequest<Wallet>
    {
        public int OwnerId { get; set; }
    }
}
