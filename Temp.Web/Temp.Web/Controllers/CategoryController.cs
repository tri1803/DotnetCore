using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Temp.Service.DTO;
using Temp.Service.Service;

namespace Temp.Web.Controllers
{
    /// <summary>
    /// Category controller
    /// </summary>
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        /// <summary>
        /// List categories
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy ="User")]
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }

        /// <summary>
        /// Insert or edit category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Save(int id)
        {
            if (id <= 0)
            {
                return View();
            }

            return View(_categoryService.GetById(id));

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy ="Admin")]
        public IActionResult Save(CategoryDto categoryDto)
        {
            _categoryService.Save(categoryDto);
            return Redirect("/category/index");
            
        }
        
        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Redirect("/category/index");
        }
    }
}