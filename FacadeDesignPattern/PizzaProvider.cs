﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }
}
