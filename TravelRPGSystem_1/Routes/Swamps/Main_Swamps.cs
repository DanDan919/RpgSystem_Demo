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
            character.Speed -= (int)(character.Speed * 0.12); 
            character.Health -= (int)(character.Health * 0.25); 
            character.Stamina -= (int)(character.Stamina * 0.2);
            Console.WriteLine($"Болото тянет вас вниз. Скорость: {character.Speed}, Здоровье: {character.Health}");
        }
    }
}



