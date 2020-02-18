using AutoMapper;
using Temp.DataAccess.Data;
using Temp.Service.DTO;

namespace Temp.Service.Mapper
{
    /// <summary>
    /// user mapper
    /// </summary>
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            //view model => entities
            CreateMap<CreateAccDto, User>();
            
            //view model => entities
            CreateMap<ChangePassDto, User>();
        }
    }
}