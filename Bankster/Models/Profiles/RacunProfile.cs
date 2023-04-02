using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class RacunProfile : Profile
    {
        public RacunProfile()
        {
            CreateMap<Racun, RacunDTO>();
        }
    }
}
