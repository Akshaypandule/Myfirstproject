using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{   // create array by using variable......  
    class Floattype
    {
        static void Main(string[] args)
        {
            float[] arr = { 0.3f, 9.66f };     //1 way array creation..


            float[] b = new float[5];         // 2 way array creation
            b[0] = 3.66f;
            b[1] = 6.33f;
            b[2] = 0.95f;
            b[3] = 5.6556f;
            b[4] = 4.5f;

            float[] k = new float[4] { 0.33f, 0.65f, 6.9877f, 1.011f };  // 3way array creation


            for(int i=0;i<arr.Length;i++)  //1 way Display..
            {
                Console.WriteLine(arr[i]);
            }
            foreach(float a in b)   //2 way display...
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(string.Join(" ",k)); //3 way display...
            
        }
        
    }
}
