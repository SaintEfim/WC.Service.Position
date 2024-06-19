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
                var positions = await positionProvider.Get(cancellationToken);

                var duplicatePosition = positions.Any(x => x.Name == positionModel.Name);

                if (duplicatePosition)
                {
                    context.AddFailure(nameof(PositionModel.Name), "Position with this name already exists.");
                }
            }); 
    }
}