using FluentValidation;

namespace WalletService.Application.CQRS.Command.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateWalletСommand>
    {
        public CreateCommandValidator() 
        {
            RuleFor(query => query.OwnerId).GreaterThan(0);
        }
    }
}
