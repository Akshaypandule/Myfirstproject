using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject
{
    class github
    {
		public abstract class A
		{
			public abstract void msg();
		}

		public class B : A
		{
			public override void msg()
			{
				Console.WriteLine("msg is implemented here");
			}

			public static void Main(string[] args)
			{
				A t1 = new B();
				t1.msg();
			}
		}
	}
}
