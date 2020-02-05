using System.Collections.Generic;
using Temp.DataAccess;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();

        void Save(CategoryDto categoryDto);

        void Delete(int id);

        CategoryDto GetById(int id);
            
        
    }
}