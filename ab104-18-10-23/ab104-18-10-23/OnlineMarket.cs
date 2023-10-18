using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    internal class OnlineMarket
    {
        public CartItemList Cart { get; }
        public ProductList Products { get; }
        public string Name { get; }
        public int Id { get; }

        public OnlineMarket(string name)
        {
            Cart = new CartItemList();
            Products = new ProductList();
            Name = name;
            Id = IdCounter++;
        }

        private static int IdCounter = 1;
    }
}
