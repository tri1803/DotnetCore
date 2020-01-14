using System.Threading.Tasks;
using Demo.Model;

namespace Demo.Repository
{
    /// <summary>
    /// Interface UnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        
        IRepository<Grade> GradeRepository { get; }
        IRepository<Student> StudenRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<User> UseRepository { get; }
        
        /// <summary>
        /// Method Save
        /// </summary>
        void Save();
        Task SaveAsync();
    }
}