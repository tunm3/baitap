using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Calendar");
            Console.WriteLine("--------");

            Console.WriteLine("Input day :");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday\n");
                    break;
                case 2:
                    Console.WriteLine("Tuesday\n");
                    break;
                case 3:
                    Console.WriteLine("WednesDay\n");
                    break;
                case 4:
                    Console.WriteLine("Thursday\n");
                    break;
                case 5:
                    Console.WriteLine("Friday\n");
                    break;
                case 6:
                    Console.WriteLine("Saturday\n");
                    break;
                case 7:
                    Console.WriteLine("Sunday\n");
                    break;
                default:
                    Console.WriteLine("Day invalid, please try again! \n");
                    break;
            }
        }
    }
}