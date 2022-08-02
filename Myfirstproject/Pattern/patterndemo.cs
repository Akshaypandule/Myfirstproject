using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class patterndemo
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j==2||j==4)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }Console.WriteLine();
            }
        }
    }
}
