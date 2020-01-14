using System.Linq;
using AutoMapper;
using Demo.Dto;
using Demo.Model;
using Demo.Repository;
using Demo.Common;

namespace Demo.Service
{
    /// <summary>
    /// Class UserSerive
    /// </summary>
    public class UserService : IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        /// <summary>
        /// override function
        /// </summary>                 
        public User Login(UserLoginDto user)
        {
            User account = _unitOfWork.UseRepository.GetAll().FirstOrDefault(s => s.Username == user.Username && s.Password == user.Password);
            return account;
        }

        public void CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<UserDto, User>(userDto);
            user.Role = new Role();
            _unitOfWork.UseRepository.Add(user);
            _unitOfWork.Save();
        }
    }
}