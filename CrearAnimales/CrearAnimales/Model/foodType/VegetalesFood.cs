using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Model.foodType
{
    internal class VegetalesFood : IFood
    {
        private string _name;
        private int _calories;
        public VegetalesFood(int calories, string name) :base()
        {
            _name = name;
            _calories = calories;
        }
        public int getCalories()
        {
            return _calories;
        }

        public string getName()
        {
            return _name;
        }
    }
}
