using FluentValidation;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.Domain.Abstractions.Services;

namespace WC.Service.Positions.Domain.Services.Validators.Create;

public class PositionCreateDbValidator : AbstractValidator<PositionModel>
{
    public PositionCreateDbValidator(IPositionProvider positionProvider)
    {
        RuleFor(x => x)
            .CustomAsync(async (positionModel, context, cancellationToken) =>
            {
                var position = await positionProvider.GetOneById(positionModel.Id, cancellationToken);

                if (position != null)
                {
                    context.AddFailure("Position", "Duplicate position found.");
                }
            });
    }
}