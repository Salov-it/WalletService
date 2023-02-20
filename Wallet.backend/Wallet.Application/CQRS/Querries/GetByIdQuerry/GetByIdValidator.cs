using FluentValidation;

namespace WalletService.Application.CQRS.Querries.GetByIdQuerry
{
    internal class GetByIdValidator : AbstractValidator<GetByIdQuerry>
    {
        public GetByIdValidator()
        {
            RuleFor(opt => opt.Id).NotEmpty();
            RuleFor(opt => opt.Id).GreaterThan(0);
        }
    }
}
