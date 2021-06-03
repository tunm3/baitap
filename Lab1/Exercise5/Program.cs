using System;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i, f=1, number;
            Console.WriteLine("Calculate the factorial:\n");
            Console.WriteLine("----------");

            Console.WriteLine("Please input number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            { 
                f = f * i;
            }

            Console.WriteLine("Factorial of "+ number+ "\nis:" + f);

        }
    }
}