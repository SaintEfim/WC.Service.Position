using WC.Library.Domain.Models;

namespace WC.Service.Positions.Domain.Abstractions.Models;

public class PositionModel : ModelBase
{
    public string Name { get; set; } = string.Empty;
}