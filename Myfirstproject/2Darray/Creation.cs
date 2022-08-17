using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2Darray
{
    class Creation
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 5, 6 }, { 3, 5, 8 }, { 9, 5, 1 } };   // 1 Way



            int[,] arr = new int[2, 2];   //2 way...
                a[0, 0] = 3;
            a[0, 1] = 6;
            a[1, 0] = 9;
            a[1, 1] = 5;

        }
    }
}
