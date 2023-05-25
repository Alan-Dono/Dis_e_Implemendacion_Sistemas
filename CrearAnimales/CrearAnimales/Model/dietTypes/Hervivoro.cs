using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;
using CrearAnimales.Model.foodType;

namespace CrearAnimales.Model.dietTypes
{
    internal class Hervivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal 
        {
            return food is VegetalesFood;
        }

        public override string ToString()
        {
            return "Hervivoro";
        }
    }
}
