using AutoMapper;
using STShop.Model;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ApplicationUser, UserModel>().ReverseMap();
        }
    }
}