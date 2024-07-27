using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_20.Generics
{
    internal class BubbleSort
    {
        public static void OptimizeBubbleSort(int[] arr)
        {
            bool swap;

            for (int i = 0; i < arr.Length; i++)
            {
                swap = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[i + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                    break;
            }
        }
    }
}
