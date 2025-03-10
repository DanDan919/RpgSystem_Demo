using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;


public class Main_Swamps : Main_Biome, ISlowdownDebuff, IWeaknessDebuff, IUniqueSwampEvent
{
    public Main_Swamps(Person_entities character) : base(character)
    {
        Name = "Swamps";
    }

    public override void ApplyDebuff()
    {
        ApplySlowdown();
        ApplyWeakness();
    }

    public override void TriggerEvent()
    {
        string[] events =
        {
                "⚠ Вы слышите жуткий вой, раздающийся из глубины болот...",
                "⚠ Вода под вашими ногами начинает бурлить, словно что-то поднимается снизу.",
                "⚠ Вы находите старый деревянный идол, испещренный странными рунами."
            };

        Random rand = new Random();
        string randomEvent = events[rand.Next(events.Length)];

        Console.WriteLine($"🎲 Уникальное событие в Болотах: {randomEvent}");
    }

    public void ApplySlowdown()
    {
        Character.Speed = (int)(Character.Speed * 0.75); // -25% к скорости
        Console.WriteLine("⚠ Густая грязь замедляет ваши движения. Скорость снижена!");
    }

    public void ApplyWeakness()
    {
        Character.Health = (int)(Character.Health * 0.9); // -10% к здоровью
        Character.Endurance = (int)(Character.Endurance * 0.85); // -15% к выносливости
        Console.WriteLine("⚠ Вокруг разливается ядовитый туман. Ваше здоровье и выносливость ухудшаются.");
    }
}


