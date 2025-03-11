using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;


public class Main_Swamps : Main_Biome, ISwampsDebuff
{
    public Main_Swamps(Person_entities character) : base(character)
    {
        Name = "Swamps";
    }

    public void ApplySwampsDebuff(Person_entities character)
    {
        character.Speed -= character.Speed * 0.2; // Уменьшение скорости на 20%
        character.Health -= character.Health * 0.05; // Потеря 5% здоровья из-за болезней
        Console.WriteLine($"Болото тянет вас вниз. Скорость: {character.Speed}, Здоровье: {character.Health}");
    }

    public void TriggerSwampEvent()
    {
        Console.WriteLine("Вы слышите зловещие звуки... Из тумана появляется нечто...");
    }
}


