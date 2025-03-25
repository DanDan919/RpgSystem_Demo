using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Movement_on_the_map;

namespace TravelRPGSystem_1.Obstacles.Plain
{
    public class Attack_of_the_Big_Mosquitoes
    {
        private Person_entities _character;

        public Attack_of_the_Big_Mosquitoes(Person_entities character)
        {
            _character = character;
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Огромные комары атакуют вас, высасывая кровь!");
            _character.Health -= 10;  // Потеря крови
            _character.Stamina -= 15; // Ослабление
            _character.Intelligence -= 3;
            Console.WriteLine($"🩸 Ваше текущее здоровье: {_character.Health}, Стамина: {_character.Stamina}");
        }
    }
}
