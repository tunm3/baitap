﻿using System;

namespace Example1
{
    internal class DataTypes
    {
        public static void Main(string[] args)
        {
            int intVal; 
            double dbVal;
            string strVal; 
            intVal = 10; 
            dbVal = 3.142; 
            strVal = "FPT Aptech"; 
            Console.WriteLine("{0} is an integer value", intVal); 
            Console.WriteLine("{0} is an double value", dbVal); 
            Console.WriteLine("{0} is an string value", strVal); 
            Console.ReadLine();
        }
    }
}