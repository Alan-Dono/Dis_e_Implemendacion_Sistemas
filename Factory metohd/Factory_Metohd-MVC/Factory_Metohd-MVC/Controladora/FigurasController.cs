using System.Collections.Generic;
using Factory_Metohd_MVC.Interfaces;
using Factory_Metohd_MVC.Modelo;

namespace Factory_Metohd_MVC.Controladora
{
    internal class FigurasController // clase controladora para separa la vista del modelo, es la encargada de manejar "lo que pasa"
    {
        List <IFiguras> listaFiguras = new List <IFiguras> (); /* Creamos una lista que va a contener objetos que implementen la interfaz IFigura...
         Devuelve un string con el nombre de la figura concreta que recibe como parametreo... al recibir con parametro un objeto que implementa la interfaz IFigura 
         podemos pasarle cualquier tipo de figura que nos va a devolver su nombre concreto
         Y para respeta el modelo MVC se lo pedimos a la controlador y no a la clase*/
        public string getNameFigura(IFiguras figura) 
        {
            return figura.getName();
        }

        /* Nuevamente, no le pedimos a la fabrica que cree objetos directamente, sino que lo hace la controladora. En el metodo creamos un objeto que implementa
         * la interfaz IFiguras y le asignamos el objeto concreto que devuelve la fabrica segun el string (en este caso) que recibio de la vista y lo agregamos a una lista
         que dicho otra vez... En esta lista podemos agregar CUALQIER OBJETO QUE IMPLEMENTE LA INTERFAZ IFiguras*/
        public void crearFiguras(string tipoFigura) 
        {
            IFiguras figura = FabricaDeFiguras.crearFiguras(tipoFigura);
            listaFiguras.Add(figura);
        }
        public List<IFiguras> getLista() // <-- Simplemente devuelve la lista que declaramos como atributo de la clase para ser usada en la vista por el ListBox
        {
            return listaFiguras;
        }
    }
}
