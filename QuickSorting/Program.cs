using System;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nProgram for sorting a numeric array using Quick Sorting");

            Console.Write("\n\nEnter number of elements: ");

            int max = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input int array  : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }

            Console.WriteLine("QuickSort By Recursive Method");

            QuickSort.Sort(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }

    }
}
    

