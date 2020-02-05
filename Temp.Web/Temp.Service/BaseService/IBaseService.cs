using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Temp.Service.BaseService
{
    /// <summary>
    /// Interface of base service
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T> where T : class
    {
        /// <summary>
        /// region method
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        
        //get an entity by id
        T GetById(int id, bool allowTracking = true);
        
        //create an entity
        void Add(T entity);
        
        //delete an entity
        void Delete(T entity);
        
        //Edit an entity
        void Update(T entity);
        
        T Get(Expression<Func<T, bool>> where);

        IEnumerable<T> GetMany(Func<T, bool> where);
        
        IQueryable<T> ObjectContext { get; set; }
        
        /// <summary>
        /// region async method
        /// </summary>
        /// <param name="allowTracking"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync(bool allowTracking = true);
        
        Task<T> GetByIdAsync(int id, bool allowTracking = true);
    }
}