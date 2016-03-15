using System;
using ConstructorDestructor.Entities;

namespace ConstructorDestructor
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			AbstractNormalVirtualMethods();
		}

		private static void AbstractNormalVirtualMethods()
		{
			var softwareDeveloper = new SoftwareDeveloper(2000);

			//Abstract method
			Console.WriteLine("\n###Abstract");
			Console.WriteLine(softwareDeveloper.CalculateBonusAbstract());
			Console.WriteLine(((Employee)softwareDeveloper).CalculateBonusAbstract());

			//Normal method
			Console.Write("\n###Hide");
			Console.WriteLine(softwareDeveloper.CalculateBonusNormal());
			Console.WriteLine(((Employee)softwareDeveloper).CalculateBonusNormal());

			//Virtual method
			Console.Write("\n###Override");
			Console.WriteLine(softwareDeveloper.CalculateBonusVirtual());
			Console.WriteLine(((Employee)softwareDeveloper).CalculateBonusVirtual());
		}

		private static void UpCastDownCast()
		{
			//var employee = new Employee(2000);
			//Person person = employee;

			//Employee employee2 = (Employee) person;
		}
	}
}
