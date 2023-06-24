using Factory_Metohd_MVC.Interfaces;

namespace Factory_Metohd_MVC.Modelo
{
    internal class Cuadrado : IFiguras // Clase concreta que implementa la interface IFigura y su metodo getName y en este caso devuelve "Cuadrado"
    {
        public string getName() // Contrato de la interfaz
        {
            return "Cuadrado";
        }
    }
}
