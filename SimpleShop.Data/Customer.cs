using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Data
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Buy(Product product)
        {
            Console.WriteLine($"{Name} kupuje {product.Name} za {product.Price:C}");
            // Tutaj możesz dodać logikę ogólną dla zakupu, np. obliczenia kosztu.
        }
    }

    public class DiscountCustomer : Customer
    {
        public DiscountCustomer(string name) : base(name)
        {
        }

        public void Buy(DiscountProduct product)
        {
            decimal discountedPrice = product.Price * (1 - product.Discount);
            Console.WriteLine($"{Name} kupuje {product.Name} ze zniżką za {discountedPrice:C}");
            // Tutaj możesz dodać logikę specyficzną dla zakupu produktu ze zniżką.
        }
    }
}
