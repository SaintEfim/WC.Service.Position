using AutoMapper;
using WC.Service.Positions.Domain.Abstractions.Models;
using WC.Service.Positions.gRPC.Server.Services;

namespace WC.Service.Positions.gRPC.Server;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CheckPositionRequest, PositionModel>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Position.Name));
    }
}