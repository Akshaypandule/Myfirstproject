using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int i;
            int k;

            for(i=1;i<=4;i++)
            {
                int j = 1;
                for (k = 1; k <= 7; k++)
                {
                    if (k >= 5 - i && k <= 3 + i)
                    {
                        Console.Write(j);
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                 Console.WriteLine();
            }


        }

    }
}
