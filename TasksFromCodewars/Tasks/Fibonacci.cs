using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//not from codewars =)
namespace TasksFromCodewars.Tasks
{
    internal class Fibonacci
    {

        public static void FibonacciMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciFunc(n));
            Console.WriteLine();
            Console.ReadLine();
        }
        public static int FibonacciFunc(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return (FibonacciFunc(n - 1) + FibonacciFunc(n - 2));
            }
        }
    }
}
