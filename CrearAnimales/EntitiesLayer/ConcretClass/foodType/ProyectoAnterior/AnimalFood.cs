using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass
{
    public class AnimalFood : IFood
    {
        private int id;
        private string _name;
        private int _calories;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Calories { get => _calories; set => _calories = value; }

        public AnimalFood(string name, int caories)
        { 
            Name = name;
            Calories = caories;
        } 

        public int getCalories()
        {
            return Calories;
        }

        public string GetName()
        {
            return Name;
        }

        IFood IFood.GetType()
        {
            return this;
        }
    }
}
