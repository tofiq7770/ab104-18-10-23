using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using ab104_18_10_23;

class Program
{
    static void Main(string[] args)
    {
        OnlineMarket market = new OnlineMarket("SuperStore");
        int productIdCounter = 1;
        int cartItemIdCounter = 1;

        while (true)
        {
            Console.WriteLine("[1] Add a product to the market");
            Console.WriteLine("[2] Remove a product from the market");
            Console.WriteLine("[3] Add a product to the cart");
            Console.WriteLine("[4] Show products in the market");
            Console.WriteLine("[5] Show products in the cart");
            Console.WriteLine("[6] Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter the stock quantity: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Enter the price: ");
                    double price = double.Parse(Console.ReadLine());
                    Product product = new Product(productIdCounter++, productName, stock, price);
                    market.Products.Add(product);
                    Console.WriteLine($"{productName} added.");
                    break;

                case "2":
                    Console.Write("Enter the Id of the product to remove: ");
                    int productIdToRemove = int.Parse(Console.ReadLine());
                    Product productToRemove = market.Products.FindById(productIdToRemove);
                    if (productToRemove != null)
                    {
                        market.Products.Remove(productToRemove.Id);
                        Console.WriteLine($"{productToRemove.Name} removed.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case "3":
                    Console.Write("Enter the Id of the product to add to the cart: ");
                    int productIdToAddToCart = int.Parse(Console.ReadLine());
                    Product productToAddToCart = market.Products.FindById(productIdToAddToCart);
                    if (productToAddToCart != null)
                    {
                        Console.Write("Enter the quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        market.Cart.Add(productToAddToCart, quantity);
                        Console.WriteLine($"{quantity} units of {productToAddToCart.Name} added to the cart.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Products available in the market:");
                    market.Products.ShowAll();
                    break;

                case "5":
                    Console.WriteLine("Products in the cart:");
                    market.Cart.ShowAll();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
