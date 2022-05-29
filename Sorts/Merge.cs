using System;

namespace SimpleAlgorithm.Sorts
{
    public class Merge
    {
        public static void Sort(int[] array)
        {
            var merge = MergeSort(array, 0, array.Length);

            for (var i = 0; i < merge.Length; i++)
            {
                array[i] = merge[i];
            }
        }

        private static int[] MergeSort(int[] array, int left, int right)
        {
            // Split.
            if (right - left < 2)
            {
                return new int[] { array[left] };
            }

            var middle = left + (right - left) / 2;
            var arrayL = MergeSort(array, left, middle);
            var arrayR = MergeSort(array, middle, right);

            // Merge Sort.
            return MergeAndSort(arrayL, arrayR);
        }

        private static int[] MergeAndSort(int[] left, int[] right)
        {
            var merge = new int[left.Length + right.Length];
            int i = 0, idxL = 0, idxR = 0;
            for (; idxL < left.Length && idxR < right.Length; i++)
            {
                if (left[idxL] < right[idxR])
                {
                    merge[i] = left[idxL++];
                }
                else
                {
                    merge[i] = right[idxR++];
                }
            }

            while (idxL < left.Length)
            {
                merge[i++] = left[idxL++];
            }

            while (idxR < right.Length)
            {
                merge[i++] = right[idxR++];
            }

            return merge;
        }
    }
}
