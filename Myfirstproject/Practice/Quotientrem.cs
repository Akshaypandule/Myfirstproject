using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Practice
{
    class Quotientrem
    {
        static void Main(string[] args)
        {
            int x, y, r, q;
            Console.WriteLine("Enter the first num");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number");
            y = int.Parse(Console.ReadLine());

            q = x / y;
            r = x % y;
            Console.WriteLine("Quotient="  +q);
            Console.WriteLine("Remider="  +r);


        }
    }
}
