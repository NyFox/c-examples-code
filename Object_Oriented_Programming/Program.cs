using System;
using System.IO;

namespace Object_Oriented_Programming
{
	class Program
	{

		static public void DoWork()
		{
			//ProgramName name = new ProgramName ();
			//name.Logic ();

			ArrayClass massiv = new ArrayClass ();
			massiv.myMethod ();
		}
	
		public static void Main (string[] args)
		{
			//EmptyClass.ObjectCount ();

			/*
			EmptyClass emp = new EmptyClass ();
			emp.ObjectCount ();

			EmptyClass.Happy ();
            */

			//Input input = new Input ();

			//input.logic ();

			//ArrayClass array = new ArrayClass ();



			try{

				DoWork();

			}
			catch(Exception ex)
			{
				Console.WriteLine (ex.Message);
			}

		}
	}
}
