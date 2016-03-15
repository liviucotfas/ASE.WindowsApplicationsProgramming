using System;

namespace EnumStructClass
{
	internal class Program
	{
		private static void Main()
		{
			ValueTypeAssignment();
			ReferenceTypeAssignment();
		}

		private static void ValueTypeAssignment()
		{
			Console.WriteLine("###Assigning value types\n");
			var personStruct1 = new PersonStruct(1, "name1", OccupationEnum.Student);
			var personStruct2 = personStruct1;
			
			Console.WriteLine(personStruct1); // automatically calls .ToString(). The method is defined in System.Object and overridden in PersonStruct
			Console.WriteLine(personStruct2);

			// Change personStruct1.Name and print again. personStruct2.Name is not changed.
			personStruct1.Name = "NewName";
			Console.WriteLine(personStruct1);
			Console.WriteLine(personStruct2);
		}

		private static void ReferenceTypeAssignment()
		{
			Console.WriteLine("Assigning reference types\n");
			var personClass1 = new PersonClass(1, "name1", OccupationEnum.Student);
			var personClass2 = personClass1;

			Console.WriteLine(personClass1); // automatically calls .ToString(). The method is defined in System.Object and overridden in PersonClass
			Console.WriteLine(personClass2);

			// Change personClass1.Name and print again. personClass2.Name has changed.
			personClass1.Name = "NewUserName";
			personClass1.SetAge(22);
			Console.WriteLine("\n=> Changed userAccountStruct1.Name\n");
			Console.WriteLine(personClass1);
			Console.WriteLine(personClass2);
		}
	}
}
