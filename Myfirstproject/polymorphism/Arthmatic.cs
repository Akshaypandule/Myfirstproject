using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.polymorphism
{
    class Arthmatic
    {
        void calculate( )
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Addition" +(x+y));
        }
        void calculate(int x,int y)
        {
            Console.WriteLine("Substraction" +(x-y));
        }
        void calculate(float x,float y)
        {
            Console.WriteLine("Multiplication"  +(x*y));
        }
        void calculate(double a,double b)
        {
            Console.WriteLine("Division" + (a/b));
        }
        static void Main(string[] args)
        {
            Arthmatic d = new Arthmatic();
            d.calculate();
            d.calculate(5, 7);
            d.calculate(3.5f,9.8f);
            d.calculate(200,10);
        }
    }
}
