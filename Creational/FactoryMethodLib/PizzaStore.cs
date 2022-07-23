using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using FactoryMethodLib.Enums;
using FactoryMethodLib.Implementations;
using FactoryMethodLib.Interfaces;

namespace FactoryMethodLib
{
    public class PizzaStore:IDesignPattern
    {
        const char ExitCmd = 'e';
        IPizzaFactory PizzaFactory;
        public PizzaStore()
        {
            // by injection would be better
            Console.WriteLine("Creating Pizza Store.");
            PizzaFactory= new PizzaFactory();
        }


        public async Task RunService()
        {
            var command = 'n';
            while (command != ExitCmd)
            {
                Console.WriteLine("Hi customer, What would you like to order?");
                Console.WriteLine("1.- Pepperoni pizza");
                Console.WriteLine("2.- Hawaiian pizza");
                Console.WriteLine("e.- Exit");
                Console.WriteLine("Select one: ");
                command = Console.ReadKey().KeyChar;
                var pizzaType = ParseCharToPizzaEnum(command);
                if (pizzaType == null)
                {
                    Console.WriteLine("Pizza select is not valid. Exiting...");
                    break;
                }
                var pizza=PizzaFactory.CreatePizza(pizzaType.Value);
                await pizza.Cook();
            }
        }

        public PizzaEnum? ParseCharToPizzaEnum(char c)
        {
            return c switch
            {
                '1' => PizzaEnum.Pepperoni,
                '2' => PizzaEnum.Hawaiian,
                _ => null
            };
        }
    }
}