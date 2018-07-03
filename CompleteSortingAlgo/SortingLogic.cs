using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSortingAlgo
{
    public static class SortingLogic
    {
        public static int[] QuickSorting(int[] inputData)
        {
            int indexPosition = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                int pivot = inputData[inputData.Length - 1];

                for (int j = 1; i < inputData.Length; i++)
                {
                    if (inputData[j] < pivot)
                    {
                        int temp = inputData[j];
                        inputData[j] = inputData[indexPosition];
                        inputData[indexPosition] = temp;
                        indexPosition = indexPosition + 1;
                    }
                }
            }
            Console.WriteLine("Sorted data is :- " + SortingLogic.ArrayToString(inputData));
            return inputData;
        }

       
        #region Bubble Sorting
        public static int[] BubbleSorting(int[] inputData)
        {
            for (int i = 0; i < inputData.Length; i++)
            {
                for (int j = 1; j < inputData.Length; j++)
                {
                    if (inputData[j - 1] > inputData[j])
                    {
                        //swap the data
                        int temp = inputData[j];
                        inputData[j] = inputData[j - 1];
                        inputData[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted data is :- " + SortingLogic.ArrayToString(inputData));
            return inputData;
        }
        #endregion

        #region Insertion Sorting
        public static int[] InsertionSorting(int[] inputData)
        {
            for (int i = 0; i < inputData.Length; i++)
            {
                int j = i;
                int keydata = inputData[i];
                while (j > 0 && inputData[j - 1] > keydata)
                {
                    inputData[j] = inputData[j - 1];
                    j = j - 1;
                }
                inputData[j] = keydata;
            }
            Console.WriteLine("Sorted data is :- " + SortingLogic.ArrayToString(inputData));
            return inputData;
        }
        #endregion

        #region Quick sorting
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static void SortQuick(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }
        #endregion

        #region Printing Logic Common
        public static string ArrayToString(int[] array)
        {
            string printer = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    printer = array[0].ToString();
                }
                else
                {
                    printer = printer + ", " + array[i];
                }
            }

            return printer;
        }

        #endregion
    }
}
