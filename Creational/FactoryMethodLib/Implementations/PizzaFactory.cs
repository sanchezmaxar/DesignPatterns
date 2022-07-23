using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethodLib.Interfaces;
using FactoryMethodLib.Enums;

namespace FactoryMethodLib.Implementations
{
    public class PizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(PizzaEnum pizzaType)
        {
            return pizzaType switch
            {
                PizzaEnum.Pepperoni => new PepperoniPizza(),
                PizzaEnum.Hawaiian => new HawaiianPizza(),
                _ => new PepperoniPizza()
            };
        }

    }
}