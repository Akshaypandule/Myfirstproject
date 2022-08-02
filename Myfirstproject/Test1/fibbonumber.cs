using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class fibbonumber
    {
        static void Main(string[] args)
        {
            int i,f1 = 0, f2 = 1,f3 = 0;
            for(i=0;i<=20;i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine();
            
            
        }
    }
}
