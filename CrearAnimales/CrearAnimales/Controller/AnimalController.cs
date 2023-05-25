using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Model;
using CrearAnimales.Interfaces;

namespace CrearAnimales.Controller
{
    internal class AnimalController
    {
        // Singelton
        private static AnimalController instance;
        private List<IAnimal> animales = new List<IAnimal>();

        private AnimalController() { }

        public static AnimalController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimalController();
                }
                return instance;
            }
        }
    }

}
