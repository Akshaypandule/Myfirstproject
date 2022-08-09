using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class Nationalgameswitch                                                                                        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the country name");
           string name= Console.ReadLine();
            switch (name)
            {
                case "India": Console.WriteLine("Hockey");
                    break;
                case "china": Console.WriteLine("Table Tennis");
                    break;
                case "Bangladesh": Console.WriteLine("Kabaddi");
                    break;
                case "Unitedstates": Console.WriteLine("Baseball");
                    break;
                default: Console.WriteLine("Invalid");
                    break;



            }

           

        }
    }
}
