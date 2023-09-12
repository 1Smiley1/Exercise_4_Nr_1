using SimpleShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Services
{
    public class CustomerService
    {
        public void Buy(Product product)
        {
            // Logika ogólna dla zakupu klienta
            Console.WriteLine($"Klient kupuje {product.Name} za {product.Price:C}");
        }

        public void Buy(DiscountProduct product)
        {
            decimal discountedPrice = product.Price * (1 - product.Discount);
            Console.WriteLine($"Klient kupuje {product.Name} ze zniżką za {discountedPrice:C}");
        }
    }
}
