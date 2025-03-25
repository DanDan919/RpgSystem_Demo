using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Obstacles.Plain
{
    public class Raiders_Castle_Choice
    {
        private Person_entities _character;
        private Random _random;

        public Raiders_Castle_Choice(Person_entities character)
        {
            _character = character;
            _random = new Random();
        }

        public void TriggerEvent()
        {
            Console.WriteLine("⚠ Вы видите крепость рейдеров. Зайти внутрь? (y/n)");

            string choice = Console.ReadLine()?.ToLower();
            if (choice == "y")
            {
                // 🧠 Учитываем интеллект персонажа
                int intelligenceFactor = _character.Intelligence;
                int successChance = 50 + intelligenceFactor * 2; // Базовый шанс 50% + бонус от интеллекта
                if (successChance > 90) successChance = 90; // Ограничение на 90%

                int roll = _random.Next(100); // Генерируем число от 0 до 99

                if (roll < successChance)
                {
                    Console.WriteLine("🍻 Рейдеры приняли вас за своего! Вы пьете с ними и отдыхаете.");
                    _character.Health += 50;
                    _character.Stamina += 50;
                    _character.Endurance += 30;
                    _character.Intelligence += 5; // Чуть поднимаем интеллект за опыт общения
                    _character.Speed += 5;
                }
                else
                {
                    Console.WriteLine("⚔️ Вас заметили рейдеры! Они грабят вас и избивают!");
                    _character.Health -= 40;
                    _character.Stamina -= 20;
                    _character.Speed -= 2;
                }
            }
            else
            {
                Console.WriteLine("🚶‍♂️ Вы решили пройти мимо крепости.");
            }

            Console.WriteLine($"⚖️ Ваше текущее состояние: Здоровье: {_character.Health}, Стамина: {_character.Stamina}, Выносливость: {_character.Endurance}, Интеллект: {_character.Intelligence}, Скорость: {_character.Speed}");
        }
    }
}