using AngularShop.Models;
using AngularShop.Models.InitDatabase;
using AngularShop.Services;

namespace AngularShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges(true);
        }

        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public void UpdateProductById(int id, Product product)
        {
            var oldProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            oldProduct.Title = product.Title;
            oldProduct.Description = product.Description;
            oldProduct.Category = product.Category;
            oldProduct.Price = product.Price;
            oldProduct.DiscountPercentage = product.DiscountPercentage;
            oldProduct.Rating = product.Rating;
            oldProduct.Brand = product.Brand;
            oldProduct.Thumbnail = product.Thumbnail;
            oldProduct.Stock = product.Stock;
            oldProduct.Images = product.Images;
            _context.SaveChanges();
        }
    }
}
