using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class KlijentProfile : Profile
    {
        public KlijentProfile()
        {
            CreateMap<Klijent, KlijentDTO>();
        }
    }
}
