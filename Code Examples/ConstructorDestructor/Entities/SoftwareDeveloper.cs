using System;

namespace ConstructorDestructor.Entities
{
	internal class SoftwareDeveloper : Employee
	{
		private static double bonusRate = 1.2;

		public SoftwareDeveloper(double wage)
		{
			Wage = wage;
		}

		public override double CalculateBonusAbstract()
		{
			Console.WriteLine("SoftwareDeveloper - CalculateBonusAbstract");
			return bonusRate * Wage;
		}

		public new double CalculateBonusNormal()
		{
			Console.WriteLine("SoftwareDeveloper - CalculateBonusNormal");
			return bonusRate * Wage;
		}

		public override double CalculateBonusVirtual()
		{
			Console.WriteLine("Employee - CalculateBonusVirtual");
			return bonusRate * Wage;
		}
	}
}
