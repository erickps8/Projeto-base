using AutoMapper;
using Template.Api.Dtos;
using Template.Business.Models;

namespace Template.Api.Configuration
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Example, ExampleDto>().ReverseMap();
        }
    }
}
