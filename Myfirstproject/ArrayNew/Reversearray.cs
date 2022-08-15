using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Reversearray
    {
		public static void Main(string[] args)
		{
			int i, j, temp;
			int[] arr = new int[6];

			Console.Write("Enter  numbers:");

			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			j = 6 - 1;
			for (i = 0; i < j; i++)
			{
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				j--;
			}

			Console.Write("After Reverse Array Elements");
			for (i = 0; i < 5; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
