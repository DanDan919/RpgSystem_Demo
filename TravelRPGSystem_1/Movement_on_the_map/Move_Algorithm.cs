using System;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;
using TravelRPGSystem_1.Obstacles;
using TravelRPGSystem_1;
using TravelRPGSystem_1.Routes.Dungeon;

namespace TravelRPGSystem_1.Movement_on_the_map
{
    public class Move_Algorithm
    {
        private Mechanism biomeMechanism;
        private Person_entities Character;

        public Move_Algorithm(Person_entities character)
        {
            Character = character;
            biomeMechanism = new Mechanism(character); // Инициализация механизма биомов
        }

        public async Task MoveToNextBiome()
        {
            if (biomeMechanism.IsBiomeStackEmpty())
            {
                Console.WriteLine("🎉 Все локации пройдены! Путешествие завершено.");
                return;
            }

            Main_Biome currentBiome = biomeMechanism.PopBiome(); // Извлекаем следующий биом
            Console.WriteLine($"\n🌍 Персонаж входит в биом: {currentBiome.Name}");

            // 🔥 Применяем специфический дебафф
            ApplyBiomeEffects(currentBiome);

            // 🕒 Рассчитываем задержку перед выходом из биома
            int delay = CalculateTravelTime(Character);
            Console.WriteLine($"⏳ Время прохождения биома: {delay / 1000} секунд...");
            await Task.Delay(delay);

            // 📢 Триггерим случайное событие
            currentBiome.TriggerEvent();

            Console.WriteLine($"✅ Персонаж прошел биом {currentBiome.Name}!");
        }

        private void ApplyBiomeEffects(Main_Biome biome)
        {
            switch (biome)
            {
                case Main_Swamps swamps:
                    swamps.ApplySwampsDebuff(Character);
                    break;
                case Main_Dungeon dungeon:
                    dungeon.ApplyDungeonDebuff(Character);
                    break;
                // Добавляем другие биомы сюда
                default:
                    Console.WriteLine("⚠️ В этом биоме нет специальных эффектов.");
                    break;
            }
        }

        private int CalculateTravelTime(Person_entities character)
        {
            int baseTime = 5000; // 5 секунд базовое время
            int adjustedSpeed = character.Speed > 0 ? character.Speed : 1; // Защита от деления на 0
            int travelTime = baseTime / adjustedSpeed * 100; // Учитываем дебаффы
            return travelTime;
        }
    }
}