using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;
using TravelRPGSystem_1.Obstacles;

namespace TravelRPGSystem_1.Characters.Person_Class
{
    public class Dwarf_Stats : Person_entities
    {
        public Dwarf_Stats(string name) : base(100, 120, 80, 110, 60,name)
        {
        }
    }
}