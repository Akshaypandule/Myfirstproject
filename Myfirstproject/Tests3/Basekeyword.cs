using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class Medicine
    {
        public string C_name = "Cipla";
        public void Show()
        {
            Console.WriteLine("Cipla");
        }
    }
    class NocoldPlus:Medicine
    {
        public string Prevent = "Fever";
        public void show()
        {
            Console.WriteLine("Prevent="  +Prevent+ "C_name="+base.C_name);
        }
    }
    class Paracip_500:Medicine
    {
        public string Prevent = "Common cold";
        public void show()
        {
            Console.WriteLine("Prevent"  +Prevent);
            base.Show();
        }
    }
    class Molnupiravir:Medicine
    {
        public string Prevent = "Covid 19 ";
        public Molnupiravir():base()
        {
            Console.WriteLine("Prevent=" +Prevent);
        }
    }
    class Basekeyword
    {
        static void Main(string[] args)
        {
            NocoldPlus a = new NocoldPlus();
            a.show();
            Paracip_500 b = new Paracip_500();
            b.show();
            Molnupiravir v = new Molnupiravir();
            v.Show();

        }
    }
}
