using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;

namespace TravelRPGSystem_1.Obstacles
{
    public class Empty_Route
    {
        public void TriggerEvent()
        {
            Console.WriteLine("✨ Вам повезло! Вы прошли через подземелье без происшествий.");
        }
    }
}
