using System;
using ValidationExceptionHandeling.Entities;

namespace ValidationExceptionHandling.Entities
{
	internal class Participant
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }

		#region BirthDate
		public DateTime BirthDate { get; set; }
		#endregion

		public GenderEnum Gender { get; set; }
		public string SSN { get; set; }

		public Participant(string lastName, string firstName, DateTime birthDate, GenderEnum gender, string ssn)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
			Gender = gender;
			SSN = ssn;
		}
	}
}
