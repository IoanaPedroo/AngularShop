using AngularShop.Models;
using AngularShop.Models.InitDatabase;
using AngularShop.Services;

namespace AngularShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _context;

        public CategoryRepository(StoreContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;

        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public void UpdateCategoryById(int id, Category category)
        {
            var oldCategory = _context.Categories.FirstOrDefault(x => x.Id == id);
            oldCategory.Name = category.Name;
            _context.SaveChanges();

        }
    }
}
