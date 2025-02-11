using AutoMapper;
using MotoCenter.Application.Dtos.v1;
using MotoCenter.Domain.Models.v1;

namespace MotoCenter.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Motorcycle, MotorcycleDto>().ReverseMap();
        }
    }
}
