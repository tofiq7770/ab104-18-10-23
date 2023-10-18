using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    internal class CartItem
    {
        public int Id { get; }
        public string Name { get; }
        public int Quantity { get; set; }
        public double Price { get; }

        public CartItem(int id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

}
