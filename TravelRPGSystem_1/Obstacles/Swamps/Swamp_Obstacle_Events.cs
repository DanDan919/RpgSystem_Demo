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
    public class Swamp_Disease : IObstacle
    {
        private Person_entities _character;

        public Swamp_Disease(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("💀 Болото заражает вас болезнью! Вы теряете силы.");
            _character.Health -= 30;
            _character.Stamina -= 20;
        }
    }

    public class Swamp_Quicksand : IObstacle
    {
        private Person_entities _character;

        public Swamp_Quicksand(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("Вы проваливаетесь в зыбучие пески! Нужно срочно выбраться.");
            _character.Speed -= 5;
            _character.Stamina -= 15;
        }
    }

    public class Swamp_PoisonFog : IObstacle
    {
        private Person_entities _character;

        public Swamp_PoisonFog(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("Ядовитый туман опускается... Вы задыхаетесь!");
            _character.Health -= 25;
            _character.Intelligence -= 3;
        }
    }
}