using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class Tableloopdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;  i<=10;  i++)
            {
                Console.WriteLine(num * i);
                // Console.WriteLine(num + "*" + i + "=" + num * i);

            }

        }
    }
}
