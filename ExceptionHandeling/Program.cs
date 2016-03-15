using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
	class Program
	{
			static void Main(string[] args)
		{
				AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

				//http://msdn.microsoft.com/en-us/library/gg145035.aspx

				// Other important lists in  System.Collections
				// Queue, Stack, SortedList
				ArrayList personList = new ArrayList();

				Random rnd = new Random();

				for (int i = 0; i < 10; i++)
				{
					personList.Add(new Person("Persoana " + i, rnd.Next(100)));
				}

				foreach (Person p in personList)
					Console.WriteLine("Nume: " + p.PersonName + " Varsta: " + p.PersonAge);

				//IComparable implementation is called automatically by methods such as Array..::.Sort and ArrayList..::.Sort. 

				//folosit ca exemplu pentru try catch..
				//personList.Sort();

				foreach (Person p in personList)
					Console.WriteLine("Nume: " + p.PersonName + " Varsta: " + p.PersonAge);

				try
				{
					((Person)personList[0]).PersonAge = 200;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}


				//http://msdn.microsoft.com/en-us/library/system.collections.generic.aspx
			}

			static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
			{
			throw new NotImplementedException();
		}
	}
}
