using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab104_18_10_23
{
    internal class ProductList
    {
        private List<Product> productList = new List<Product>();

        public void Add(Product product)
        {
            productList.Add(product);
        }

        public void Remove(int productId)
        {
            Product product = productList.Find(p => p.Id == productId);
            if (product != null)
            {
                productList.Remove(product);
            }
        }

        public Product FindById(int productId)
        {
            return productList.Find(p => p.Id == productId);
        }

        public void ShowAll()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}, Stock: {product.Stock}");
            }
        }
    }

}
