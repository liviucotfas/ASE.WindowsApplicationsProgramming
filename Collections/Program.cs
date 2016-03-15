using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		static void ArrayList()
		{
			var words = new ArrayList();
			words.Add("melon");
			words.Add("avocado");
			string first = (string)words[0];

			//int first = (int)words[0];
		}

		static void ListExample()
		{
			var words = new List<string>(); // New string-typed list
			words.Add("melon");
			words.Add("avocado");
			words.AddRange(new[] { "banana", "plum" });
			words.Insert(0, "lemon"); // Insert at start
			words.InsertRange(0, new[] { "peach", "nashi" }); // Insert at start
			words.Remove("melon");
			words.RemoveAt(3); // Remove the 4th element
			words.RemoveRange(0, 2); // Remove first 2 elements
									 // Remove all strings starting in 'n':
			words.RemoveAll(x => x.StartsWith("n"));


			for (var i=0; i<words.Count; i++)
			{
				Console.WriteLine(words[i]);
			}

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
