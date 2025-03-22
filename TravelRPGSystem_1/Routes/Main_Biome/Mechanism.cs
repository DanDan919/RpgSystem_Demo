using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Movement_on_the_map;



namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Mechanism
    {
        private Stack<Main_Biome> biomeStack;
        private Random rng;

        public Mechanism(Person_entities character)
        {
            biomeStack = new Stack<Main_Biome>();
            rng = new Random();

            List<Main_Biome> biomeTemplates = new List<Main_Biome>
            {
                new Main_Dungeon(character),
                new Main_Plain(character),
                new Main_Swamps(character),
                new Main_Mountains(character),
                new Main_Town(character)
            };

            for (int i = 0; i < 10; i++)
            {
                int randomIndex = rng.Next(biomeTemplates.Count);
                biomeStack.Push(biomeTemplates[randomIndex]); // Добавляем случайный биом
            }
        }

        public void PrintBiomes()
        {
            Console.WriteLine("Порядок биомов:");
            foreach (var biome in biomeStack)
            {
                Console.WriteLine(biome.Name);
            }
        }
        public bool IsBiomeStackEmpty()
        {
            return biomeStack.Count == 0;
        }
        public Main_Biome PopBiome()
        {
            return biomeStack.Pop();
        }
    }
}
