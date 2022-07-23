using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IBurger:IFood
    {
        Task AddBread();
        Task CookInGrill();
        Task PackInBox();
    }
}