using System;
using System.Collections.Generic;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Obstacles;


namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public abstract class Main_Biome
    {
        protected Person_entities Character;
        public string Name { get; protected set; }
        private Random _random = new Random();
        private List<IObstacle> _obstacles = new List<IObstacle>();

        protected Main_Biome(Person_entities character)
        {
            Character = character;
        }

        public void AddObstacle(IObstacle obstacle)
        {
            _obstacles.Add(obstacle);
        }

        public virtual void ApplyDebuff()
        {
            Console.WriteLine($"Дебафф в биоме {Name} применён!");
        }

        public void ApplyRandomObstacle()
        {
            if (_obstacles.Count == 0)
            {
                Console.WriteLine("Нет препятствий в этом биоме.");
                return;
            }

            int index = _random.Next(_obstacles.Count);
            _obstacles[index].ApplyEffect();
        }
    }
}

