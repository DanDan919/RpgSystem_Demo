using System;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Movement_on_the_map;
using TravelRPGSystem_1.Events.Event_algorithm;

namespace TravelRPGSystem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("🌍 Добро пожаловать в RPG-симулятор путешественника!");
            Console.Write("Введите имя персонажа: ");
            string playerName = Console.ReadLine();

            // Выбор класса персонажа
            Person_entities player = ChooseCharacterClass(playerName);

            Console.WriteLine($"🔹 {player.Name}, ваше путешествие начинается!");
            player.PrintStats();

            // Создаём основной механизм путешествия
            Move_Algorithm moveAlgorithm = new Move_Algorithm(player);

            // Запуск путешествия
            while (true)
            {
                Console.WriteLine("\n📍 Вы путешествуете...");
                moveAlgorithm.MoveToNextBiome().Wait(); // Ожидание завершения асинхронного метода

                // Выпадение случайного события
                Random_Alg randomEvent = new Random_Alg();
                randomEvent.SortAndSearchEvents(); // Запускаем алгоритм событий

                player.PrintStats();

                Console.WriteLine("🔄 Нажмите Enter, чтобы продолжить...");
                Console.ReadLine();
            }

            // Завершение игры
            Console.WriteLine("🏁 Игра завершена!");
        }

        static Person_entities ChooseCharacterClass(string name)
        {
            Console.WriteLine("Выберите класс персонажа:");
            Console.WriteLine("1. 🛡️ Человек");
            Console.WriteLine("2. 🏹 Эльф");
            Console.WriteLine("3. ⛏ Гном");

            while (true)
            {
                Console.Write("Введите номер класса: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        return new Human_Stats(name);
                    case "2":
                        return new Elf_Stats(name);
                    case "3":
                        return new Dwarf_Stats(name);
                    default:
                        Console.WriteLine("❌ Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}