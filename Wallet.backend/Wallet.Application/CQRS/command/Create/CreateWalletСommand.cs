using MediatR;
using WalletService.Domain;

namespace WalletService.Application.CQRS.command.Create
{
    public class CreateWalletСommand : IRequest<Wallet>
    {
        public int OwnerId { get; set; }
    }
}
