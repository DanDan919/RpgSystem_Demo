using System;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Mountains
{
    public class Low_Oxygen : IObstacle
    {
        private Person_entities _character;
        public Low_Oxygen(Person_entities character) { _character = character; }

        public void ApplyEffect()
        {
            Console.WriteLine("Разреженный воздух мешает дышать, ваше тело ослабевает.");
            _character.Stamina -= 25;
            _character.Endurance -= 10;
            _character.Intelligence -= 5;
            Console.WriteLine($"Стамина: {_character.Stamina}, Выносливость: {_character.Endurance}, Интеллект: {_character.Intelligence}");
        }
    }

    public class Rockfall : IObstacle
    {
        private Person_entities _character;
        public Rockfall(Person_entities character) { _character = character; }

        public void ApplyEffect()
        {
            Console.WriteLine("Обвал! Камни падают прямо на вас!");
            _character.Health -= 30;
            _character.Speed -= 3;
            Console.WriteLine($"Текущее здоровье: {_character.Health}, Скорость: {_character.Speed}");
        }
    }

    public class Severe_Cold : IObstacle
    {
        private Person_entities _character;
        public Severe_Cold(Person_entities character) { _character = character; }

        public void ApplyEffect()
        {
            Console.WriteLine($"Лютый холод сковывает! Вы теряете силы.");
            _character.Health -= 15;
            _character.Stamina -= 20;
            _character.Speed -= 2;
            _character.Intelligence -= 3;
            Console.WriteLine($"Текущее здоровье: {_character.Health}, Стамина: {_character.Stamina}, Скорость: {_character.Speed}");
        }
    }
}