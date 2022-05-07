using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    class RestaurantFacade
    {
        private IPizza _iPizzaProvider;
        private IBread _iBreadProvider;

        public RestaurantFacade()
        {
            _iPizzaProvider = new PizzaPovider();
            _iBreadProvider = new BreadProvider();
        }

        public void GetNonVegPizza()
        {
            _iPizzaProvider.GetNonvegPizza();
        }
        public void GetVegPizza()
        {
            _iPizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _iBreadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _iBreadProvider.GetCheesyGarlicBread();
        }


    }
}
