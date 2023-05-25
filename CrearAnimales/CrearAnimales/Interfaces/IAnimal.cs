using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Model
{
    internal interface IAnimal
    {
        void eat(IFood food);
        void move();
        void sleep();
    }
}
