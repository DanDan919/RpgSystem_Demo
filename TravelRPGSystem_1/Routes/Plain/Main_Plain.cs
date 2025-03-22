using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Plain;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Plain : Main_Biome, IPlainsDebuff
    {
        public Main_Plain(Person_entities character) : base(character)
        {
            Name = "Plains";
        }

        public void ApplyPlainsDebuff(Person_entities character)
        {
            character.Speed -= (int)(character.Speed * 0.12); // Уменьшение скорости на 12%
            character.Health -= (int)(character.Health * 0.15);// уменьшение здоровья на 15%
            character.Stamina -= (int)(character.Stamina * 0.2); // Стамина падает из-за страха
            Console.WriteLine($"Жаркое солнце истощает вас. Стамина уменьшена: {Character.Stamina}");
        }
    }
}

