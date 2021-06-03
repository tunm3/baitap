using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Find the largest of three number:\n");
            Console.WriteLine("----------------");
            Console.WriteLine("Please enter number 1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 3:");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine("Number 1 is the greatest among three. \n");
                }
                else
                {
                    Console.WriteLine("Number 3 is the greatest among three. \n");
                }
            }
            else if (number2 > number3)
            {
                Console.WriteLine("Number 2 is the greatest among three. \n");
            }
            else
            {
                Console.WriteLine("Number 3 is the greatest among three.\n");
            }

        }
        
    }
}