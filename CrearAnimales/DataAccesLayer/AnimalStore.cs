using EntitiesLayer.ConcretClass;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.atmosphere;
using System.Collections.Generic;

namespace DataAccesLayer
{
    public class AnimalStore
    {
        //private List<Animal> animals = new List<Animal>();
        private List<Animal> animals = new List<Animal> // Harcodeada para pruebas
        {
            new Animal("Leon", 12, 120, new Carnivoro(), new Sheet()),
            new Animal("Tigre", 8, 180, new Carnivoro(), new Sheet()),
            new Animal("Lobo", 6, 90, new Carnivoro(), new Sheet()),
            new Animal("Oso", 10, 250, new Omnivoro(), new Sheet()),
            new Animal("Elefante", 20, 4000, new Herbivoro(), new Forest()),
            new Animal("Gorila", 15, 300, new Herbivoro(), new Forest()),
            new Animal("Jirafa", 7, 800, new Herbivoro(), new Forest()),
            new Animal("Leopardo", 9, 70, new Carnivoro(), new Sheet()),
            new Animal("Cebra", 5, 400, new Herbivoro(), new Sheet()),
            new Animal("Hipopotamo", 15, 2000, new Herbivoro(), new Sheet()),
            new Animal("Cocodrilo", 30, 500, new Carnivoro(), new Sheet()),
            new Animal("Rinoceronte", 18, 1800, new Herbivoro(), new Sheet()),
            new Animal("Panda", 10, 150, new Herbivoro(), new Sheet()),
            new Animal("Kangaroo", 4, 50, new Herbivoro(), new Sheet()),
            new Animal("Guepardo", 6, 60, new Carnivoro(), new Sheet()),
            new Animal("Halcon", 3, 10, new Carnivoro(), new Sheet()),
            new Animal("Camello", 14, 600, new Herbivoro(), new Sheet()),
            new Animal("Delfin", 5, 200, new Carnivoro(), new Ocean()),
            new Animal("Aguila", 4, 5, new Carnivoro(), new Mountain()),
            new Animal("Caiman", 8, 150, new Carnivoro(), new Forest())
        };
        private static AnimalStore instance;

        private AnimalStore() { }

        public static AnimalStore GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalStore();
            }
            return instance;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public List<Animal> GetAllAnimals()
        {
            // Retornar una copia de la lista para evitar modificaciones externas
            return animals;
        }

        public Animal AlterAnimal(Animal animal)
        {
            // Realizar las operaciones necesarias para alterar el animal
            if (animals.Contains(animal))
            {
                int index = animals.IndexOf(animal); // Obtener el índice del animal en la lista
                animals[index] = animal; // Reemplazar el objeto existente con el objeto modificado
            }
            return animal;
        }


        public void DeleteAnimal(Animal animal)
        {
            if (animals.Contains(animal))
            {
                animals.Remove(animal);
            }
        }
    }
}
