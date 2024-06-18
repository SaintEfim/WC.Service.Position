using FluentValidation;
using WC.Library.Employee.Shared.Validators;
using WC.Service.Positions.Domain.Abstractions.Models;

namespace WC.Service.Positions.Domain.Services.Validators;

public class PositionModelValidator : AbstractValidator<PositionModel>
{
    public PositionModelValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .SetValidator(new PositionValidator(nameof(PositionModel.Name)));
    }
}