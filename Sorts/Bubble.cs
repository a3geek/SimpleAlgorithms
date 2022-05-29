using System;

namespace SimpleAlgorithm.Sorts
{
    public static class Bubble
    {
        public static void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
