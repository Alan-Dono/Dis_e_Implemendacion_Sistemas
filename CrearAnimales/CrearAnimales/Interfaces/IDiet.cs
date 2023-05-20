using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearAnimales.Interfaces
{
    internal interface IDiet
    {
        bool canEat(IFood food);
    }
}
