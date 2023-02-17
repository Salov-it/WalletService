using MediatR;
using WalletService.Domain;


namespace WalletService.Application.CQRS.command.UpdateBalance
{
    public class UpdateBalanceCommand : IRequest<Wallet>
    {
        public int id { get; set; }
        public int balance { get; set; }
    }
}
