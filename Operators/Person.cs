using System;

namespace Operators
{
	internal class Person
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person()
		{
			Console.WriteLine("Person->Person()");
		}

		public Person(string name, int age)
		{
			Console.WriteLine("Person->Person(string name, int age)");
			Name = name;
			Age = age;
		}

		#region Override
		public override string ToString()
		{
			return string.Format("Name: {0}, Age: {1}", Name, Age);
		}
		#endregion

		#region Operators
		// operator de conversie explicita la int
		public static explicit operator int(Person p)
		{
			return p.Age;
		}

		public static bool operator <(Person p1, Person p2)
		{
			return p1.Age < p2.Age;
		}

		public static bool operator >(Person p1, Person p2)
		{
			return p1.Age > p2.Age;
		}
		#endregion
	}
}
