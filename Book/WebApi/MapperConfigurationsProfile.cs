using AutoMapper;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi;
public class MapperConfigurationsProfile : Profile
{
    public MapperConfigurationsProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
    }
}