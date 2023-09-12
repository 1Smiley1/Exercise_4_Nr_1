using SimpleShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Services
{
    public class ShopService
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowProducts()
        {
            Console.WriteLine("Dostępne produkty w sklepie:");
            foreach (var product in products)
            {
                Console.WriteLine($"Nazwa: {product.Name}, Cena: {product.Price:C}, Ilość: {product.Quantity}");
            }
        }

        public void SellProduct(Product product, Customer customer)
        {
            var existingProduct = products.FirstOrDefault(p => p.Name == product.Name);

            if (existingProduct != null && existingProduct.Quantity > 0)
            {
                existingProduct.Quantity--;
                customer.Buy(product);
                Console.WriteLine($"Sprzedano: {product.Name} klientowi {customer.Name}");
            }
            else
            {
                Console.WriteLine($"Produkt {product.Name} niedostępny w sklepie.");
            }
        }
    }
}