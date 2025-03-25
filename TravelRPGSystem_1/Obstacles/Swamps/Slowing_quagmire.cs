using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Swamps
{
    public class Slowing_quagmire
    {
        private Person_entities _character;

        public Slowing_quagmire(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Ваши ноги вязнут в трясине! Двигаться становится тяжелее.");
            _character.Stamina -= 10;   // Потеря стамины
            _character.Speed -= 3;      // Уменьшение скорости

            Console.WriteLine($"⚠ Текущее состояние: Стамина: {_character.Stamina}, Скорость: {_character.Speed}");
        }
    }
}