using System.Threading.Tasks;
using Temp.DataAccess.Repository;

namespace Temp.DataAccess.UoW
{
    /// <summary>
    /// Unit of work
    /// </summary>
    public class UnitofWork : IUnitofWork
    {
        //region inject field variables
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        
        private readonly DataContext _dataContext;

        public UnitofWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        public IRoleRepository RoleRepository
        {
            get
            {
                return _roleRepository =
                    _roleRepository ?? new RoleRepository(_dataContext);
            }
        }
        
        public IUserRepository UserRepository 
        {
            get
            {
                return _userRepository =
                    _userRepository ?? new UserRepository(_dataContext);
            }
        }
        
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository =
                    _categoryRepository ?? new CategoryRepository(_dataContext);
            }
        }
        
        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository =
                    _productRepository ?? new ProductRepository(_dataContext);
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
             await _dataContext.SaveChangesAsync();
        }
    }
}