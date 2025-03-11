using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;



    namespace TravelRPGSystem_1.Characters.Person_Class
    {
        public class Dwarf_Stats : Person_entities
        {
            public int Damage { get; private set; }

            public Dwarf_Stats() : base(120, 80, 110, 60, 80) // Здоровье, стамина, выносливость, интеллект, ловкость
            {
                
            }
           Dwarf_Stats dwarf = new Dwarf_Stats();
        }
    }
