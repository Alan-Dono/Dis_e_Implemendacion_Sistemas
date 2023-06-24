using Factory_Metohd_MVC.Interfaces;

namespace Factory_Metohd_MVC.Modelo
{
    internal class Triangulo : IFiguras // Clase concreta que implementa la interface IFigura y su metodo getName y en este caso devuelve "Triangulo"
    {
        public string getName() // Contrato de la interfaz
        {
            return "Triangulo";
        }
    }
}
