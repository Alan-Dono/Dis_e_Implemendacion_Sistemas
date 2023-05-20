using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Model.foodType
{
    internal class AnimalFood : FoodMaster, IFood
    {   
        private string _name;
        private int _calories;
    
        public AnimalFood(string name, int caories) :base() 
        { 
            _name = name;
            _calories = caories;
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
