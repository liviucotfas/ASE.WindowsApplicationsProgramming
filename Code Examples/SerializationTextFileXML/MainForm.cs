using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using SerializationTextFileXML.Entities;

namespace SerializationTextFileXML
{
	public partial class MainForm : Form
	{
		#region Attributes
		private List<Participant> _participants;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			_participants = new List<Participant>();
		}

		#region Methods
		public void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());

				lvParticipants.Items.Add(listViewItem);
			}
		}
		#endregion

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);
			_participants.Add(participant);

			DisplayParticipants();
		}
		#endregion

		private void btnSerialize_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			using (FileStream s = File.Create("serialized.bin"))
				formatter.Serialize(s, _participants);
		}

		private void btnDeserialize_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			using (FileStream s = File.OpenRead("serialized.bin"))
			{
				_participants = (List<Participant>)formatter.Deserialize(s);
				DisplayParticipants();
			}
		}

		private void btnTextFile_Click(object sender, EventArgs e)
		{

		}
	}
}
