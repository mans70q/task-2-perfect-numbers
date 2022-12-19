using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1n");
            int s=int.Parse(Console.ReadLine());

            Console.WriteLine("enter 1n");
            int e = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = s; x <= e; x++)
            {
                sum = 0;

                for (int i = 1; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        sum += i;
                }
                if (sum == x)
                    Console.WriteLine(x+" is a perfect number");


            }






            
        }
    }
}
