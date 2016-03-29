using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ValidationTextFile
{
	public partial class MainForm : Form
	{
		#region Methods
		public MainForm()
		{
			InitializeComponent();
		}

		public bool IsValid()
		{
			var isValid = true;
			if (tbNume.Text == "")
			{
				epNume.SetError(tbNume, "Camp obligatoriu!");
				isValid = false;
			}
			else
				epNume.SetError(tbNume, string.Empty);

			return isValid;
		}
		#endregion

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			tbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
			tbOra.Text =  string.Format("{0}: {1}", DateTime.Now.Hour, DateTime.Now.Minute);
		}

		private void btnCuloare_Click(object sender, EventArgs e)
		{
			var colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog() == DialogResult.OK) 
			{
				lbCuloarePick.BackColor = colorDialog.Color;
			}
		}

		private void btnSalvare_Click(object sender, EventArgs e)
		{
			var svfdlgFisier = new SaveFileDialog();
			svfdlgFisier.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			svfdlgFisier.FilterIndex = 1;
			svfdlgFisier.RestoreDirectory = true;

			if (svfdlgFisier.ShowDialog() == DialogResult.OK)
			{
				var txtFile = File.CreateText(svfdlgFisier.FileName);
				for (var i = 0; i < 3; i++)
				{
					txtFile.WriteLine();
				}
				txtFile.WriteLine("**************  Bon comanda-S.C Car S.R.L **************");
				for (var i = 0; i < 3; i++)
				{
					txtFile.WriteLine();
				}
				txtFile.WriteLine("Data emiterii: " + tbData.Text + "\t" + "Ora comanda: " + tbOra.Text);

				txtFile.WriteLine("Nume: " + tbNume.Text + "         Prenume:" + tbPrenume.Text);
				if (rbF.Checked)
					txtFile.WriteLine("Sex: " + rbF.Text);
				else txtFile.WriteLine("Sex: " + rbM.Text);
				txtFile.WriteLine("Varsta: "+tbVarsta.Text+"  Permis: "+cblPermis.SelectedItem);
				txtFile.WriteLine("Data livrarii: ");
				txtFile.WriteLine("De la: " + dtpDeLa.Value.ToString(CultureInfo.InvariantCulture) + "   Pana la: " + dtpPanaLa.Value.ToString(CultureInfo.InvariantCulture));
				txtFile.WriteLine("Masina:   "+cbMasina.SelectedItem+"   Culoare: "+ lbCuloarePick.BackColor);
				for (int i = 0; i < 5; i++)
				{
					txtFile.WriteLine();
				}
				txtFile.WriteLine("Semnatura client:                   Semantura consilier:   ");
				txtFile.Close();
			}
		}

		private void tbVarsta_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				if ((Convert.ToInt32(tbVarsta.Text) < 18) || (Convert.ToInt32(tbVarsta.Text) > 100))
				{
					//MessageBox.Show("Varsta este cuprinsa intre 18 si 100 de ani!");
					throw new Exception("Varsta este cuprinsa intre 18 si 100 de ani!");
					//e.Cancel = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Eroare ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
		}
		#endregion
	}
}