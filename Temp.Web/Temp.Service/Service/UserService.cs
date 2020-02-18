using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Temp.Common.Infrastructure;
using Temp.DataAccess.Data;
using Temp.Service.BaseService;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    /// <summary>
    /// user service class
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// userservice constructor
        /// </summary>
        public UserService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAll()
        {
            return _unitofWork.UserBaseService.GetAll();
        }

        /// <summary>
        /// get all user
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllIncluding()
        {
            return _unitofWork.UserBaseService.ObjectContext.Include(s => s.Role).ToList();
        }
        
        /// <summary>
        /// create or edit user
        /// </summary>
        /// <param name="userDto"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Save(UserDto userDto)
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// delete user
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete()
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// approve request expired for user
        /// </summary>
        /// <param name="user"></param>
        public void ApproveRequestExpired(User user)
        {
            user.Type = (int) UserType.None;
            user.ExpiredDate = DateTime.Now.AddMinutes(1);
            _unitofWork.Save();
        }
        
        /// <summary>
        /// reject request expired for user
        /// </summary>
        /// <param name="user"></param>
        public void RejectRequestExpired(User user)
        {
            user.Type = (int) UserType.None;
            _unitofWork.Save();
        }
        
        /// <summary>
        /// get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(int id)
        {
            var user = _unitofWork.UserBaseService.GetById(id);
            return user;
        }
    }
}