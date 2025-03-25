using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;


namespace TravelRPGSystem_1.Obstacles.Mountains
{
    public class Cold
    {
        private Person_entities _character;

        public Cold(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine($"⚠ Лютый холод сковывает! Вы теряете силы.");
            _character.Health -= 15;  
            _character.Stamina -= 20; 
            _character.Speed -= 2;    
            _character.Intelligence -= 3;

            Console.WriteLine($"⚠ Текущее здоровье: {_character.Health}, Стамина: {_character.Stamina}, Скорость: {_character.Speed}");
        }
    }
}