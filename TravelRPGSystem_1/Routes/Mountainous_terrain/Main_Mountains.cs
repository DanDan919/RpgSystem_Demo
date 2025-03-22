using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Mountainous_terrain;
using TravelRPGSystem_1.Routes.Main_Biome;


namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Mountains : Main_Biome, IMountainsDebuff
    {
        public Main_Mountains(Person_entities character) : base(character)
        {
            Name = "Mountains"; 
        }

        public void ApplyMountainsDebuff(Person_entities character)
        {
            character.Speed -= (int)(character.Speed * 0.12); // Уменьшение скорости на 12%
            character.Health -= (int)(character.Health * 0.15);// уменьшение здоровья на 15%
            character.Stamina -= (int)(character.Stamina * 0.2); // Стамина падает из-за страха
            Console.WriteLine($"Горный холод пробирает вас. Выносливость: {Character.Endurance}, Скорость: {character.Speed}");
        }
       
    }
}
