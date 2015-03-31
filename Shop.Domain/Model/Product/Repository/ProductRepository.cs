using System.Collections.Generic;
using System.Linq;

namespace Shop.Domain.Model.Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private IList<Product> _products; 
        public void Insert(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            _products.Remove(Find(id));
        }

        public Product Find(int id)
        {
            var result = _products.Single(x => x.Id == id);
            return result;
        }

        public IEnumerable<Product> FindAll()
        {
            return _products;
        }
    }
}