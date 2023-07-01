using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass
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
