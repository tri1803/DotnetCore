using AutoMapper;
using Demo.Dto;
using Demo.Model;

namespace Demo.Common.Mapper
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<UserDto,User>();
            CreateMap<User, UserLoginDto>();
        }
    }
}