using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops.Whileloop
{
    class Divibythree
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 30)
            {
                if (i % 3 == 0)      
                {
                    i++;
                    continue;
                }

            }
           Console.WriteLine(i);
            i++;

        }
    }
}
