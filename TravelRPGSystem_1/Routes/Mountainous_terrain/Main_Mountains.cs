using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Mountains : Main_Biome
    {
        public Main_Mountains(Person_entities character) : base(character)
        {
            Name = "Горы";
        }

        public override void ApplyDebuff()
        {
            // Реализация дебаффов
        }

        public override void TriggerEvent()
        {
            // Реализация событий
        }
    }
}
