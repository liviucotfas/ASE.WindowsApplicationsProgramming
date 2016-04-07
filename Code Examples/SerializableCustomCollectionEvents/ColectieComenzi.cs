using System;
using System.Collections;

namespace SerializableCustomCollectionEvents
{
	//http://msdn.microsoft.com/en-us/library/system.collections.ienumerator.aspx
	//http://www.codeproject.com/KB/cs/csenumerators.aspx
	[Serializable]
	internal class ColectieComenzi: IEnumerable
	{
		#region Proprietati
		ArrayList listaComenzi;
		public int Lungime
		{
			get { return listaComenzi.Count; }
		}
		#endregion

		#region Metode
		public void Adauga(Comanda comanda)
		{
			listaComenzi.Add(comanda);
			//ne abonam la evenimentul de modificare comanda
			comanda.ModificareComanda += ComandaModificareComanda;
			// notificam modificarea colectiei (adaugarea unei noi comenzi)
			OnModificareColectie(new EventArgs());
		}

		void ComandaModificareComanda(object sender, EventArgs e)
		{
			// notificam modificarea colectiei
			OnModificareColectie(new EventArgs());
		}

		public void Goleste()
		{
			listaComenzi.Clear();
			// notificam modificarea colectiei
			OnModificareColectie(new EventArgs());
		}

		public void Sterge(Comanda comanda)
		{
			listaComenzi.Remove(comanda);
			// notificam modificarea colectiei
			OnModificareColectie(new EventArgs());
		}

		#endregion

		#region Constructor
		public ColectieComenzi()
		{
			listaComenzi = new ArrayList();
		}
		#endregion

		#region Eveniment: ModificareColectie
		[field: NonSerialized] 
		public event EventHandler ModificareColectie;
		protected virtual void OnModificareColectie(EventArgs e)
		{
			if (ModificareColectie != null)
			{
				ModificareColectie(this, e);
			}
		}
		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return new ColectieComenziEnum(listaComenzi);
		}
		#endregion
	}

	internal class ColectieComenziEnum : IEnumerator
	{
		private int _pozitie = -1;
		private readonly ArrayList _listaComenzi;

		public ColectieComenziEnum(ArrayList listaComenzi)
		{
			_listaComenzi = listaComenzi;
		}

		#region IEnumerator Members

		public object Current
		{
			get
			{
				try
				{
					return _listaComenzi[_pozitie];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}

		public bool MoveNext()
		{
			return (++_pozitie < _listaComenzi.Count);
		}

		public void Reset()
		{
			_pozitie = -1;
		}

		#endregion
	}
}
