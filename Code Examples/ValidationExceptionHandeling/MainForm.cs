using System;
using System.Windows.Forms;

namespace ValidationExceptionHandling
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text.Trim();
			string lastName = tbLastName.Text.Trim();
			DateTime birthDate = dtpBirthDate.Value;

			bool formContainsErrors = false;
			
			if (string.IsNullOrWhiteSpace(lastName))
			{
				epLastName.SetError(tbFirstName, "The Last Name should not be empty!");
				formContainsErrors = true;
			}

			if (string.IsNullOrWhiteSpace(firstName))
			{
				epFirstName.SetError(tbFirstName, "The First Name should not be empty!");
				formContainsErrors = true;
			}

			//TODO: check the birthDate
			//TODO: check the Gender
			//TODO: check the SSN (ex: first digit corresponds to the gender, etc.)

			if (formContainsErrors)
			{
				//An ErrorProvider control should
				MessageBox.Show("The form contains errors!",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

			//TODO Logic for adding the participant to the list bellow
		}

		private void tbLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string lastName = ((TextBox) sender).Text.Trim();

			if (string.IsNullOrWhiteSpace(lastName))
			{
				e.Cancel = true; //prevents the user from changing the focus to another control

				epLastName.SetError((Control)sender, "The Last Name should not be empty!");
			}
		}

		private void tbLastName_Validated(object sender, EventArgs e)
		{
			epLastName.Clear();
		}

		private void tbFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string firstName = ((TextBox) sender).Text.Trim();

			if (string.IsNullOrWhiteSpace(firstName))
			{
				e.Cancel = true; //prevents the user from changing the focus to another control

				epFirstName.SetError((Control) sender, "The First Name should not be empty!");
			}
		}
		#endregion

		private void tbFirstName_Validated(object sender, EventArgs e)
		{
			epFirstName.Clear();
		}

		
	}
}
