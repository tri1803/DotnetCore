using System.Collections.Generic;
using AutoMapper;
using Temp.DataAccess;
using Temp.DataAccess.UoW;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public IEnumerable<Category> GetAll()
        {
            return _unitofWork.CategoryRepository.GetAll();
        }

        public void Save(CategoryDto categoryDto)
        {
            if (categoryDto.Id <= 0)
            {
                var cate = _mapper.Map<CategoryDto, Category>(categoryDto);
                _unitofWork.CategoryRepository.Add(cate);
                _unitofWork.Save();
            }
            else
            {
                var cate = _mapper.Map<CategoryDto, Category>(categoryDto);
                _unitofWork.CategoryRepository.Update(cate);
                _unitofWork.Save();
            }
        }

        public void Delete(int id)
        {
            var cate = _unitofWork.CategoryRepository.GetById(id);
            _unitofWork.CategoryRepository.Delete(cate);
            _unitofWork.Save();
        }

        public CategoryDto GetById(int id)
        {
            var cate = _unitofWork.CategoryRepository.GetById(id);
            return _mapper.Map<Category, CategoryDto>(cate);
        }
    }
}