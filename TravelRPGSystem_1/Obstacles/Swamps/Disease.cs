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
    public class Disease
    {
        private Person_entities _character;

        public Disease(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Вы заболели из-за сырости и ядовитых испарений болот!");
            _character.Health -= 15;      // Потеря здоровья
            _character.Stamina -= 20;     // Ослабление
            _character.Endurance -= 10;   // Снижение выносливости
            _character.Intelligence -= 7;
            Console.WriteLine($"⚠ Текущее состояние: Здоровье: {_character.Health}, Стамина: {_character.Stamina}, Выносливость: {_character.Endurance}");
        }
    }
}