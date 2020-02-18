using System.Threading.Tasks;
using Temp.DataAccess.Data;

namespace Temp.Service.BaseService
{
    /// <summary>
    /// interface of unit of work
    /// </summary>
    public interface IUnitofWork
    {
        /// <summary>
        /// role repo
        /// </summary>
        IBaseService<Role> RoleBaseService { get; }
        
        /// <summary>
        /// user repo
        /// </summary>
        IBaseService<User> UserBaseService { get; }
        
        /// <summary>
        /// Category repo
        /// </summary>
        IBaseService<Category> CategoryBaseService { get; }
        
        /// <summary>
        /// product repo
        /// </summary>
        IBaseService<Product> ProductBaseService { get; }
        
        /// <summary>
        /// save
        /// </summary>
        void Save();
        
        /// <summary>
        /// save async
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();
    }
}