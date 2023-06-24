using Factory_Metohd_MVC.Interfaces;

namespace Factory_Metohd_MVC.Modelo
{
    internal class Circulo : IFiguras // Clase concreta que implementa la interface IFigura y su metodo getName y en este caso devuelve "Circulo"
    {
        public string getName() // Contrato de la interfaz
        {
            return "Circulo";
        }
    }
}
