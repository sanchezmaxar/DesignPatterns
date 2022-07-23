using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public class SingleMeatBurger : Burger, IBurger
    {
        private async Task AddMeat()
        {
            await TimeUtils.Wait(3, "Adding Burger meat to Burger: {0} seconds\r");
        }
        public override async Task Cook()
        {
            await AddMeat();
            await AddBread();
            await CookInGrill();
        }
    }
}