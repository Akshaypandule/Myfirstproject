using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BaseKeyword
{
    class Mobile
    {
        public string RAM = "64GB";
        public void Ram()
        {
            Console.WriteLine("64GB");

        }
    }
    class Samsung:Mobile
    {
        public string ROM = "128GB";
         public void show()
        {
            Console.WriteLine("ROM="+ROM+" "+"RAM="+base.RAM );
        }
    }
    class  Realme:Mobile
    {
        public string ROM = "64GB";
        public int price = 15000;
        public void show()
        {
            Console.WriteLine("ROM="+ROM+" "+"Price="+price);
            base.Ram ();
        }
    }
    class Carbon:Mobile
    {
        public string ROM = "64 GB";
        public int price = 7000;
        public Carbon():base()
        {
            Console.WriteLine("ROM="+ROM+"   "+"Price="+price);
        }
    }
    class BaseAllType
    {
        static void Main(string[] args)
        {
            Samsung a= new Samsung();
            a.show();
            Realme b = new Realme();
            b.show();
            Carbon c = new Carbon();
        }
    }
}
