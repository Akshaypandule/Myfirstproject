using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BaseKeyword
{  // base and this combination.

    class Chemical
    {
        string property = "Highly flemmable";
        public virtual void Characteristics(string property)
        {
            Console.WriteLine("Property=" + this.property);
        }
    }
    class MIPA : Chemical      //MonoIsopropyl amine..
    {
        string property;
        public override void Characteristics(string property)
        {
            base.Characteristics(property);
            this.property = property;
            Console.WriteLine("Property=" + this.property);

        }

    }
    class BaseAndThis
    {
        static void Main(string[] args)
        {
            MIPA a = new MIPA();
          //  a.Characteristics()
     
        }

    }
}   
