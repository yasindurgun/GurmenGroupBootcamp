using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.ObserverDesignPattern.Models;
using Week3.ObserverDesignPattern.Observers;

namespace Week3.ObserverDesignPattern.Handlers
{
    public class ProductCreatedEventSendSmsHandler : IProductObserver
    {
        public void ProductCreated(Product product)
        {
            Console.WriteLine($"Id: {product.ProductId} Name: {product.ProductName} için sms gönderildi.");
        }
    }
}
