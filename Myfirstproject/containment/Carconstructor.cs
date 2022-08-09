using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.containment
{
    class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void showEngine()
        {
            Console.WriteLine();
        }
       
    }
    class Carconstructor
    {
        int model_no;
        string cname;
        int price;
        Engine en;

        Carconstructor(int model_no,string cname,int price,Engine en)
        {
            this.model_no = model_no;
            this.cname = cname;
            this.price = price;
        }
        void showCarconstructor()
        {
            Console.WriteLine(model_no+"  "+cname+"  "+price);
            en.showEngine();
        }
        static void Main(string[] args)
        {
            Engine a = new Engine("Petrol");
            Carconstructor d;
           // d = new Carconstructor(6985, "BMW", 450000);
            
            
           

        }
    }
}
