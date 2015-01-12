using System;
using System.IO;

namespace Object_Oriented_Programming
{
	public class ArrayClass 
	{
		public int[] Array = new int[1000];
		public static int cout = 0;
		public static int[] element = new int[100];

		public ArrayClass ()
		{
			this.Array [1] = 100;
			this.Array [27] = 1995;
			cout++;
			//Console.WriteLine (Array[1]);
		}

		public int ObjectCout()
		{
			Console.WriteLine (Array[27]);

			return cout;
		}

		public int[] myArray()
		{
			int[] arr = new int[6];
			arr [1] = 1;
			arr [2] = 2;
			arr [3] = 3;
			arr [4] = 4;
			arr [5] = 5;
			arr [6] = 6;
			return myArray ();
		}

		public  void myMethod()
		{
			element [10] = 10;
			element [20] = 20;
			element [30] = 30;
			element [40] = 40;
			element [0] = 100;
			       
			Console.WriteLine (element[0]);
		}
	}
}

