using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using CrearAnimales.EntitiesLayer.Interfaces;

namespace CrearAnimales.EntitiesLayer.ConcretClass.DietTypes
{
    public class Herbivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal 
        {
            return food is Vegetable;
        }

        public override string ToString()
        {
            return "Hervivoro";
        }
    }
}
