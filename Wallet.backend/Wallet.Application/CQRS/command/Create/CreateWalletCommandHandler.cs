using MediatR;
using WalletService.Application.Interface;
using WalletService.Domain;


namespace WalletService.Application.CQRS.Command.Create
{
    public class CreateWalletCommandHandler : IRequestHandler<CreateWalletСommand, Wallet>
    {

        // Constructor for DI
        public CreateWalletCommandHandler(IWalletContext context) 
        {
            _walletContext = context;
        }
        private IWalletContext _walletContext;
        public async Task<Wallet> Handle(CreateWalletСommand request, CancellationToken cancellationToken)
        {
            var content = new Wallet
            {
                ownerId = request.OwnerId,
                balance = 0,
                createdAt = DateTime.Now.ToLocalTime().ToString(),
            };
            await _walletContext.Wallets.AddAsync(content, cancellationToken);
            await _walletContext.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
