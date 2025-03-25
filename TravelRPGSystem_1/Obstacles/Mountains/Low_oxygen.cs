using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Mountains
{
    public class Low_oxygen
    {
        private Person_entities _character;

        public Low_oxygen(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Разреженный воздух мешает дышать, ваше тело ослабевает.");
            _character.Stamina -= 25;     // Тратится больше энергии
            _character.Endurance -= 10;   // Снижается общая выносливость
            _character.Intelligence -= 5; // Головокружение влияет на мышление

            Console.WriteLine($"⚠ Стамина: {_character.Stamina}, Выносливость: {_character.Endurance}, Интеллект: {_character.Intelligence}");
        }
    }
}
