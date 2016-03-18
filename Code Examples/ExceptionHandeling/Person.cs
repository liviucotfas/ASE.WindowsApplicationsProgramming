using System;

namespace ExceptionHandling
{
	internal class Person
	{
		#region Properties

		#region Age
		int age;
		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0 || value > 150)
					throw new InvalidAgeException(value);
				age = value;
			}
		}
		#endregion

		#region Name
		private string _name;
		public string Name {
			get { return _name; }
			set
			{
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("The name cannot be empty!");
				_name = value;
			}
		}
		#endregion
		#endregion

		public Person(string name, int age)
		{
			this.age = age;
			Name = name;
		}
	}
}
