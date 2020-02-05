using System.Threading.Tasks;
using Temp.DataAccess.Repository;

namespace Temp.DataAccess.UoW
{
    /// <summary>
    /// unit of work interface
    /// </summary>
    public interface IUnitofWork
    {
        IUserRepository UserRepository { get;  }
        IRoleRepository RoleRepository { get;  }
        ICategoryRepository CategoryRepository { get;  }
        IProductRepository ProductRepository { get;  }
                     
        void Save();
        Task SaveAsync();
    }
}