using WC.Library.Web.Models;

namespace WC.Service.Positions.API.Models;

public class PositionDto : DtoBase
{
    public string Name { get; set; } = string.Empty;
}