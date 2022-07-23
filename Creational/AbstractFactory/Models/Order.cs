using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Enums;

namespace AbstractFactory.Models
{
    public class Order
    {
        public IList<BurgersEnum> Burgers{get;set;}
        public IList<PizzasEnum> Pizzas{get;set;}
        public Order()
        {
            Burgers= new List<BurgersEnum>();
            Pizzas= new List<PizzasEnum>();
        }

        public override string? ToString()
        {
            return string.Join("\n",Burgers) +"\n"+
            string.Join("\n",Pizzas);
        }
    }
}