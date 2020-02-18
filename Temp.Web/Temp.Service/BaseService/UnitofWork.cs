using System.Threading.Tasks;
using Temp.DataAccess.Data;

namespace Temp.Service.BaseService
{
    /// <summary>
    /// Unit of Work
    /// </summary>
    public class UnitofWork : IUnitofWork
    {
        //region inject field variables
        private IBaseService<Role> _roleBaseService;
        private IBaseService<User> _userBaseService;
        private IBaseService<Category> _cateBaseService;
        private IBaseService<Product> _productBaseService;
        
        private readonly DataContext _dataContext;
        
        public UnitofWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        /// <summary>
        /// Role repo
        /// </summary>
        public IBaseService<Role> RoleBaseService
        {
            get
            {
                return _roleBaseService =
                    _roleBaseService ?? new BaseService<Role>(_dataContext);
            }
        }
        
        /// <summary>
        /// User repo
        /// </summary>
        public IBaseService<User> UserBaseService 
        {
            get
            {
                return _userBaseService =
                    _userBaseService ?? new BaseService<User>(_dataContext);
            }
        }
        
        /// <summary>
        /// Category repo
        /// </summary>
        public IBaseService<Category> CategoryBaseService
        {
            get
            {
                return _cateBaseService =
                    _cateBaseService ?? new BaseService<Category>(_dataContext);
            }
        }
        
        /// <summary>
        /// product repo
        /// </summary>
        public IBaseService<Product> ProductBaseService
        {
            get
            {
                return _productBaseService =
                    _productBaseService ?? new BaseService<Product>(_dataContext);
            }
        }
        
        /// <summary>
        /// save change
        /// </summary>
        public void Save()
        {
            _dataContext.SaveChanges();
        }
        
        /// <summary>
        /// save change async
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}