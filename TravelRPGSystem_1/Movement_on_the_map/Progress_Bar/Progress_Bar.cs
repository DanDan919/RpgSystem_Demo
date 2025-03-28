using System;
using System.Threading.Tasks;
using TravelRPGSystem_1.Movement_on_the_map;

namespace TravelRPGSystem_1.Movement_on_the_map
{
    internal class ProgressBar
    {
        public async Task ShowProgressBar(int totalTime)
        {
            int progressBarLength = 20; 
            int updateInterval = totalTime / progressBarLength; 

            Console.Write("\n Перемещение: [");
            for (int i = 0; i < progressBarLength; i++)
            {
                await Task.Delay(updateInterval); 
                Console.Write("*"); 
            }
            Console.WriteLine("] ✅");
        }
    }
}