using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class numberpatt
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1; i--)
            {
                for(int j=i;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
