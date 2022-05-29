using System;

namespace SimpleAlgorithm.Sorts
{
    public class Quick
    {
        public static void Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }

            var pivot = GetPivot(array, left, right);
            int i = left, j = right;
            while (i <= j)
            {
                while (i < right && array[i] <= pivot)
                {
                    i++;
                }
                while (j > left && array[j] > pivot)
                {
                    j--;
                }

                if (i > j)
                {
                    break;
                }

                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;

                i++;
                j--;
            }

            QuickSort(array, left, i - 1);
            QuickSort(array, i, right);
        }

        private static int GetPivot(int[] array, int left, int right)
            => (array[left] + array[right]) / 2;
    }
}
