using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.Command.Create
{
    public class CreateWalletСommand : IRequest<Wallet>
    {
        public int OwnerId { get; set; }
    }
}
