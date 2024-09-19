using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Feedbacks.Validators;

public class GetFeedbacksValidators : AbstractValidator<Query.GetFeedbacksQuery>
{
    public GetFeedbacksValidators()
    {
        RuleFor(x => x.ProductId).NotEmpty();
    }
}