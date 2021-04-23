using FluentValidation;

namespace Application.Cushions.Queries.SingleCushion
{
    public class SingleCushionQueryValidator : AbstractValidator<SingleCushionQuery>
    {
        public SingleCushionQueryValidator()
        {
            RuleFor(x => x.Stand).InclusiveBetween(1,4).WithMessage("Stand number out of range - please provide number from 1 to 4.");
            RuleFor(x => x.RollPosition).InclusiveBetween(0,1).WithMessage("Roll position out of range - please provide 0 for bottom roll or 1 for top roll.");
        }
    }
}
