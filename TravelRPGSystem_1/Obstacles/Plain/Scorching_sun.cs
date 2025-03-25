using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Plain
{
    public class Scorching_sun
    {
        private Person_entities _character;

        public Scorching_sun(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Палящий зной! Солнце обжигает кожу, усталость нарастает.");
            _character.Stamina -= 25;     // Потеря сил
            _character.Endurance -= 15;   // Утомление
            _character.Speed -= 2;        // Замедление
            _character.Intelligence -= 1;
            Console.WriteLine($" Текущее состояние: Стамина: {_character.Stamina}, Выносливость: {_character.Endurance}, Скорость: {_character.Speed}");
        }
    }
}