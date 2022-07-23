using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IFood
    {
        Task Serve();
        Task Cook();
    }
}