using AutoMapper;
using ControlService.DTOs;

namespace ControlService.RequestHelpers
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