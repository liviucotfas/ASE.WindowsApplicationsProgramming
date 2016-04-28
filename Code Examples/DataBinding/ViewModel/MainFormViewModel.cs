﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataBindingDialogs.Annotations;
using DataBindingSample.Entities;

namespace DataBindingSample.ViewModel
{
	internal class MainFormViewModel : INotifyPropertyChanged
	{
		#region Properties

		#region LastName
		private string _lastName;
		public string LastName {
			get { return _lastName; }
			set
			{
				if (_lastName == value)
					return;
				_lastName = value;

				//If we use [CallerMemberName] in the OnPropertyChanged method
				//OnPropertyChanged();
				//If we don't use the [CallerMemberName] in the OnPropertyChanged method
				OnPropertyChanged("LastName");
			}
		}
		#endregion

		#region FirstName
		private string _firstName;
		public string FirstName
		{
			get { return _firstName; }
			set
			{
				if (_firstName == value)
					return;
				_firstName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region FirstName
		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set
			{
				if (_birthDate == value)
					return;
				_birthDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		public BindingList<Participant> Participants { get; set; }
		#endregion

		public MainFormViewModel()
		{
			Participants = new BindingList<Participant>();
			BirthDate = DateTime.Now;
		}

		#region Methods
		public void AddParticipant()
		{
			Participants.Add(new Participant(LastName, FirstName, BirthDate));
			LastName = FirstName = string.Empty;
			BirthDate = DateTime.Today;
		}

		public void DeleteParticipant(Participant participant)
		{
			Participants.Remove(participant);
		}
		#endregion

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		// [CallerMemberName] - Allows you to obtain the method or property name of the caller to the method. https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if(PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
