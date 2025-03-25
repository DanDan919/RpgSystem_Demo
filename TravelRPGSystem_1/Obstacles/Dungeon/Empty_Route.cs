using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles
{
    public class Empty_Route
    {
        private Person_entities _character;

        public Empty_Route(Person_entities character) 
        {
            _character = character;
        }
        public void TriggerEvent()
        {
            Console.WriteLine($" Вам повезло! {_character.Name} Вы прошли через подземелье без происшествий.");
        }
    }
}
