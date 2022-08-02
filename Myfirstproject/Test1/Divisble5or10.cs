using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class Divisble5or10
    {
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=100)
            {
                if(i%5==0 && i%10==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

    }
}
