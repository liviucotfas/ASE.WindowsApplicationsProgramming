using System;

namespace Operators
{
	internal class Program
	{
		private static void Main()
		{
			var p = new Person("Name1", 21);
			var p2 = new Person("Name2", 22);

			//int age = p; //error
			int age = (int)p;
			Console.WriteLine("Age: {0}", age);

			if(p<p2)
				Console.WriteLine("p.Age < p2.Age");
		}
	}
}
