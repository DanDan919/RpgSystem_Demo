using System;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Events.Event_algorithm
{
    internal class Random_Alg
    {
        private Random rand;
        private int[] eventsArray;
        private int targetEvent;

        public delegate void EventTriggeredHandler();
        public event EventTriggeredHandler OnEventTriggered;

        public Random_Alg()
        {
            rand = new Random();
            eventsArray = new int[100];
            targetEvent = rand.Next(1, 301);
            GenerateRandomEvents();
        }

        private void GenerateRandomEvents()
        {
            for (int i = 0; i < eventsArray.Length; i++)
            {
                eventsArray[i] = rand.Next(1, 301);
            }
        }

        public void SortAndSearchEvents(Main_Biome biome)
        {
            int sortChoice = rand.Next(1, 4);
            switch (sortChoice)
            {
                case 1:
                    Console.WriteLine("Боги решают вашу судьбу - пузырьковой сортировкой...");
                    BubbleSort();
                    break;
                case 2:
                    Console.WriteLine("Боги решают вашу судьбу - быстрой сортировкой...");
                    QuickSort(0, eventsArray.Length - 1);
                    break;
                case 3:
                    Console.WriteLine("Боги решают вашу судьбу - сортировкой вставками...");
                    InsertionSort();
                    break;
            }

            int searchChoice = rand.Next(1, 3);
            bool found = searchChoice == 1 ? LinearSearch(targetEvent) : BinarySearch(targetEvent);

            if (found)
            {
                Console.WriteLine("Событие сработало! Выбираем случайное препятствие...");
                biome.ApplyRandomObstacle(); // Применяем случайное препятствие в текущем биоме
                OnEventTriggered?.Invoke();
            }
            else
            {
                Console.WriteLine("Боги решили вас не наказывать");
            }
        }

        private void BubbleSort()
        {
            int n = eventsArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (eventsArray[j] > eventsArray[j + 1])
                    {
                        int temp = eventsArray[j];
                        eventsArray[j] = eventsArray[j + 1];
                        eventsArray[j + 1] = temp;
                    }
                }
            }
        }

        private void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(low, high);
                QuickSort(low, pi - 1);
                QuickSort(pi + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            int pivot = eventsArray[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (eventsArray[j] < pivot)
                {
                    i++;
                    (eventsArray[i], eventsArray[j]) = (eventsArray[j], eventsArray[i]);
                }
            }
            (eventsArray[i + 1], eventsArray[high]) = (eventsArray[high], eventsArray[i + 1]);
            return i + 1;
        }

        private void InsertionSort()
        {
            int n = eventsArray.Length;
            for (int i = 1; i < n; i++)
            {
                int key = eventsArray[i];
                int j = i - 1;
                while (j >= 0 && eventsArray[j] > key)
                {
                    eventsArray[j + 1] = eventsArray[j];
                    j--;
                }
                eventsArray[j + 1] = key;
            }
        }

        private bool LinearSearch(int target)
        {
            foreach (var num in eventsArray)
            {
                if (num == target)
                {
                    return true;
                }
            }
            return false;
        }

        private bool BinarySearch(int target)
        {
            int left = 0, right = eventsArray.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (eventsArray[mid] == target) return true;
                if (eventsArray[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return false;
        }
    }
}
