using AngularShop.Models;
using AngularShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularShop.Controllers
{
    [ApiController]
    [Route("/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public JsonResult GetCategories()
        {
            List<Category> products = _categoryRepository.GetAllCategories();
            return Json(products);
        }
        [HttpGet("{id:int}")]
        public JsonResult GetProduct(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            return Json(category);
        }
        [HttpDelete("{id:int}")]
        public void DeleteProduct(int id)
        {
            _categoryRepository.DeleteCategoryById(id);
        }

        [HttpPut("{id:int}")]
        public void UpdateProduct(int id, Category category)
        {
            _categoryRepository.UpdateCategoryById(id, category);
        }

        [HttpPost]
        public void AddProduct(Category category)
        {
            _categoryRepository.AddCategory(category);
        }


    }
}
