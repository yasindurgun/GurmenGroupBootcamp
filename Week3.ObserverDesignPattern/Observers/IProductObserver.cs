using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.ObserverDesignPattern.Models;

namespace Week3.ObserverDesignPattern.Observers
{
    public interface IProductObserver
    {
        void ProductCreated(Product product);
    }
}
