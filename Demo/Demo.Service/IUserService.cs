using Demo.Dto;
using Demo.Model;

namespace Demo.Service
{
    /// <summary>
    /// Interface UserService
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// function
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// 
        User Login(UserLoginDto user);
                
        void CreateUser(UserDto user);
        
        
        
    }
}