using System;
using Factory_Metohd_MVC.Interfaces;

namespace Factory_Metohd_MVC.Modelo
{
    /*Es una clase estatica que no queremos instanciar en ningun momento y a la que le asignamos la tarde de creacion de objetos de tipo IFigure
    es decir, cualquier objeto que implemente la interfaz IFigure puede ser creado en esta clase.*/
    internal static class FabricaDeFiguras 
    {
        private static IFiguras _figura = null; // Esto lo declaro asi para hacer un solo return y no tener que estar haciendo return en cada case
        // al final es mas facil encontrar el error en un return que ne muchos...

        /* Recibe un string desde la controladora para determinar que tipo de figura es para su creacion 
         Ademas esta bueno aclarar que como la clase es estatica para podrer usar sus metodos ya que no la vamos a poder instanciar, sus metodos deben ser ESTATICOS 
        
         La ventaja de que esta clase se encarge de la creacion de objetos es que si el dia de mañana tenemos 200 figuras mas, solamente agregamos la logica aca,
        creamos las clases concretas y NO tenemos que modificar nuestro codigo que va a seguir funcionando normalmente */
        public static IFiguras crearFiguras(string tipoFigura) 
        {
            switch (tipoFigura)
            {
                case "Circulo":
                    _figura = new Circulo();
                    break;
                case "Cuadrado":
                    _figura = new Cuadrado();
                    break;
                case "Triangulo":
                    _figura = new Triangulo();
                    break;
                default:
                    throw new ArgumentException("Tipo de figura inválido");
            }
            return _figura; // Finalmente se devuelve la instancia de la figura correspondiente a la controladora
        }
    }
}
