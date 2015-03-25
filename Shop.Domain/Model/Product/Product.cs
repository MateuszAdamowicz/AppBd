using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Shop.Domain.Model.Category;

namespace Shop.Domain.Model.Product
{
    public class Product
    {
        public int Id { get; set; }
        public Photos Photos { get; set; }
        public int Quantity { get; set; }
        public Price Price { get; set; }
        public IEnumerable<Property> Properties{ get; set; }
        public ProductDetails ProductDetails { get; set; }
        public Category.Category Category{ get; set; }
    }
}