﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using SerializationTextFileXML.Entities;

namespace SerializationBinaryXMLTextFile
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


		#region Binary
		private void btnSerializeBinary_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			using (FileStream s = File.Create("SerializedBinary.bin"))
				formatter.Serialize(s, _participants);
		}

		private void btnDeserializeBinary_Click(object sender, EventArgs e)
		{
			IFormatter formatter = new BinaryFormatter();
			using (FileStream s = File.OpenRead("SerializedBinary.bin"))
			{
				_participants = (List<Participant>)formatter.Deserialize(s);
				DisplayParticipants();
			}
		}
		#endregion

		#region XML
		private void btnSerializeXML_Click(object sender, EventArgs e)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
			using (TextWriter writer = new StreamWriter("SerializedXML.xml"))
			{
				serializer.Serialize(writer, _participants);
			}
		}

		private void btnDeserializeXML_Click(object sender, EventArgs e)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
			
			using (StreamReader streamReader = new StreamReader("SerializedXML.xml"))
			{
				_participants = (List<Participant>)serializer.Deserialize(streamReader);
				DisplayParticipants();
			}
		}
		#endregion

		private void btnTextFile_Click(object sender, EventArgs e)
		{
			// Create an instance of the open file dialog box.
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File | *.txt";
			saveFileDialog.Title = "Save as text file";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Approach 1
				//StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
				//try
				//{
				//	sw.WriteLine("LastName,FirstName,BirthDate");

				//	foreach (var participant in _participants)
				//	{
				//		sw.WriteLine("{0}, {1}, {2}"
				//			, participant.LastName
				//			, participant.FirstName
				//			, participant.BirthDate.ToShortDateString());
				//	}
				//}
				//finally
				//{
				//	sw.Dispose();
				//}

				//2. Approach 2 - recommended
				// generates the try{} finally{} in Version 1
				using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
				{
					sw.WriteLine("LastName,FirstName,BirthDate");

					foreach (var participant in _participants)
					{
						sw.WriteLine("{0}, {1}, {2}"
							, participant.LastName
							, participant.FirstName
							, participant.BirthDate.ToShortDateString());
					}
				}
			}
		}
		#endregion
	}
}
