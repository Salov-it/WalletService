using MediatR;

namespace Wallet.Application.CQRS.command.UpdateBalance
{
    public class UpdateBalanceCommand : IRequest<int>
    {
        public int id { get; set; }
        public int balance { get; set; }
    }
}
