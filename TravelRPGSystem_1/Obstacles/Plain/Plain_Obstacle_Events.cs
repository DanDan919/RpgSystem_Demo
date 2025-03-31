using System;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Plain
{
    public class Plain_Sandstorm : IObstacle
    {
        private Person_entities _character;

        public Plain_Sandstorm(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("🌪 Песчаная буря мешает двигаться!");
            _character.Speed -= 3;
            _character.Stamina -= 10;
        }
    }

    public class Plain_HungryWolves : IObstacle
    {
        private Person_entities _character;

        public Plain_HungryWolves(Person_entities character)
        {
            _character = character;
        }

        public void ApplyEffect()
        {
            Console.WriteLine("🐺 Голодные волки окружают вас!");
            _character.Health -= 25;
            _character.Speed -= 2;
        }
    }

    public class Raiders_Castle_Choice : IObstacle
    {
        private Person_entities _character;
        private Random _random;

        public Raiders_Castle_Choice(Person_entities character)
        {
            _character = character;
            _random = new Random();
        }

        public void ApplyEffect()
        {
            Console.WriteLine("Вы видите крепость рейдеров. Зайти внутрь? (y/n)");

            string choice = Console.ReadLine()?.ToLower();
            if (choice == "y")
            {
                int intelligenceFactor = _character.Intelligence;
                int successChance = 50 + intelligenceFactor * 2;
                if (successChance > 90) successChance = 90;

                int roll = _random.Next(100);

                if (roll < successChance)
                {
                    Console.WriteLine("Рейдеры приняли вас за своего! Вы отдыхаете.");
                    _character.Health += 50;
                    _character.Stamina += 50;
                    _character.Endurance += 30;
                    _character.Intelligence += 5;
                    _character.Speed += 5;
                }
                else
                {
                    Console.WriteLine("Вас грабят рейдеры!");
                    _character.Health -= 40;
                    _character.Stamina -= 20;
                    _character.Speed -= 2;
                }
            }
            else
            {
                Console.WriteLine("Вы прошли мимо.");
            }
        }
    }
}