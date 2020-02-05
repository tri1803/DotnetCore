using AutoMapper;
using Temp.DataAccess;
using Temp.Service.DTO;

namespace Temp.Web.Infrastructure.Mapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryDto>();
        }
    }
}