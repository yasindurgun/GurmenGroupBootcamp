using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.ObserverDesignPattern.Models
{
    public class Product
    {
        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

    }
}
