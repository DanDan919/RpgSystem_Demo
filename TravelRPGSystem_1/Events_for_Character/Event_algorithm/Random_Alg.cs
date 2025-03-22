using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void SortAndSearchEvents()
        {
            int sortChoice = rand.Next(1, 4);
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

            int searchChoice = rand.Next(1, 3);
            bool found = searchChoice == 1 ? LinearSearch(targetEvent) : BinarySearch(targetEvent);

            if (found)
            {
                OnEventTriggered?.Invoke();
            }
        }

        private void BubbleSort() { /* Код сортировки */ }
        private void QuickSort(int low, int high) { /* Код сортировки */ }
        private void InsertionSort() { /* Код сортировки */ }

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