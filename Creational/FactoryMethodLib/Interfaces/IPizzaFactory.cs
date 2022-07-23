using System;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethodLib.Enums;

namespace FactoryMethodLib.Interfaces
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(PizzaEnum pizzaType);
    }
}