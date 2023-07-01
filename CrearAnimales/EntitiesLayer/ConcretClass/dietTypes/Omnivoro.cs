using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass
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
