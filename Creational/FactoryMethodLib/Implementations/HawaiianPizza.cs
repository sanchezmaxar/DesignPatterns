using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using FactoryMethodLib.Enums;
using FactoryMethodLib.Interfaces;

namespace FactoryMethodLib.Implementations
{
    public class HawaiianPizza:IPizza
    {
        public IEnumerable<IngredientsEnum> Ingredients { get; }
        int TimeToCook=15;
        public HawaiianPizza()
        {
            Ingredients = new List<IngredientsEnum>{
                IngredientsEnum.PineApple,
                IngredientsEnum.Cheese,
                IngredientsEnum.Tomato
            };
        }
        public async Task Cook()
        {
            Console.WriteLine("The best is yet to come.");
            Console.WriteLine($"Cooking Hawaiian pizza: {string.Join(",",Ingredients) }");
            await TimeUtils.Wait(TimeToCook);

        }
    }
}