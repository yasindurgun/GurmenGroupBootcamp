using AutoMapper;
using Week3.API_Odev.DTOs;
using Week3.API_Odev.Models;

namespace Week3.API_Odev.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //her iki class ı birbirine çevirebilir.
            CreateMap<Car, CarRequestDto>().ReverseMap();
        }
    }
}
