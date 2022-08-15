using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Practice
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y");
            y= int.Parse(Console.ReadLine());


            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("swapp X="  +x);
            Console.WriteLine("Swapp y="  +y);


        }
    }
}
