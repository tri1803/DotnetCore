using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Temp.DataAccess;
using Temp.DataAccess.UoW;
using Temp.Service.DTO;
using Temp.Common.Infrastructure;
using Role = Temp.Common.Infrastructure.Role;

namespace Temp.Service.Service
{
    /// <summary>
    /// Account service
    /// </summary>
    public class AccountService : IAccountService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public AccountService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        
        /// <summary>
        /// login
        /// </summary>
        /// <param name="logInDto"></param>
        /// <returns></returns>
        public User LogIn(LogInDto logInDto)
        {
            var account =
                _unitofWork.UserRepository.ObjectContext.Include(s => s.Role).FirstOrDefault(s => s.Username == logInDto.Username && s.Password == logInDto.Password);
            return account;
        }
        
        /// <summary>
        /// register
        /// </summary>
        /// <param name="accDto"></param>
        public void CreateAccount(CreateAccDto accDto)
        {
            accDto.RoleId = (int)Role.User;
            var user = _mapper.Map<CreateAccDto, User>(accDto);
            _unitofWork.UserRepository.Add(user);
            _unitofWork.Save();
        }

        public bool CheckAccount(CreateAccDto accDto)
        {
            var isExist = _unitofWork.UserRepository.ObjectContext.Any(s => s.Username.Equals(accDto.Username));
            if (!isExist)
            {
                return true;
            }            
            return false;               
        }
        
        /// <summary>
        /// change password
        /// </summary>
        /// <param name="passDto"></param>
        /// <returns></returns>
        public bool ChangePass(ChangePassDto passDto)
        {
            var user = _unitofWork.UserRepository.ObjectContext.Include(s => s.Role).FirstOrDefault(s => s.Username == passDto.UserName);
            
            if (user == null) return false;
            var userUpdate = new User
            {
                Username = user.Username,
                Id = user.Id,
                Password = passDto.Password,
                RoleId = user.Id
            };
            _unitofWork.UserRepository.Update(userUpdate);
            _unitofWork.Save();
            return true;
        }

        public bool CheckPass(ChangePassDto passDto)
        {
            var user = _unitofWork.UserRepository.Get(s => s.Username == passDto.UserName);
            if (user != null && user.Password != passDto.CurrentPass)
            {
                return false;
            }

            return true;
        }
    }
}