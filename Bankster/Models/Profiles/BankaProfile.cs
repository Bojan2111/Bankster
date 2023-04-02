using AutoMapper;
using Bankster.Models.DTOs;

namespace Bankster.Models.Profiles
{
    public class BankaProfile : Profile
    {
        public BankaProfile()
        {
            CreateMap<Banka, BankaDTO>();
        }
    }
}
