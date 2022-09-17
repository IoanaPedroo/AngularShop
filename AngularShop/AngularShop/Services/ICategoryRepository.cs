using AngularShop.Models;

namespace AngularShop.Services
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void DeleteCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategoryById(int id, Category category);
    }
}
