using System;

namespace ReferenceType
{
    internal class ReferenceType
    {
        public int valueVal;
        public static void Main(string[] args)
        {
            ReferenceType referenceType = new ReferenceType();
            referenceType.valueVal = 5;
            Test(referenceType);
            Console.WriteLine("The value of the variable is {0}", referenceType.valueVal);
            Console.ReadLine();
        }
        static void Test(ReferenceType referenceType)
        {
            int temp = 5;
            referenceType.valueVal = temp * 2;
        }
    }
    
}