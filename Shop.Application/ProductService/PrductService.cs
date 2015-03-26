using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model.Product;

namespace Shop.Application.ProductService
{
    public class PrductService : IProductService
    {
        private List<Product> _products;

        public PrductService()
        {
            _products = new List<Product>();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public void CreateNewProduct(Product product)
        {
            _products.Add(product);
        }

        public Product FindProductById(int id)
        {
            return _products.Single(x => x.Id == id);
        }

        public void DeleteProductById(int id)
        {
            var product = FindProductById(id);
            _products.Remove(product);
        }
    }
}