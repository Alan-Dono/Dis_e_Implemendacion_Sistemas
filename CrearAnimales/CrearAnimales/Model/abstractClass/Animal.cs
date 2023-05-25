using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Model
{
    public abstract class Animal
    {
        private static int _contadorId = 0;
        private int _id { get; } // ID automatico a cada animal idependientemente de que tipo sean
        protected string _especie { get; } // Solo getter porque no va a cambiar de especie
        protected int _energy { get; set; } = 100;
        protected int _positionX { get; set; } = 0;
        protected int _positionY { get; set; } = 0;
        protected int _age { get; set; }
        protected int _weigth { get; set; }

        public Animal(string especie, int age, int weigth)
        {
            _contadorId++;
            _id = _contadorId;
            _especie = especie;
            _age = age;
            _weigth = weigth;
        }
        protected void setEnergyPlus(int energy)
        {
            _energy += energy;
            if (_energy >= 100)
            {
                _energy = 100;
            }
        }
        protected void setEnergyLess(int energy)
        {
            _energy -= energy;
            if (_energy <= 0)
            {
                _energy = 0;
            }
        }

        protected void setPosition(int x , int y)
        {
            _positionX = x;
            _positionY = y;
        }
    }
}
