﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test_4
{ //program to separate zeros from non-zeros in an integer array
    class sepratezero
    {
        static void Main(string[] args)
        {
            int j = 0;
            int temp;
            int i;
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array element");
            for(i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                    j++;
                }
            }
            for(i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
               
            }
            
        }
    }
}
