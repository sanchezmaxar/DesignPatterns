using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public abstract class Burger : Food, IBurger
    {
        public async Task AddBread()
        {
            await TimeUtils.Wait(3, "Adding Bread to the burger: {0} seconds\r");
        }

        public override abstract Task Cook();

        public async Task CookInGrill()
        {
            await TimeUtils.Wait(3, "Cooking ingredients in Grill{0}\r");
        }

        public async Task PackInBox()
        {
            await TimeUtils.Wait(3, "Packing in box ... {0} \r");
            
        }
    }
}