using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class Alphapattern
    {
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j=i;j>='A';j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
