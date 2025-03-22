using System;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Dungeon : Main_Biome
    {
        public Main_Dungeon(Person_entities character) : base(character)
        {
            Name = "Dungeon";
        }

        public void ApplyDungeonDebuff(Person_entities character)
        {
            character.Intelligence -= (int)(character.Intelligence * 0.1); // Интеллект падает из-за тьмы
            character.Stamina -= (int)(character.Stamina * 0.2); // Стамина падает из-за страха
            character.Health -= (int)(character.Health * 0.01); // Спёртый воздух - понижает здоровье

            Console.WriteLine($"🕷️ Мрак подземелья сбивает вас с толку. Интеллект: {character.Intelligence}, Стамина: {character.Stamina}, Здоровье: {character.Health}");
        }
    }
}