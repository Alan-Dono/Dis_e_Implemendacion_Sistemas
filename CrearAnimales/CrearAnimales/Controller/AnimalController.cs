using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Model;
using CrearAnimales.Interfaces;
using System.Reflection;

namespace CrearAnimales.Controller
{
    internal class AnimalController
    {
        // Singelton
        private List<IAnimal> _animales = new List<IAnimal>();
        private static AnimalController instance;
        private AnimalController() { }
        public static AnimalController getInstance()
        {
            if (instance == null)
            {
                instance = new AnimalController();
            }
            return instance;
        }
        
        // Singelton
        public List<IAnimal> getListAnimals() // Devuelve la lista de animales creados
        {
            return _animales;
        }

        public void animalCreated(string especie, int edad, int peso, string tipoAnimal, string diet)
        {
            Type tipoAnimalClase = Assembly.GetExecutingAssembly().GetType(tipoAnimal);
            Type tipoDietClase = Assembly.GetExecutingAssembly().GetType(diet);

            if (tipoAnimalClase == null || tipoDietClase == null)
            {
                throw new ArgumentException("Tipo de animal o dieta no válidos");
            }

            IAnimal animalNuevo = (IAnimal)Activator.CreateInstance(tipoAnimalClase);
            IDiet dietaNueva = (IDiet)Activator.CreateInstance(tipoDietClase);

            // Asignar los valores de especie, edad y peso al animalNuevo
            if (animalNuevo is Animal animal)
            {
                animal.Especie = especie;
                animal.Age = edad;
                animal.Weight = peso;
                if (animal is IDiet animalConDieta)
                {
                }
            }

            // Asignar los valores de la dietaNueva si es necesario
            // ...

            // Realizar acciones adicionales con animalNuevo y dietaNueva
        }




    }

}
