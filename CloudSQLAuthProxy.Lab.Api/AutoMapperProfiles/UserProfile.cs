using AutoMapper;
using CloudSQLAuthProxy.Lab.Api.Models.ServiceModels;
using CloudSQLAuthProxy.Lab.Api.Models.ViewModels;
using CloudSQLAuthProxy.Lab.Repository.Models;

namespace CloudSQLAuthProxy.Lab.Api.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserServiceModel>().ReverseMap();
            CreateMap<UserServiceModel, User>().ReverseMap();
        }
    }
}
