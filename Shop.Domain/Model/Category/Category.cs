using System.Collections.Generic;

namespace Shop.Domain.Model.Category
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product.Product> Products { get; set; }
    }
}