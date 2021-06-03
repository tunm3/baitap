using System;

namespace DateTimeFormat
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("d format: {0:d}", dateTime);
            Console.WriteLine("D format: {0:D}", dateTime);
            
            Console.WriteLine("t format: {0:t}", dateTime);
            Console.WriteLine("T format: {0:T}", dateTime);
            
            Console.WriteLine("f format: {0:f}", dateTime);
            Console.WriteLine("F format: {0:F}", dateTime);
            
            Console.WriteLine("g format: {0:g}", dateTime);
            Console.WriteLine("G format: {0:G}", dateTime);
            
            Console.WriteLine("m format: {0:m}", dateTime);
            Console.WriteLine("M format: {0:M}", dateTime);
            
            Console.WriteLine("r format: {0:r}", dateTime);
            Console.WriteLine("R format: {0:R}", dateTime);
            
            Console.WriteLine("s format: {0:s}", dateTime);
            Console.WriteLine("S format: {0:S}", dateTime);
            
            Console.WriteLine("u format: {0:u}", dateTime);
            Console.WriteLine("U format: {0:U}", dateTime);
            
            Console.WriteLine("y format: {0:y}", dateTime);
            Console.WriteLine("Y format: {0:Y}", dateTime);
        }
    }
}