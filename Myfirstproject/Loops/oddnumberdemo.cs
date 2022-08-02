using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class oddnumberdemo
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=20; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(+i);
                }
            }

        }
    }
}
