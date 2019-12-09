using NetCoreCQRSMEdiatR.Commands;
using FluentValidation;

namespace NetCoreCQRSMEdiatR.Validation
{
    public class CreateCustomerOrderCommandValidator : AbstractValidator<CreateCustomerOrderCommand>
    {
        public CreateCustomerOrderCommandValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty();
            
            RuleFor(x => x.ProductId)
                .NotEmpty();
        }
    }
}