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

           
            Person_entities player = ChooseCharacterClass(playerName);

            Console.WriteLine($"🔹 {player.Name}, ваше путешествие начинается!");
            player.PrintStats();

            
            Move_Algorithm moveAlgorithm = new Move_Algorithm(player);

            
            while (player.Health > 0 && player.Stamina > 0 ) 
            {
                Console.WriteLine("\n📍 Вы путешествуете...");
                moveAlgorithm.MoveToNextBiome().Wait(); 

                
                Random_Alg randomEvent = new Random_Alg();
                randomEvent.SortAndSearchEvents(); 

               

                player.PrintStats();

                if (player.Health <= 0)
                {
                    Console.WriteLine($" {player.Name} пал в пути. Путешествие окончено.");
                    break;
                }

                if (player.Stamina <= 0)
                {
                    Console.WriteLine($" {player.Name} обессилел и не может двигаться дальше. Путешествие окончено.");
                    break;
                }

               

                Console.WriteLine(" Нажмите Enter, чтобы продолжить...");
                Console.ReadLine();
            }

            // Завершение игры
            Console.WriteLine("🏁 Игра завершена!");
        }

        static Person_entities ChooseCharacterClass(string name)
        {
            Console.WriteLine("Выберите класс персонажа:");
            Console.WriteLine("1.  Человек");
            Console.WriteLine("2.  Эльф");
            Console.WriteLine("3.  Гном");

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