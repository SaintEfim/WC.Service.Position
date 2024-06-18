using AutoMapper;
using WC.Library.Web.Models;
using WC.Service.Positions.API.Models;
using WC.Service.Positions.Domain.Abstractions.Models;

namespace WC.Service.Positions.API;

public sealed class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<PositionModel, CreateActionResultDto>();
        CreateMap<PositionCreateDto, PositionModel>();
        CreateMap<PositionModel, PositionDto>().ReverseMap();
    }
}