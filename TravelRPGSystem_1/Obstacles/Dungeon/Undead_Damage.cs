using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;

namespace TravelRPGSystem_1.Obstacles.Dungeon
{
    public class Undead_Damage
    {
        private Person_entities _character;

        public Undead_Damage(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("💀 Из гробов восстаёт нежить! Вас атакуют!");
            _character.Health -= 20; // Уменьшаем здоровье персонажа
            _character.Stamina -= 10; // Уменьшаем стамину

            Console.WriteLine($"🩸 Ваше текущее здоровье: {_character.Health}, Стамина: {_character.Stamina}");
        }
    }
}