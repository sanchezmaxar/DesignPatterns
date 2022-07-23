using System.Collections.Generic;
using FactoryMethodLib.Enums;

namespace FactoryMethodLib.Interfaces
{
    public interface IPizza{
        IEnumerable<IngredientsEnum> Ingredients{get;}
        Task Cook();

    }
}