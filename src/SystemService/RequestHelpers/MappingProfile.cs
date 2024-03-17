using AutoMapper;
using ControlService.DTOs;

namespace SystemService.RequestHelpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Control, ControlDto>();
            CreateMap<ControlDto, Control>();
        }        
    }
}