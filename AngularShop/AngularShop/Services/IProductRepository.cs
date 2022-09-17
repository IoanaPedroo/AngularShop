using AngularShop.Models;

namespace AngularShop.Services
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void DeleteProductById(int id);
        void AddProduct(Product product);
        void UpdateProductById(int id, Product product);
    }
}
