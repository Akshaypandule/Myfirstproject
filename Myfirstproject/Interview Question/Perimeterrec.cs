using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{
    class Perimeterrec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            int Width = int.Parse(Console.ReadLine());

            int perimeter = 2*(lenght + Width);
            Console.WriteLine(perimeter);
        }
    }
}
