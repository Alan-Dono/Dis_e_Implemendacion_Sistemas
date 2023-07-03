using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using CrearAnimales.EntitiesLayer.Interfaces;


namespace CrearAnimales.EntitiesLayer.ConcretClass.DietTypes
{
    public class Omnivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal o animal 
        {
            return food is Vegetable || food is Animal;
        }

        public override string ToString()
        {
            return "Omnivoro";
        }
    }
}
