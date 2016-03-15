using System;

namespace ExceptionHandeling
{
	public class InvalidAgeException : Exception
	{
		Int32 Age { get; set; }

		public InvalidAgeException(Int32 age)
		{
			Age = age;
		}

		public override string Message
		{
			get
			{
				return "The age " + Age + " is invalid";
			}
		}
	}
}
