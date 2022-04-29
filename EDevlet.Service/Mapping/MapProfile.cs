using AutoMapper;
using EDevlet.Core.DTOs;
using EDevlet.Core.Models;

namespace EDevlet.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
        }
    }
}
