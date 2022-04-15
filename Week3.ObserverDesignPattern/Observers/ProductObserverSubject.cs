﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.ObserverDesignPattern.Models;

namespace Week3.ObserverDesignPattern.Observers
{
    public class ProductObserverSubject : IProductObserverSubject
    {
        private readonly List<IProductObserver> _productObservers;

        public ProductObserverSubject()
        {
            _productObservers = new List<IProductObserver>();
        }

        public void RegisterObserver(IProductObserver productObserver)
        {
            _productObservers.Add(productObserver);
        }

        public void RemoveObserver(IProductObserver productObserver)
        {
            _productObservers.Remove(productObserver);
        }

        public void NotifyObserver(Product product)
        {
            _productObservers.ForEach(x =>
            {
                x.ProductCreated(product);
            });
        }
    }
}
