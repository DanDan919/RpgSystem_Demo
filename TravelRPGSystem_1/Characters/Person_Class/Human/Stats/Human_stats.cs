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
        public class Human_Stats : Person_entities
        {
            public Human_Stats(string name) : base(120, 80, 110, 60, 80,name) // (HP, Stamina, Endurance, Intelligence, Speed)
            {
            }
        }
 }
