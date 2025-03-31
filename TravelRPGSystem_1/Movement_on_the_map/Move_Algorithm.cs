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
            biomeMechanism = new Mechanism(character); 
        }

        public async Task MoveToNextBiome()
        {
            if (biomeMechanism.IsBiomeStackEmpty())
            {
                Console.WriteLine(" Все локации пройдены! Путешествие завершено.");
                return;
            }

            Main_Biome currentBiome = biomeMechanism.PopBiome();
            Console.WriteLine($"\n Персонаж входит в биом: {currentBiome.Name}");

            
            ApplyBiomeEffects(currentBiome);

            
            int delay = CalculateTravelTime(Character);
            Console.WriteLine($" Время прохождения биома: {delay / 1000} секунд...");

           
            ProgressBar progressBar = new ProgressBar();
            await progressBar.ShowProgressBar(delay);

            
            
            Console.WriteLine($" Персонаж прошел биом {currentBiome.Name}!");
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
                case Main_Mountains mountains:
                    mountains.ApplyMountainsDebuff(Character);
                    break;
                case Main_Plain plain:
                    plain.ApplyPlainsDebuff(Character);
                    break;
                case Main_Town town:
                    town.TriggerEvent(); 
                    break;
                default:
                    Console.WriteLine(" В этом биоме нет специальных эффектов.");
                    break;
            }
        }

        private int CalculateTravelTime(Person_entities character)
        {
            int baseTime = 5000; 
            int adjustedSpeed = character.Speed > 0 ? character.Speed : 1; 
            int travelTime = baseTime / adjustedSpeed * 100; 
            return travelTime;
        }
    }
}