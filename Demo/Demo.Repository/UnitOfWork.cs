using System.Threading.Tasks;
using Demo.Model;

namespace Demo.Repository
{
    
    /// <summary>
    /// Class UnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Grade> GradeRepository { get; private set; }
        public IRepository<Student> StudenRepository { get; private set; }
        public IRepository<Role> RoleRepository { get; private set; }

        public IRepository<User> UseRepository { get; private set; }

        /// <summary>
        /// region inject field variables
        /// </summary>
        private readonly MyContext _context;

        //Contructor inject
        public UnitOfWork(MyContext dbContext)
        {
            _context = dbContext;
            InitRepo();
        }
        
        //init repository
        private void InitRepo()
        {
            GradeRepository = new Repository<Grade>(_context);
            StudenRepository = new Repository<Student>(_context);
            RoleRepository = new Repository<Role>(_context);
            UseRepository = new Repository<User>(_context);
        }
        
        
        //region method
        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}