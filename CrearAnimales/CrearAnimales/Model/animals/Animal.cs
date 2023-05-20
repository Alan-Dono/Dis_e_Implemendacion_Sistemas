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
        private int _id { get; }
        protected string _especie { get; set; }
        protected double _energy { get; set; } = 100.00;
        protected int[] _position { get; set; } = { 0, 0 };
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
    }
}
