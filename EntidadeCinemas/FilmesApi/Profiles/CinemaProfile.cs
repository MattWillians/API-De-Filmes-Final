using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Routing.Matching;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(dto => dto.ReadEndereco,
                opt => opt.MapFrom(dto => dto.Endereco))
                .ForMember(dto => dto.ReadSessoes,
                opt => opt.MapFrom(dto => dto.Sessoes));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
