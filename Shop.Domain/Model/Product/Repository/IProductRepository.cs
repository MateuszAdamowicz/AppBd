using System.Collections;
using System.Collections.Generic;

namespace Shop.Domain.Model.Product.Repository
{
    public interface IProductRepository
    {
        void Insert(Product product);
        void Delete(int id);
        Product Find(int id);
        IEnumerable<Product> FindAll();
    }
}