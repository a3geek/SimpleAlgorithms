using System;

namespace SimpleAlgorithm.Sorts
{
    public static class Selection
    {
        public static void Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var min = array[i + 1];
                var idx = i + 1;

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];
                        idx = j;
                    }
                }

                if (array[i] > min)
                {
                    var temp = array[i];
                    array[i] = array[idx];
                    array[idx] = temp;
                }
            }
        }
    }
}
