using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Enums;
using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class BurgerFactory
    {
        public IBurger? GetBurger(BurgersEnum burgerType)
        {
            return burgerType switch
            {
                BurgersEnum.Chicken => new ChickenBurger(),
                BurgersEnum.SingleMeat => new SingleMeatBurger(),
                _ => null
            };
        }
    }
}