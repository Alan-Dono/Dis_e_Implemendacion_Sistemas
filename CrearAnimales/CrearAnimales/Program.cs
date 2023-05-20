using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.UI;
using System.Windows.Forms;
using CrearAnimales.Model;

namespace CrearAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnimalCreated());

            //TerrestrialAnimal animal = new TerrestrialAnimal("Leon", 10, 70, "Carnivoro");
           

        }
    }
}
