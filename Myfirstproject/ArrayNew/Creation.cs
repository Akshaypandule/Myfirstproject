using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Creation
    {
        static void Main(string[] args)
        {
            //int [] arr = { 20, 2, 36, 54, 45 }; // First way.


            int[] a = new int[5];             // 2nd way.
            a[0] = 9;
            a[1] = 4;
            a[2] = 5;
            a[3] = 8;
            a[4] = 10;

          //  int[] myarray = new int[6] { 1, 2, 3, 4, 5, 6 };  //3rd way..

            for (int i = 0; i < a.Length; i++)   
            {
                Console.WriteLine(a[i]+ "  "); // 1 way to display.
            }

            foreach(int x in a)
            {
                Console.WriteLine(x);         // cnd way dispaly....
            }
            Console.WriteLine(string.Join(" ",a)); //3rd way to display
        }
    }
}
