using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class KlijentProfile : Profile
    {
        public KlijentProfile()
        {
            CreateMap<Klijent, KlijentDTO>().ForMember(k => k.Forma, p => p.MapFrom(src => src.Pol.Forma));
        }
    }
}
