using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IPizza: IFood
    {
        Task AddTomatoSauce();

        Task CookInOven() ;  
    }
}