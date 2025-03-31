using System;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Dungeon
{
    public class Dungeon_Bats : IObstacle
    {
        private Person_entities _character;

        public Dungeon_Bats(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("Стая летучих мышей нападает на вас!");
            _character.Health -= 10;
            _character.Stamina -= 10;
        }
    }

    public class Dungeon_Pitfall : IObstacle
    {
        private Person_entities _character;

        public Dungeon_Pitfall(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("Вы падаете в яму! Больно...");
            _character.Health -= 35;
            _character.Speed -= 5;
        }
    }

    public class Dungeon_CursedStatue : IObstacle
    {
        private Person_entities _character;

        public Dungeon_CursedStatue(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine(" Проклятая статуя накладывает заклятие... Вы чувствуете слабость.");
            _character.Intelligence -= 5;
            _character.Stamina -= 20;
        }
    }
}
