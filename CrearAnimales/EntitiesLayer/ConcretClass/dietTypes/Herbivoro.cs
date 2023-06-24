using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass
{
    internal class Herbivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal 
        {
            return food is VegetalesFood;
        }

        public override string ToString()
        {
            return "Hervivoro";
        }
    }
}
