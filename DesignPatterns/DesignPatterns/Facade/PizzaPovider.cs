using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    class PizzaPovider : IPizza
    {
        public void GetNonvegPizza()
        {
            GetNonvegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }

        public void GetNonvegToppings()
        {
            Console.WriteLine("Get Nonveg Pizza Toppings");
        }
    }
}
