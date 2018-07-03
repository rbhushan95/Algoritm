using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSorting
{
    public static class SortingLogic
    {
        public static int[] InsertionSort(int[] inputData)
        {
            int[] data = inputData;
            //{ 10, 5, 15, 18, 19, 42, 15, 32, 99 }
            for (int i = 0; i < data.Length - 1; i++)
            {
                int j = i;
                int key = data[i];
                while (j > 0 && data[j - 1] > key)
                {
                    data[j] = data[j - 1];
                    j = j - 1;
                }
                data[j] = key;
            }
            PrintIntegerArray(data);
            return data;
        }

        //bubble sorting
        static int[] BubbleSorting(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }

        //insert sorting 
        public static void insertsort(int[] data, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
            PrintIntegerArray(data);
        }
    }
}
