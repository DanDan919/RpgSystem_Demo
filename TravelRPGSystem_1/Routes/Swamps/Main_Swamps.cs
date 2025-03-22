using System;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Swamps : Main_Biome
    {
        public Main_Swamps(Person_entities character) : base(character)
        {
            Name = "Swamps";
        }

        public void ApplySwampsDebuff(Person_entities character)
        {
            character.Speed -= (int)(character.Speed * 0.12); // Уменьшение скорости на 12%
            character.Health -= (int)(character.Health * 0.25); // Потеря 25% здоровья из-за болезней
            character.Stamina -= (int)(character.Stamina * 0.2); // Стамина падает из-за страха
            Console.WriteLine($"🏚️ Болото тянет вас вниз. Скорость: {character.Speed}, Здоровье: {character.Health}");
        }
    }
}



