using System;

namespace Object_Oriented_Programming
{
	public class ProgramName
	{
		private static string name;

		public ProgramName ()
		{
		}

		public static void YourName()
		{
			Console.WriteLine ("What's your name?");
			name = Console.ReadLine ();
			Console.WriteLine ("Your name: " + name);

		}

		public bool Logic()
		{
			if(name == "John")
			{
				Console.WriteLine (true);
			}
			else
			{
				Console.WriteLine (false);
			}

			return Logic ();
		}
	}
}

