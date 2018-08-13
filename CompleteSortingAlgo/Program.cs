using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSortingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] inputArray = { 10, 5, 15, 18, 19, 42, 15, 32, 99, 100 };
            Console.WriteLine("input data is :- " + SortingLogic.ArrayToString(inputArray));
            SortingLogic.InsertionSorting(inputArray);
            Console.ReadLine();

            
            Console.Write("by quick sort");
            int[] array = { 10, 5, 15, 18, 19, 42, 15, 32, 99, 100,-15,-1,500 };
            Console.WriteLine("input data is :- " + SortingLogic.ArrayToString(array));
            QuickSort q_Sort = new QuickSort(array);
            q_Sort.quickSort();
            Console.WriteLine("Sorted  data is :- " + SortingLogic.ArrayToString(array));
            Console.ReadLine();
        }
    }
}
