using System;
using System.Windows.Forms;
using EntitiesLayer.ConcretClass;
using EntitiesLayer.Interfaces;
using BusinessLogicLayer;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.atmosphere;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Helpers;

namespace CrearAnimales
{
    public class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAnimalList());
            //Application.Run(new FrmAnimalCreated());

            /*//---------------------- Pruebas de Movilidad e ejes X , Y -------------------------
            Animal animal1 = new Animal("Leon", 12, 120, new Carnivoro(), new Sheet());
            Animal animal2 = new Animal("Oso", 8, 90, new Carnivoro(), new Forest());
            Animal animal3 = new Animal("Cebra", 2, 35, new Herbivoro(), new Sheet());
            AnimalBLL.AddAnimal(animal1);
            AnimalBLL.AddAnimal(animal2);
            AnimalBLL.AddAnimal(animal3);
           *//* foreach (Animal animal in AnimalBLL.GetAllAnimals())
            {
                Console.WriteLine(animal.ToString() + "\n");
                animal.Move();
                Console.WriteLine(animal.ToString() + "\n");

            }
            Console.ReadLine();*//*
            //---------------------------------------------------------------------------------
            //--------------------------Pruebas de datos-----------------------
            Vegetable Tomate = new Vegetable("Tomate", 50);
            Vegetable Pasto = new Vegetable("Pasto", 10);
            *//*   Console.WriteLine(Tomate.GetName());
               Console.WriteLine(Tomate.ToString());
               Console.WriteLine(Tomate.GetType().Name);
               Console.WriteLine(animal1.GetName());
               Console.WriteLine(animal1.ToString());
               Console.WriteLine(animal1.GetType().Name);
               Console.ReadLine();*//*
            //--------------------------------- Pruebas Feed -------------------------------
            animal1.Feed(Tomate);
            animal1.Feed(animal1);
            //Console.ReadLine();
*/


        }
    }
}
