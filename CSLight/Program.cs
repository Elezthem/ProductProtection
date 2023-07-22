using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ShowProducts();

            List<Product> products = new List<Product>();

            for (int i = 0; i < cart.GetProductCount(); i++)
            {
                products.Add(cart.GetProductByIndex(i));
            }

            products.RemoveAt(0);

            Console.WriteLine();
            cart.ShowProducts();
        }
    }

    class Cart
    {
        private List<Product> _products = new List<Product>();

        public Cart()
        {
            _products.Add(new Product("Nitro Full"));
            _products.Add(new Product("Nitro Basic"));
        }

        public void ShowProducts()
        {
            foreach (var product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public int GetProductCount()
        {
            return _products.Count;
        }

        public Product GetProductByIndex(int index)
        {
            return _products.ElementAt(index);
        }
    }

    class Product
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}