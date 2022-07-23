using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using Common;

namespace AbstractFactory.Implementations
{
    public class HawaiianPizza : Pizza, IPizza
    {
        private async Task AddPinaple(){
            await TimeUtils.Wait(3,"Adding Pinaple to hawaian Pizza {0}\r");
        }

        
        public override async Task Cook()
        {
            await AddPinaple();
            await AddTomatoSauce();
            await CookInOven();
        }
    }
}