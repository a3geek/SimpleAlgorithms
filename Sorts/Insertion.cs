using System;

namespace SimpleAlgorithm.Sorts
{
    public class Insertion
    {
        public static void Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                int idx = i;
                for (var j = i - 1; j >= 0; j--)
                {
                    if (array[idx] < array[j])
                    {
                        var temp = array[idx];
                        array[idx] = array[j];
                        array[j] = temp;
                        idx = j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
