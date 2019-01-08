using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDepot_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1000;
            int result = GetSumOfMultiples(value);
            Console.WriteLine("The Sum of all the Multiples of 3 or 5 below {0} is {1}", value, result);
            Console.Read();
        }
        static int GetSumOfMultiples(int value)
        {
            int i, j, k;
            int result = 0;
            for (i = 1; i < value; i++)
            {
                j = i % 3;
                k = i % 5;
                if (j == 0 || k == 0)
                {
                    result = result + i;
                }
            }
            return result;
        }
    }
}
