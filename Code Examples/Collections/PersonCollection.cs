﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
	internal class PersonCollection :IEnumerable<Person>
	{
		private Person[] _personArray;

		public Person this[int index]
		{
			get { return _personArray[index]; }
			set { _personArray[index] = value; }
		}

		public int Length
		{
			get { return _personArray.Length; }
		}

		public PersonCollection()
		{
			_personArray = new []
			{
				new Person("name1", 1),
				new Person("name2", 2),
				new Person("name3", 3)
			};
		}


		public IEnumerator<Person> GetEnumerator()
		{
			return new PersonEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	internal class PersonEnumerator : IEnumerator<Person>
	{
		private int _nIndex;
		private PersonCollection _personCollection;

		public PersonEnumerator()
		{
			
		}

		public void Dispose(PersonCollection personCollection)
		{
			_personCollection = personCollection;
			_nIndex = -1;
		}

		public bool MoveNext()
		{
			_nIndex++;
			return _nIndex < _personCollection.Length;
		}

		public void Reset()
		{
			_nIndex = -1;
		}

		public Person Current
		{
			get { return _personCollection[_nIndex]; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public void Dispose()
		{
			//TODO
			throw new NotImplementedException();
		}
	}
}