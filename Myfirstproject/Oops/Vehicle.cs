using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Vehicle
    {
        public int model_num;
        public string type;
        public int wheel;

        public void AcceptDatails( int emodel,string etype,int ewheel)
        {
            model_num = emodel;
            type = etype;
            wheel = ewheel;
        }
        public void Average()
        {
            if(wheel==4)
            {
                Console.WriteLine("Average is 17");
            }
            else if (wheel==2)
            {
                Console.WriteLine("Average is 55");
            }
            else if (wheel==8)
            {
                Console.WriteLine("Average is 8");
            }
           
        }
        public void Display()
        {
            Console.WriteLine(model_num + " " + type+" " + wheel);
        }
        static void Main(string[]args)
        {
            Vehicle e = new Vehicle();
            Vehicle e1 = new Vehicle();
            Vehicle e2 = new Vehicle();
            e.AcceptDatails(725, "I20", 4);
            e.Average();
            e1.AcceptDatails(555, "KTM", 2);
            e1.Average();
            e2.AcceptDatails(2000, "Ashok leyland", 8);
            e2.Average();
            e.Display();
            e1.Display();
            e2.Display();
        }

    }
}
