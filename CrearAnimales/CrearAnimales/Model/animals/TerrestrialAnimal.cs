using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Model
{
    internal class TerrestrialAnimal : Animal, IAnimal, ITerrestrial
    {
        //private IDiet diet;
        public TerrestrialAnimal(string especie, int age, int weigth, string type) : base(especie, age, weigth, type) { }
        public void eat(IFood food)
        {
            Console.WriteLine("el animal esa comiendo");
            base._energy = food.getCalories();
        }

        public void move()
        {
            Console.WriteLine("La posision del animal es: ");
        }

        public void sleep()
        {
            Console.WriteLine("El animal esta durmiendo");
        }

        public void showAnimal()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
            Console.WriteLine("El animal esta Caminando");
        }

        public void crawl()
        {
            Console.WriteLine("El animal se esta arrastrando");
        }
    }
}

