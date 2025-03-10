using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRPGSystem_1.Events.Event_algorithm
{
    internal class Random_Algos
    {
        private Random rand;
        private int[] eventsArray;
        private int targetEvent;

        public delegate void EventFoundHandler(int foundNumber);
        public event EventFoundHandler OnEventFound;

        public Random_Algos()
        {
            rand = new Random();
            eventsArray = new int[100];
            targetEvent = rand.Next(1, 301); // Загадываем число от 1 до 300
            GenerateRandomEvents();
        }

        private void GenerateRandomEvents()
        {
            for (int i = 0; i < eventsArray.Length; i++)
            {
                eventsArray[i] = rand.Next(1, 301); // Числа от 1 до 300
            }
        }

        public void SortAndSearchEvents()
        {
            int sortChoice = rand.Next(1, 4); // 1 - BubbleSort, 2 - QuickSort, 3 - InsertionSort
            Console.WriteLine($"Выбран алгоритм сортировки: {sortChoice}");

            switch (sortChoice)
            {
                case 1:
                    BubbleSort();
                    break;
                case 2:
                    QuickSort(0, eventsArray.Length - 1);
                    break;
                case 3:
                    InsertionSort();
                    break;
            }

            int searchChoice = rand.Next(1, 3); // 1 - LinearSearch, 2 - BinarySearch
            Console.WriteLine($"Выбран алгоритм поиска: {searchChoice}");

            switch (searchChoice)
            {
                case 1:
                    LinearSearch(targetEvent);
                    break;
                case 2:
                    BinarySearch(targetEvent);
                    break;
            }
        }

        private void BubbleSort()
        {
            for (int i = 0; i < eventsArray.Length - 1; i++)
            {
                for (int j = 0; j < eventsArray.Length - i - 1; j++)
                {
                    if (eventsArray[j] > eventsArray[j + 1])
                    {
                        (eventsArray[j], eventsArray[j + 1]) = (eventsArray[j + 1], eventsArray[j]);
                    }
                }
            }
            Console.WriteLine("Массив отсортирован пузырьковой сортировкой.");
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
                if (eventsArray[j] <= pivot)
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
            for (int i = 1; i < eventsArray.Length; i++)
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
            Console.WriteLine("Массив отсортирован сортировкой вставками.");
        }

        private void LinearSearch(int target)
        {
            foreach (var num in eventsArray)
            {
                if (num == target)
                {
                    OnEventFound?.Invoke(target);
                    return;
                }
            }
            Console.WriteLine("Число не найдено.");
        }

        private void BinarySearch(int target)
        {
            int left = 0, right = eventsArray.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (eventsArray[mid] == target)
                {
                    OnEventFound?.Invoke(target);
                    return;
                }
                if (eventsArray[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            Console.WriteLine("Число не найдено.");
        }
    }
}
