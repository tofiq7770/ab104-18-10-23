using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    internal
class CartItemList
    {
        private List<CartItem> cartItemList = new List<CartItem>();

        public void Add(Product product, int quantity)
        {
            CartItem cartItem = new CartItem(product.Id, product.Name, quantity, product.Price * quantity);
            cartItemList.Add(cartItem);
        }

        public bool IsExists(int productId)
        {
            return cartItemList.Exists(ci => ci.Id == productId);
        }

        public CartItem FindById(int productId)
        {
            return cartItemList.Find(ci => ci.Id == productId);
        }

        public void ShowAll()
        {
            foreach (CartItem cartItem in cartItemList)
            {
                Console.WriteLine($"Id: {cartItem.Id}, Name: {cartItem.Name}, Quantity: {cartItem.Quantity}, Price: {cartItem.Price:C}");
            }
        }
    }

}
