using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;
using CrearAnimales.Model.foodType;

namespace CrearAnimales.Model.dietTypes
{
    internal class Carnivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es Animal 
        {
            return food is AnimalFood;
        }

        public override string ToString()
        {
            return "Carnivoro";
        }
    }
}
