using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<Wallet>
    {
        public int Id { get; set; }
    }
}
