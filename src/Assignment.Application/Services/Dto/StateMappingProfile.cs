using Assignment.Domain;
using AutoMapper;

namespace Assignment.Services.Dto
{
    public class StateMappingProfile : Profile
    {
        public StateMappingProfile()
        {
            CreateMap<StateDto, State>();
            CreateMap<State, StateDto>();
            // Additional mappings if needed
        }
    }
}