using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test_4
{  //Write a program to find Minimum frequency char from an Array
    class minfrequency
    {
        public static char minimumfrequency(char[]a)
        {
            char min = a[0];
            int freq = 1;
            for (int i=0;i<a.Length;i++)
            {
                if (a[i]<min)
                {
                    min = a[i];
                    freq = 1;   
                }
                else if(a[i]==min)
                {
                    freq++;
                }
            }
            return min;

        }

    }
}
