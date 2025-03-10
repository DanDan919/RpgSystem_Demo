using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Characters.Person_Class.Human_Sword.Stats
{
    internal class Human_stats:Person_entities
    {
        public Human_stats() : base(100, 100, 90, 90, 90)
        {
            
            // способность договориться с мародерами
            // повышенная скорость движения по болотам
        }
        Human_stats human = new Human_stats();
    }
}
