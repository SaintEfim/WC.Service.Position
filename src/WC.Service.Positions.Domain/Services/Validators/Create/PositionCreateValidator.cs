using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WC.Service.Positions.Domain.Abstractions.Models;

namespace WC.Service.Positions.Domain.Services.Validators.Create;

public class PositionCreateValidator : AbstractValidator<PositionModel>
{
    public PositionCreateValidator(IServiceProvider provider)
    {
        ClassLevelCascadeMode = CascadeMode.Stop;
        
        RuleFor(x => x)
            .SetValidator(provider.GetService<PositionModelValidator>());

        RuleFor(x => x)
            .SetValidator(provider.GetService<PositionCreateDbValidator>());
    }
}