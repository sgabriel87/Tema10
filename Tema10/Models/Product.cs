using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10.Models
{
    public class Product
    {
        public enum ProductType
        {
            Food,
            Electronics,
            Clothing,
        }
        public ProductType Type { get; private set; }
        public double Price { get; private set; }
        public Product(ProductType type, double price)
        {
            Type = type;
            Price = price;
        }
    }
}
