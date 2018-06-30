using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "ravi vijay ravi ravi raviravi";
            string[] strar = temp.Split(' ');
            List<String> alreadyUsed = new List<String>();
            for (int i = 0; i < strar.Length ; i++)
            {
                string inter = strar[i].Trim();
                int inin = 0;

                if (!IsInArray(alreadyUsed, inter.Trim()))
                {
                    for (int j = 0; j < strar.Length; j++)
                    {
                        if (inter.Equals(strar[j].Trim()))
                        {
                            inin = inin + 1;
                        }
                    }
                    Console.WriteLine(inter + " number of times " + inin);
                }
            }
            Console.ReadLine();
        }
        public static bool IsInArray(List<string> alreadyUsed, string str)
        {
            bool isPre = false;
            if (!alreadyUsed.Exists(x => x == str.Trim()))
            {
                alreadyUsed.Add(str);
                isPre = false;
            }
            else
            {
                isPre = true;
            }
            return isPre;
        }
    }
}
