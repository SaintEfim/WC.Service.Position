using AutoMapper;
using WC.Service.Positions.Data.Models;
using WC.Service.Positions.Domain.Abstractions.Models;

namespace WC.Service.Positions.Domain;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<PositionModel, PositionEntity>().ReverseMap();
    }
}