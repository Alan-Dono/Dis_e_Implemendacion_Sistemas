﻿using System;
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
        public bool canEat(IFood food)
        {
            return food is VegetalesFood || food is AnimalFood;
        }

        public override string ToString()
        {
            return "Hervivoro";
        }
    }
}