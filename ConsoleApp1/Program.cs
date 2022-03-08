using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                int[] arry = { 12, 13, 12, 234, 435, 35, 34, 34, 345, 6565, 25 };
                Console.WriteLine(number(arry));
                Console.ReadLine();
            }
            static int number(int[] arry)
            {
                int sum = 0;
                for (int i = 0; i < arry.Length; i++)
                {
                    sum = sum + arry[i];
                }
                return sum;
            }
        
    }
}
