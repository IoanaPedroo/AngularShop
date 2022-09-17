using AngularShop.Models;
using AngularShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return Json(products);
        }
        [HttpGet("{id:int}")]
        public JsonResult GetProduct(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return Json(product);
        }
        [HttpDelete("{id:int}")]
        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProductById(id);
        }

        [HttpPut("{id:int}")]
        public void UpdateProduct(int id, Product product)
        {
            _productRepository.UpdateProductById(id, product);
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

    }
}
