using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 5, 15, 18, 19, 42, 15, 32, 99, 100 };
            SortingLogic.MergSortingFunction(inputArray);
            Console.ReadLine();
        }
    }
}
