using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class Redbluenumberbet
    {
        static void Main(string[]args)
        {
            int i;
            for(i=1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue"  + i);
                }
               else if (i % 3 == 0)
                { 
                    Console.WriteLine("Red"    + i);
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Blue" + i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }

    }
}
