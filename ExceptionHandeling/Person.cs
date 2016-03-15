using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
	class Person
	{
		#region Attributes
		String personName;
		Int32 personAge;
		#endregion

		#region Properties
		public Int32 PersonAge
		{
			get { return personAge; }
			set
			{
				if (value < 0 || value > 150)
					throw new InvalidAgeException(value);
				else
					value = personAge;
			}
		}

		public String PersonName
		{
			get { return personName; }
			set { personName = value; }
		}

		#endregion

		public Person(String personName, Int32 personAge)
		{
			this.personAge = personAge; this.personName = personName;
		}

		#region IComparable Members

		/*public int CompareTo(Object obj)
		{
			return this.personAge.CompareTo(((Person)obj).personAge);
		}*/

		#endregion
	}
}
