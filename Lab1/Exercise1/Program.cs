using System;

namespace Exercise1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Demo demo = new Demo();
            Console.WriteLine("Please enter your name:");
            demo.Name = Console.ReadLine();
            Console.WriteLine("Please enter your address:");
            demo.Address = Console.ReadLine();
            Console.WriteLine("Please enter your phone number:");
            demo.PhoneNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("My name is {0}", demo.Name);
            Console.WriteLine("My address at {0}", demo.Address);
            Console.WriteLine("My phonenumber is {0}", demo.PhoneNumber);



        }
    }
}