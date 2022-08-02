using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject
{
    class swapp
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            num1 = 56;
            num2 = 65;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + "  " + num2);
        }
    }
    class Swapping2
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, temp;
            num1 = 88;
            num2 = 65;
            num3 = 23;
            temp = num1; 
            num1 = num2;
            num2 = num3;
            num3 = temp;
            Console.WriteLine(num1+"   " +num2+ "  " +num3);
        }
    }
}
