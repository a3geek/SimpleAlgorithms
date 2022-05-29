using System;

namespace SimpleAlgorithm
{
    using Sorts;

    class Program
    {
        public static void Main(string[] argss)
        {
            Sort("Bubble Sort", array => Bubble.Sort(array));
            Sort("Selection Sort", array => Selection.Sort(array));
            Sort("Insertion Sort", array => Insertion.Sort(array));
            Sort("Merge Sort", array => Merge.Sort(array));
            // Sort("Quick Sort", array => Quick.Sort(array));
                        Sort("Quick Sort", array => Quick.Sort(array));
        }

        private static void Sort(string label, Action<int[]> sorter)
        {
            var array = GetRandomArray();

            Console.WriteLine(label);
            Display(array);
            sorter(array);
            Display(array);
            Console.WriteLine("");
        }

        private static void Display(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("");
        }

        private static int[] GetRandomArray()
        {
            var rand = new Random();
            var array = new int[7];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 50);
            }

            return array;
        }
    }
}
