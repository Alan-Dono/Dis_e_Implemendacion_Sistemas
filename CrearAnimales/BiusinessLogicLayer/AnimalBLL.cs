using System.Collections.Generic;
using DataAccesLayer;
using EntitiesLayer.ConcretClass;
using EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace BusinessLogicLayer
{
    public static class AnimalBLL
    {

        private static AnimalStore _almacen; // Campo privado para almacenar la instancia de AnimalStore

        private static AnimalStore Almacen
        {
            get { return _almacen; } // Propiedad pública para acceder al campo _almacen
            set { _almacen = value; }
        }

        private static void SetAnimalStoreInstance()
        {
            if (Almacen == null) // Verifica si la instancia de AnimalStore no ha sido asignada previamente
            {
                AnimalStore animalStore = AnimalStore.GetInstance(); // Obtiene la instancia de AnimalStore
                Almacen = animalStore; // Asigna la instancia a la propiedad Almacen
            }
        }

        #region CRUD_Animales
        public static void AddAnimal(Animal animal)
        {
            SetAnimalStoreInstance();
            Almacen.AddAnimal(animal);
        }

        public static List<Animal> GetAllAnimals()
        {
            SetAnimalStoreInstance();
            return Almacen.GetAllAnimals();
        }

        public static Animal AlterAnimal(Animal animal)
        {
            SetAnimalStoreInstance();
            // Realizar las operaciones de modificación necesarias
            return Almacen.AlterAnimal(animal);
        }

        public static void DeleteAnimal(Animal animal)
        {
            SetAnimalStoreInstance();
            Almacen.DeleteAnimal(animal);
        }
        #endregion

     /*   #region SkillAnimals
        public static void MoveAnimal(Animal animal)
        {
            *//*animal.setPositionX(NumberRandomGenerate.GenerateRandomNumber(0, 1000));
            animal.setPositionY(NumberRandomGenerate.GenerateRandomNumber(0, 1000));   *//*
        }

        public static void FeedAnimal(IFood food)
        {

        }

        #endregion*/

       
    }
}

