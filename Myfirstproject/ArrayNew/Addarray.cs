using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Addarray
    {
           public void OddEven()
           {
            int[] a = { 10, 20, 6, 5, 3, 8, 9, 1, 72 };
            int E1=0;
            int O1=0;
              for(int i=0;i<a.Length;i++)
              {
               
                if(a[i]%2==0)
                {

                    E1++;
                }
                else
                {
                    O1++;
                }
              }
                int[]even1=new int [E1];
               int[] Odd = new int[O1];
               int x = 0;
               int y = 0;
               for(int i=0;i<a.Length;i++)
               {
                   if(a[i]%2==0)
                   {
                    even1[x++] = a[i];
                   }
                   else
                   {
                    Odd[y++] = a[i];
                   }
               }
            static void Main(string[] args)
            {
                for (int i = 0; i < even1.Length; 
            }
           }
        
        
    }
}
