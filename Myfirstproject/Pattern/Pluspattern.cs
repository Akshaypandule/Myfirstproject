﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class Pluspattern
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(j==3 || i==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                    Console.Write(" ");
                    }

                } Console.WriteLine();
            }
        }
    }
}
