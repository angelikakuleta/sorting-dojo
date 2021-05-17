using System;
using System.Collections.Generic;

namespace SortingDojo.Extensions
{
    public static class ListExtensions
    {
        // Computing complexity: O(n^2)
        // Memory complexity: 1
        public static void BubbleSort<T>(this List<T> list) where T : IComparable
        {
            int length = list.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        Swap(list, j, j + 1);
                    }
                }
            }
        }

        // Computing complexity: O(n^2)
        // Memory complexity: 1
        public static void InsertionSort<T>(this List<T> list) where T : IComparable
        {
            int length = list.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i; j >= 0 && list[j].CompareTo(list[j + 1]) > 0; j--)
                {
                    Swap(list, j, j + 1);
                }
            }
        }

        // Worst complexity: O(n^2)
        // Average complexity: O(nlog(n))
        // Memory complexity: log(n)
        public static void QuickSort<T>(this List<T> list) where T : IComparable
        {
            QuickSortHelper(list, 0, list.Count - 1);
        }

        private static void QuickSortHelper<T>(List<T> list, int from, int to) where T : IComparable
        {
            if (from < to)
            {
                bool isLeftTurn = false;
                int leftIndex = from;
                int rightIndex = to;

                while (leftIndex < rightIndex)
                {
                    if (list[leftIndex].CompareTo(list[rightIndex]) > 0)
                    {
                        Swap(list, leftIndex, rightIndex);
                        isLeftTurn = !isLeftTurn;
                    }

                    if (isLeftTurn)
                    {
                        leftIndex++;
                    }
                    else
                    {
                        rightIndex--;
                    }
                    
                }

                QuickSortHelper(list, from, leftIndex - 1);
                QuickSortHelper(list, rightIndex + 1, to);
            }
        }

        private static void Swap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
