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
        protected int _id; // ID automatico a cada animal idependientemente de que tipo sean
        protected string _especie; // Solo getter porque no va a cambiar de especie
        protected int _energy = 100;
        protected int _positionX = 0;
        protected int _positionY = 0;
        protected int _age;
        protected int _weight;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Animal(string especie, int age, int weigth)
        {
            _contadorId++;
            _id = _contadorId;
            _especie = especie;
            _age = age;
            _weight = weigth;
        }

        /*Por ahora otra clase no tiene este comportamiento (set/get energy) por eso se lo asigno a la clase y no a una interface ya que un alimento
         no va a aumentar o reducir su energia por lo menos por ahora... y no tengo otros factores */
        protected void setEnergyPlus(int energy) // Metodo generico para aumentar la energia de cualquier animal independientemente de como la obtenga
        {
            _energy += energy;
            if (_energy >= 100)
            {
                _energy = 100;
            }
        }
        protected void setEnergyLess(int energy) // Metodo generico para reducir la energia de cualquier animal independientemente de como la gaste
        {
            _energy -= energy;
            if (_energy <= 0)
            {
                _energy = 0;
            }
        }
        /* En cambio este metodo tal vez pueda ser de una interfaces pensando que un alimento tiene que estar en una posicion para poder ser comido si el animal
         esta situdado en su posicion... pensando que a futuro un animal puede ser comida o un alimento puede encontrarce en ciertas coordenadas. */
        protected void setPosition(int x , int y) 
        {
            _positionX = x;
            _positionY = y;
        }
    }
}
