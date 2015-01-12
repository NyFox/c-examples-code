using System;

namespace Object_Oriented_Programming
{
	public class Input
	{
		public  char[] str = new char[5000];
		public static char[] name = new char[1000];
		public bool realod;
		public static string converts = new string(name);

		public Input ()
		{
			this.str [1] = 'I';
			this.str [2] = 'L';
			this.str [3] = 'O';
			this.str [4] = 'V';
			this.str [5] = 'E';
			this.str [6] = 'Y';
			this.str [7] = 'O';
			this.str [8] = 'U';
			//string convertsCharToString = new string (str);
			Console.WriteLine (str);
		}

	   public string myName()
		{
			//string converts = new string (name);

			Console.WriteLine ("What's your name?");
			converts = Console.ReadLine ();

			Console.WriteLine ("Your name: " + converts);
			return converts;
		}

		public bool logic()
		{
			//string convert = new string (name);
			myName ();

			if (converts == "John") 
			{
				Console.WriteLine (true);
			} 
			else
			{
				Console.WriteLine (false);
			}

			return realod;
		}

	}

}


