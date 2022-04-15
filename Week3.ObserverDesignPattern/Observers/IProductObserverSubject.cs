using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.ObserverDesignPattern.Models;

namespace Week3.ObserverDesignPattern.Observers
{
    public interface IProductObserverSubject
    {
        public void RegisterObserver(IProductObserver productObserver);
        public void RemoveObserver(IProductObserver productObserver);
        public void NotifyObserver(Product product);
    }
}
