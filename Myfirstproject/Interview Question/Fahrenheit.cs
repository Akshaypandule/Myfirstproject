using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{
    class Fahrenheit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fahrenheit temp");
            double temp =double.Parse(Console.ReadLine());
            double C;

            C = (temp - 32) * 5 / 9;
            Console.WriteLine(C+ " C");
        }
    }
}
