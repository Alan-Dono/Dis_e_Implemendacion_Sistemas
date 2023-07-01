
using EntitiesLayer.ConcretClass.atmosphere.Terrains;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.atmosphere
{
    public class Mountain : IEnviroment
    {
        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }
        public bool CanInhabit(ITerrains terrain)
        {
            return terrain is Air || terrain is Land;
        }

        public IEnviroment getType()
        {
            return this;
        }
        public override string ToString()
        {
            return "Montaña";
        }
    }
}
