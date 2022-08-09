using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{      

    // Multilevel inheritance
    class Education
    {
        public string name = "education";
    }
    class Engineering:Education
    {
        public string choice = "strem";
    }
    class Branch:Engineering
    {
        public string branch = "Mechanical";

        public void show()
        {
            Console.WriteLine(name+ "  "+choice+"  "+branch);
        }
    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            Branch a = new Branch();
            a.show();
        }
    }
}
