using SimpleShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Gui
{
    public static class ConsoleGui
    {
        public static void MainScreen()
        {
            Console.WriteLine("1. Dodaj Produkt");
            Console.WriteLine("2. Pokaż Produkty");
            Console.WriteLine("3. Sprzedaj Produkt");
            Console.WriteLine("4. Wyjdź");
        }

        public static Product GetProductDetails()
        {
            Console.Write("Podaj nazwę produktu: ");
            var name = Console.ReadLine();
            Console.Write("Podaj cenę produktu: ");
            var price = decimal.Parse(Console.ReadLine());
            Console.Write("Podaj ilość produktu: ");
            var quantity = int.Parse(Console.ReadLine());

            return new Product { Name = name, Price = price, Quantity = quantity };
        }

        public static void SellProduct()
        {
            Console.Write("Podaj nazwę klienta: ");
            var customerName = Console.ReadLine();
            var customer = new Customer(customerName); // Utwórz klienta z odpowiednim imieniem
            Console.Write("Podaj nazwę produktu do sprzedaży: ");
            var productName = Console.ReadLine();
            var product = new Product { Name = productName };

            // Tutaj możesz wywołać odpowiednią metodę SellProduct z ShopService
        }
    }
}
