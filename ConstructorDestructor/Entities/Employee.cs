using System;

namespace ConstructorDestructor.Entities
{
	internal abstract class Employee : Person
	{
		// A static point of data.
		private static double bonusRate = 1.1;
		// A static property.
		public static double BonusRate
		{
			get { return bonusRate; }
			set { bonusRate = value; }
		}

		public double Wage { get; set; }


		//Abstract method
		public abstract double CalculateBonusAbstract();

		public double CalculateBonusNormal()
		{
			Console.WriteLine("Employee - CalculateBonusNormal");
			return bonusRate * Wage;
		}

		public virtual double CalculateBonusVirtual()
		{
			Console.WriteLine("Employee - CalculateBonusVirtual");
			return bonusRate * Wage;
		}
	}
}
