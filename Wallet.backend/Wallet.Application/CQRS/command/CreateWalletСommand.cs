using MediatR;

namespace Wallet.Application.CQRS.command
{
    public class CreateWalletСommand : IRequest<int>
    {
        public int OwnerId { get; set; }

    }
}
