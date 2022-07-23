using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public class ChickenBurger : Burger, IBurger
    {
        private async Task AddChiken()
        {
            await TimeUtils.Wait(3, "Adding Chicken meat to Burger: {0} seconds\r");
        }
        public override async Task Cook()
        {
            await AddChiken();
            await AddBread();
            await CookInGrill();
        }
    }
}