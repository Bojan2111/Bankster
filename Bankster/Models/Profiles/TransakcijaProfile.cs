using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class TransakcijaProfile : Profile
    {
        public TransakcijaProfile()
        {
            CreateMap<Transakcija, TransakcijaDTO>()
                .ForMember(r => r.UplatilacRacun, t => t.MapFrom(src => $"{src.UplatilacRacun.Banka.Kod}-{src.UplatilacRacun.Broj}-{src.UplatilacRacun.KontrolniBroj}"))
                .ForMember(r => r.PrimalacRacun, t => t.MapFrom(src => $"{src.PrimalacRacun.Banka.Kod}-{src.PrimalacRacun.Broj}-{src.PrimalacRacun.KontrolniBroj}"))
                .ForMember(r => r.UplatilacPunoIme, t => t.MapFrom(src => src.UplatilacRacun.Klijent.Ime + " " + src.UplatilacRacun.Klijent.Prezime))
                .ForMember(r => r.PrimalacPunoIme, t => t.MapFrom(src => src.PrimalacRacun.Klijent.Ime + " " + src.PrimalacRacun.Klijent.Prezime));
        }
    }
}
