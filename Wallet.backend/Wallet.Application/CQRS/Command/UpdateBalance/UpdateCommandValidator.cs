using FluentValidation;

namespace WalletService.Application.CQRS.Command.UpdateBalance
{
    internal class UpdateCommandValidator : AbstractValidator<UpdateBalanceCommand>
    {
        public UpdateCommandValidator() 
        {
            RuleFor(opt => opt.id).NotEmpty();
            RuleFor(opt => opt.id).GreaterThan(0);
            RuleFor(opr=> opr.balance).GreaterThan(0);
        }
    }
}
