using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Enums;
using AbstractFactory.Models;
using Common;

namespace AbstractFactory
{
    public class FoodCooker: IDesignPattern
    {
        FoodFactory foodFactory;
        public FoodCooker()
        {
            foodFactory = new FoodFactory();
        }
        public async  Task TakeOrder()
        {
            char option = '-';
            var order = new Order();
            while (option != 'r')
            {

                Console.WriteLine("Hi customer, What would you like to order?");
                Console.WriteLine("1.- Hawaiian pizza");
                Console.WriteLine("2.- Pepperoni pizza");
                Console.WriteLine("3.- Single burger");
                Console.WriteLine("4.- Chicken burguer");
                Console.WriteLine("r.- Ready");
                Console.WriteLine("Select one: ");
                option = Console.ReadKey().KeyChar;
                var pizzaType = ParseCharToPizzaEnum(option);
                if (pizzaType.HasValue)
                {
                    order.Pizzas.Add(pizzaType.Value);
                }
                else
                {
                    var burgerType = ParseCharToBurgerEnum(option);
                    if (burgerType.HasValue)
                    {
                        order.Burgers.Add(burgerType.Value);
                    }
                }
            }
            await CookOrder(order);
        }

        private PizzasEnum? ParseCharToPizzaEnum(char option)
        {
            return option switch
            {
                '1' => PizzasEnum.Pepperoni,
                '2' => PizzasEnum.Hawaiian,
                _ => null
            };
        }

        private BurgersEnum? ParseCharToBurgerEnum(char option)
        {
            return option switch
            {
                '3' => BurgersEnum.SingleMeat,
                '4' => BurgersEnum.Chicken,
                _ => null
            };
        }

        public async Task CookOrder(Order order)
        {
            foreach (var pizzaType in order.Pizzas)
            {
                var pizza=foodFactory.GetPizza(pizzaType);
                await pizza!.Cook();
                await pizza.Serve();
            }
            foreach (var burgerType in order.Burgers)
            {
               var burger= foodFactory.GetBurger(burgerType);
                await burger!.Cook();
                await burger.PackInBox();
                await burger.Serve();
            }
        }

        public async Task RunService()
        {
            await TakeOrder();
        }
    }
}