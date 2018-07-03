using System;
namespace InsertSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 5, 15, 18, 19, 42, 15, 32, 99 };
            SortingLogic.InsertionSort(inputArray);
            Console.ReadLine();
        }
    }
}
