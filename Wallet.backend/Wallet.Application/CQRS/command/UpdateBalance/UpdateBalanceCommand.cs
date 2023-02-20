using MediatR;
using WalletService.Domain;


namespace WalletService.Application.CQRS.Command.UpdateBalance
{
    public class UpdateBalanceCommand : IRequest<Wallet>
    {
        public int id { get; set; }
        public int balance { get; set; }
    }
}
