using System.Collections.Generic;
using Shop.Domain.Model.Product;

namespace Shop.Application.ProductService
{
    public interface IPrductService
    {
        IEnumerable<Product> GetAllProducts();
        void CreateNewProduct(Product product);
        Product FindProductById(int id);
        void DeleteProductById(int id);
    }
}