using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class SerachElement
    {
        public static bool Findelement (int[]a,int n)
        {
            bool isPresent = false;
            for (int i=0;i<a.Length;i++)
            {
                if(a[i]==n)
                {
                    isPresent = true;
                    break;
                }
                
            }
            return isPresent;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the findout Element");
            int num= int.Parse(Console.ReadLine());
            bool iselementfount = SerachElement.Findelement(a, num);
            if(iselementfount==true)
            {
                Console.WriteLine("Element is Present");
            }
            else
            {
                Console.WriteLine("Element is not Present");
            }
        }
        
            
    }
}
