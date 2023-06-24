using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.atmosphere.Terrains;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.atmosphere
{
    internal class Mountain : IEnviroment
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
    }
}
