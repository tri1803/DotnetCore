using AutoMapper;
using Microsoft.CodeAnalysis;
using Temp.DataAccess;
using Temp.Service.DTO;

namespace Temp.Web.Infrastructure.Mapper
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<CreateAccDto, User>();
            //CreateMap<ChangePassDto, User>()
                //.ForMember(dest => dest.Username, opt => opt.Ignore())
                //.ForMember(dest => dest.Password, opt => opt.Ignore());
            CreateMap<ChangePassDto, User>();
        }
    }
}