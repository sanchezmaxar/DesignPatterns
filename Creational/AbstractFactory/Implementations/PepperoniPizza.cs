using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public class PepperoniPizza : Pizza, IPizza
    {
        private async  Task AddPepperoni(){
            
            await TimeUtils.Wait(3,"Adding Pepperoni to PP Pizza {0}\r");
        }

       
        public override async Task Cook()
        {
            await AddPepperoni();
            await AddTomatoSauce();
            await CookInOven();
        }
    }
}