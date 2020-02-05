using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Temp.DataAccess.Repository
{    
    /// <summary>
    /// Class repository typeof(T) 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
            ObjectContext = _dbSet;
        }

        public IEnumerable<T> GetMany(Func<T, bool> where)
        {
            return _dbSet.AsEnumerable().Where(where);
        }

        public IQueryable<T> ObjectContext { get; set; }
        
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id, bool allowTracking = true)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {      
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
            
           
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, bool allowTracking = true)
        {
            throw new NotImplementedException();
        }
    }
}