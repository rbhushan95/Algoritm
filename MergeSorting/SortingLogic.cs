using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    public static class SortingLogic
    {
        public static int[] MergSortingFunction(int[] inputData)
        {
            int[] data = inputData;
            int lenghtOfArray = data.Length;
            if (lenghtOfArray < 2)
            {
                return data;
            }
            int midLength = lenghtOfArray / 2;
            int[] leftArray = new int[midLength];
            int[] righhtArray = new int[lenghtOfArray - midLength];
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = data[i];
            }
            for (int i = 0; i < righhtArray.Length; i++)
            {
                righhtArray[i] = data[midLength+i];
            }
            MergSortingFunction(leftArray);
            MergSortingFunction(righhtArray);
            int[] final = Merg(leftArray, righhtArray, data);
            PrintIntegerArray(final);
            return data;
        }
        public static int[] Merg(int[] leftData, int[] rightData, int[] finalData)
        {
            int[] final = finalData;
            int leftCounter = 0;
            int rightCounter = 0;
            int mainCounter = 0;
            int maxleftlength = leftData.Length;
            int maxrightlength = rightData.Length;
            while (leftCounter < maxleftlength && rightCounter < maxrightlength)
            {
                if (leftData[leftCounter] <= rightData[rightCounter])
                {
                    final[mainCounter] = leftData[leftCounter];
                    mainCounter = mainCounter + 1;
                    leftCounter = leftCounter + 1;
                }
                else
                {
                    final[mainCounter] = rightData[rightCounter];
                    mainCounter = mainCounter + 1;
                    rightCounter = rightCounter + 1;
                }

            }
            return finalData;
        }

        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
