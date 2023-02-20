using FluentValidation;
namespace WalletService.Application.CQRS.Querries.GetByOwnerQuerry
{
    internal class GetByOwnerValidator : AbstractValidator<GetByOwnerQuerry>
    {
        public GetByOwnerValidator() 
        {
            RuleFor(opt => opt.OwnerId).NotEmpty();
            RuleFor(opt => opt.OwnerId).GreaterThan(0);
        }
    }
}
