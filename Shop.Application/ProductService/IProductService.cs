using System.Collections.Generic;

namespace Shop.Application.ProductService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        void CreateNewProduct(Product product);
    }
}