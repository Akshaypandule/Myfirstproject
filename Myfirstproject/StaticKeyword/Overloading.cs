using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StaticKeyword
{
    class Overloading
    {
        static void calculate(int a,int b)
        {
            Console.WriteLine("Addition="  +(a+b));
        }
        static void calculate(int a,int b,int c)
        {
            Console.WriteLine("Multiplication="  +(a*b*c));
        }
         void calculate(double a,double b)
        {
            Console.WriteLine("Division="  +(a/b));
        }
        static void Main(string[]args)
        {
            Overloading.calculate(6, 7);
            Overloading.calculate(3, 4, 5);
            //  Overloading.calculate(9.256, 8.25);
            Overloading O = new Overloading();
            O.calculate(2.2, 6.5);
        }
    }
}
