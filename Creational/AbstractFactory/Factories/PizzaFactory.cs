using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Enums;
using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class PizzaFactory
    {
        public IPizza? GetPizza(PizzasEnum pizzasEnum){
            return pizzasEnum switch{
                PizzasEnum.Hawaiian => new HawaiianPizza(),
                PizzasEnum.Pepperoni => new PepperoniPizza(),
                _=> null
            };
        }
    }
}