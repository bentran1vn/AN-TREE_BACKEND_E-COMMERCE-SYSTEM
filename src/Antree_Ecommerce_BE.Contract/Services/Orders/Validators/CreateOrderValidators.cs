using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Orders.Validators;

public class CreateOrderValidators : AbstractValidator<Command.CreateOrderCommand>
{
    public CreateOrderValidators()
    {
        RuleForEach(x => x.OrderItems)
            .ChildRules(orderItem =>
            {
                orderItem.RuleFor(x => x.ProductId)
                    .NotEmpty();
                orderItem.RuleFor(x => x.Quantity)
                    .GreaterThanOrEqualTo(0)
                    .NotEmpty();
            });
    }
}