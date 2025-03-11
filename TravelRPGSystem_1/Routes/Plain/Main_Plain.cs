using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Plain;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Plains : Main_Biome, IPlainsDebuff
    {
        public Main_Plains(Person_entities character) : base(character)
        {
            Name = "Plains";
        }

        public void ApplyPlainsDebuff(Person_entities character)
        {
            character.Stamina -= character.Stamina * 0.1; // Уменьшение стамины на 10%
            Console.WriteLine($"Жаркое солнце истощает вас. Стамина уменьшена: {character.Stamina}");
        }
    }
}

