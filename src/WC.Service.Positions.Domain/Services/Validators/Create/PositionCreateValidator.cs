using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WC.Library.Domain.Validators;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.Domain.Services.Validators.Model;

namespace WC.Service.Positions.Domain.Services.Validators.Create;

public class PositionCreateValidator : AbstractValidator<PositionModel>, IDomainCreateValidator
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