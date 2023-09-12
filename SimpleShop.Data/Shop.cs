using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Data
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        public Shop()
        {
            // Inicjalizacja sklepu przykładowymi produktami.
            InitializeShopWithSampleProducts();
        }

        // Metoda do dodawania produktu do listy produktów sklepu.
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Metoda do wyświetlania dostępnych produktów w sklepie.
        public void ShowProducts()
        {
            Console.WriteLine("Dostępne produkty w sklepie:");
            foreach (var product in products)
            {
                Console.WriteLine($"Nazwa: {product.Name}, Cena: {product.Price:C}, Ilość: {product.Quantity}");
            }
        }

        // Metoda do sprzedaży produktu z listy sklepu.
        public void SellProduct(Product product, Customer customer)
        {
            var existingProduct = products.FirstOrDefault(p => p.Name == product.Name);

            if (existingProduct != null && existingProduct.Quantity > 0)
            {
                existingProduct.Quantity--;
                Console.WriteLine($"Sprzedano: {product.Name}");
            }
            else
            {
                Console.WriteLine($"Produkt {product.Name} niedostępny w sklepie.");
            }
        }

        // Inicjalizacja sklepu przykładowymi produktami.
        private void InitializeShopWithSampleProducts()
        {
            // Przykładowa lista produktów
            var sampleProducts = new List<Product>
        {
            new Product { Name = "Chleb", Price = 2.5m, Quantity = 20 },
            new Product { Name = "Mleko", Price = 1.8m, Quantity = 15 },
            new Product { Name = "Jajka", Price = 3.0m, Quantity = 30 },
            new Product { Name = "Masło", Price = 4.5m, Quantity = 10 },
            new Product { Name = "Cukier", Price = 2.0m, Quantity = 25 },
            new Product { Name = "Makaron", Price = 2.2m, Quantity = 18 },
            new Product { Name = "Ryż", Price = 3.3m, Quantity = 22 },
            new Product { Name = "Kawa", Price = 12.0m, Quantity = 8 },
            new Product { Name = "Herbata", Price = 6.5m, Quantity = 12 },
            new Product { Name = "Pomarańcze", Price = 1.2m, Quantity = 40 }
        };

            // Dodaj produkty do sklepu
            products.AddRange(sampleProducts);
        }
    }
}
