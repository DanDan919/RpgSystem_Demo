using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Characters.Person_Class.Elf_Archer.Stats
{
    internal class Elf_Stats:Person_entities
    {
        public double Speed_in_Plain { get; private set; }
        public Elf_Stats() : base(90, 130, 80, 110,130)
        {
           

        }
        Elf_Stats elf = new Elf_Stats();
    }
}
