using Assignment.Domain;
using AutoMapper;

namespace Assignment.Services.Dto
{
    public class CountryMappingProfile : Profile
    {
        public CountryMappingProfile()
        {
            CreateMap<CountryDto,Country>();
        }
    }
}