using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            int[] result = solve(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
        // Complete the solve function below.
        static int[] solve(int[] a, int[] b)
        {
            int[] result = new int[2];
            int aResult = 0;
            int bResult = 0;
            if (a.Length == 3 && b.Length == 3)
            {
                aResult = ((a[0] > b[0] ? 1 : 0) + (a[1] > b[1] ? 1 : 0) + (a[2] > b[2] ? 1 : 0));
                bResult = ((a[0] < b[0] ? 1 : 0) + (a[1] < b[1] ? 1 : 0) + (a[2] < b[2] ? 1 : 0));
            }
            result[0] = aResult;
            result[1] = bResult;
            return result;
        }

    }
}

