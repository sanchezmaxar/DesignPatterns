using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public abstract class Pizza : Food, IPizza
    {
        public async Task AddTomatoSauce()
        {
            await TimeUtils.Wait(3, "Adding tomato to hawaian Pizza {0}\r");
        }

        public override abstract Task Cook();

        public async Task CookInOven()
        {
            await TimeUtils.Wait(3, "Cooking ingredients in Oven {0}\r");
        }
    }
}