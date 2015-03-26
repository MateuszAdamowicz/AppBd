using System.Collections;
using System.Collections.Generic;
using Shop.Domain.Model.Product;

namespace Shop.Application
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        void CreateNewProduct(Product product);
    }
}