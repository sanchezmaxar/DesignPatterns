using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethodLib.Interfaces;
using FactoryMethodLib.Enums;
using Common;

namespace FactoryMethodLib.Implementations
{
    public class PepperoniPizza : IPizza
    {
        public IEnumerable<IngredientsEnum> Ingredients { get; }
        int TimeToCook=10;
        public PepperoniPizza()
        {
            Ingredients = new List<IngredientsEnum>{
                IngredientsEnum.Peperoni,
                IngredientsEnum.Cheese,
                IngredientsEnum.Tomato
            };
        }
        public async Task Cook()
        {
            Console.WriteLine("The best is yet to come.");
            Console.WriteLine($"Cooking Pepperoni pizza: {string.Join(",",Ingredients) }");
            await TimeUtils.Wait(TimeToCook);

        }
    }
}