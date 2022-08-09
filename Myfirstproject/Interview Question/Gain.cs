using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{
    class Gain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the buys RS");
            double buys =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Sells RS");
            double Sells =double.Parse(Console.ReadLine());
            double gain;
            gain = Sells - buys;
            Console.WriteLine(gain);
        }
    }
}
