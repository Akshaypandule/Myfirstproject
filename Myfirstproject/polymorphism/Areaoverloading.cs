using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.polymorphism
{
    class Areaoverloading
    {
        public void Area(double r)
        {
            double result = (3.14 * r * r);
            Console.WriteLine("Area of Circle="  +  result);
        }
        public void Area(int length,int breath)
        {
            int result = length * breath;
            Console.WriteLine("area of reactangle="  +result);
        }
        public void Area(int side)
        {
            int result = side * side;
            Console.WriteLine("area of square="  +result);
        }
        public void Area(double basee,double hight)
        {
            double result = (basee * hight) / 2;
            Console.WriteLine("Area of triangle="   +result);
        }
        static void Main(string[] args)
        {
            Areaoverloading d = new Areaoverloading();
            d.Area(9);
            d.Area(24, 15);
            d.Area(10);
            d.Area(10, 15);
        }
    }
}
