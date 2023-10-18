using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    internal class Product
    {
        public int Id { get; }
        public string Name { get; }
        public int Stock { get; set; }
        public double Price { get; }

        public Product(int id, string name, int stock, double price)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
