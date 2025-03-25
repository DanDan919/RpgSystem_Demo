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
    public class Mountain_collapse
    {
        private Person_entities _character;

        public Mountain_collapse(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Обвал! Камни падают прямо на вас!");
            _character.Health -= 30; // Сильный урон по здоровью
            _character.Speed -= 3;   // Персонаж замедляется от ранений

            Console.WriteLine($"⚠️ Текущее здоровье: {_character.Health}, Скорость: {_character.Speed}");
        }
    }
}