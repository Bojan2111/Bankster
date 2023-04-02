using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class TransakcijaProfile : Profile
    {
        public TransakcijaProfile()
        {
            CreateMap<Transakcija, TransakcijaDTO>();
        }
    }
}
