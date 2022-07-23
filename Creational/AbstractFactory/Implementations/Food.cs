using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public abstract class Food : IFood
    {
        public abstract Task Cook();

        public async Task Serve()
        {
            await TimeUtils.Wait(3,"Serving your favorite food ... {0} seconds\r");
        }
    }
}