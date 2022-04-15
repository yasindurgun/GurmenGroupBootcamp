using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.ObserverDesignPattern.Models;
using Week3.ObserverDesignPattern.Observers;

namespace Week3.ObserverDesignPattern.Handlers
{
    public class ProductCreatedEventSendEmailHandler : IProductObserver
    {
        public ProductCreatedEventSendEmailHandler()
        {
            //normalde ILogger DI Container olarak geçilmişti biizm örneğimizde fakat ben console üzerinden
            //simülasyon yapacağım.
            //Ayriyeten 
        }
        public void ProductCreated(Product product)
        {
            Console.WriteLine($"Id: {product.ProductId} Name: {product.ProductName} için mail gönderildi.");
        }
    }
}
