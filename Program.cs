using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }
            if (sum == number) return true;
            else return false;
        }


        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("please enter the first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number:");
            y = int.Parse(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                if (IsPerfect(i)) Console.WriteLine("{0}", i);

            }
            Console.ReadKey();





        }
    }
}  

