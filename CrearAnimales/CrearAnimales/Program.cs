using System;
using System.Windows.Forms;
using CrearAnimales.Controller;
using CrearAnimales.Model;
using CrearAnimales.Model.dietTypes;
using CrearAnimales.Model.foodType;
using CrearAnimales.UI;

namespace CrearAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnimalCreated());
            // Pruebas piloto
            Carnivoro carnivoro = new Carnivoro();
            TerrestrialAnimal leon = new TerrestrialAnimal("Leon", 10, 80, carnivoro);
            AnimalFood vaca = new AnimalFood("Vaca", 100);
            VegetalesFood tomate = new VegetalesFood(100, "Tomate");
            // Hay algo aca que no funciona el leon puede comer tomate y vaca /*Arreglado El problemas estaba en que el metodo canEat en carnivoro siempre devolvia true  
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.eat(tomate);
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.eat(vaca);
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.move();
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.move();
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.sleep();
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.eat(tomate);
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            leon.eat(vaca);
            Console.ReadLine();
            // Pruebas de controladora
            //AnimalController cont = AnimalController.getInstance();
            //cont.showAnimalsForConsole();
            //Console.ReadLine();

            // Pruebas para la controladora


        }
    }
}
