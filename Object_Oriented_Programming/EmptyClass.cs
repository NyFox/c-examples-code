using System;

namespace Object_Oriented_Programming 
{
	public class EmptyClass
	{
		private int Age;
		private string name;
		private static int Count = 0;
		private string symbol;
		private static int Happy_New_Year = 2014;
		private static int happy = 0;
		private string Happy_New_Year_Says;

		public EmptyClass ()
		{

			this.Age = 20;
			this.symbol = " =>";
			this.name = " John";
			Count++;

			Console.WriteLine (Age + symbol + name);

			this.Happy_New_Year_Says = "Happy new year: ";
			Console.WriteLine (Happy_New_Year_Says);
		
		}

		public int ObjectCount()
		{
			 
			return Count;


		}


		public static int Happy()
		{
			Happy_New_Year++;
			string Happy_word = "Happy new year: " + Happy_New_Year;

			Console.WriteLine (Happy_word);

			return happy;
		    
		}

	}
}

