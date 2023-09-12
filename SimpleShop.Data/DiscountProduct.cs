using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Data
{
    public class DiscountProduct : Product
    {
        public decimal Discount { get; set; }

        public DiscountProduct(string name, decimal price, int quantity, decimal discount)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }
    }
}
