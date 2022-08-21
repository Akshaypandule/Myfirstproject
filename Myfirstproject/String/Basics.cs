using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.String
{
    class Basics
    {
        static void Main(string[] args)
        {
            string a = "Akshay";  // Compare == true
            string b = "Akshay";
            Console.WriteLine(a==b);
            string c = "pandule";
            Console.WriteLine(b==c); // compare falsue
            c = c.ToUpper();
            Console.WriteLine(c);    //Converted Upper case.
            string k = "ABHI";
            k = k.ToLower();       // Converted  Lower case......
            Console.WriteLine(k);
            string g = "  Chala hwa yeu dya   "; //Calculate the total length........
            Console.WriteLine(g.Length);
            string d = "My name is Akshay";
            string[] arr = d.Split();
            char[] carr = d.ToCharArray(); // Split com.....
            foreach(string l in arr)
            {
                Console.WriteLine(l);
            }
            string srr = d.Replace('a' ,'D'); // Replace..........
            Console.WriteLine(srr);
           string Ak = "Process of running";
            //Console.WriteLine(Ak.Substring(5));   //Sunstring
           // Console.WriteLine(Ak.Substring(3,7));
            Ak = Ak.Trim();
            
        }
    }
}
