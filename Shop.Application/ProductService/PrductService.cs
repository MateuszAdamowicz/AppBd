using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Product;
using Shop.Domain.Model.Product.Repository;

namespace Shop.Application.ProductService
{
    public class PrductService : IPrductService
    {
        private IProductRepository _productRepository;

        public PrductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.FindAll();
        }

        public void CreateNewProduct(Product product)
        {
            _productRepository.Insert(product);
        }

        public Product FindProductById(int id)
        {
            return _productRepository.Find(id);
        }

        public void DeleteProductById(int id)
        {
            _productRepository.Delete(id);
        }
    }
}