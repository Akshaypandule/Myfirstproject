using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int i = 1;
           for(i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);  
                }
            }
        }
    }
}
