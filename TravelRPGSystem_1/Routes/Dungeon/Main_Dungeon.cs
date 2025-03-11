using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Dungeon;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Dungeon : Main_Biome, IDungeonDebuff
    {
        public Main_Dungeon(Person_entities character) : base(character)
        {
            Name = "Dungeon";
        }

        public void ApplyDungeonDebuff(Person_entities character)
        {
            character.Intelligence -= character.Intelligence * 0.1; // Интеллект падает из-за тьмы
            character.Stamina -= character.Stamina * 0.2; // Стамина падает из-за страха
            Console.WriteLine($"Мрак подземелья сбивает вас с толку. Интеллект: {character.Intelligence}, Стамина: {character.Stamina}");
        }
    }
}