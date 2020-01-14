using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Model;
using System.Linq;

namespace Demo.Repository
{
    
    //generic repository
    public class Repository<T> : IRepository<T> where T : class 
    {
        //region Properties
        private readonly MyContext _myContext;
        private readonly DbSet<T> _dbSet;   
        
        //generic contructor
        public Repository(MyContext dbContext)
        {            
            _myContext = dbContext;
            _dbSet = _myContext.Set<T>();            
        }
        
        //getall entity T
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        
        //get an entity T
        public T GetById(int id, bool allowTracking = true)
        {
            return _dbSet.Find(id);
        }
        
        //create new entity T
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        
        //delete an entity T
        public void Delete(T entity)
        {            
            _dbSet.Remove(entity);          
        }
        
        //edit an entity T
        public void Update(T entity)
        {            
            _myContext.Entry(entity).State = EntityState.Modified;
            _dbSet.Attach(entity);
        }
        //getall async
        public async Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true)
        {
            var data = await _dbSet.ToListAsync();

            return data;
        }
        //get an entity T async
        public async Task<T> GetByIdAsync(int id, bool allowTracking = true)
        {
            var data = await _dbSet.FindAsync(id);
            return data;
        }
    }
}