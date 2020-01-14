using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Repository
{
    
    /// <summary>
    /// Interface Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        //region method 
        
        //get all <T>
        IEnumerable<T> GetAll();
        
        //get an entity by id
        T GetById(int id, bool allowTracking = true);
        
        //create an entity
        void Add(T entity);
        
        //delete an entity
        void Delete(T entity);
        
        //Edit an entity
        void Update(T entity);
        
        
        //region async method
        Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true);
        
        Task<T> GetByIdAsync(int id, bool allowTracking = true);
        
    }
}