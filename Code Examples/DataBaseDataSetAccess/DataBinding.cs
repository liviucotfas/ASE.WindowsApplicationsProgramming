using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataBaseDataSetAccess
{
    public partial class DataBinding : Form
    {
	    private OleDbDataAdapter _sqlDataAdapter;
	    private DataSet _dsStudenti;
	    private CurrencyManager _currencyManager;

        public DataBinding()
        {
	        InitializeComponent();
			Load += DataBinding_Load;
        }

		private void DataBinding_Load(object sender, EventArgs e)
		{
			var sqlConnection = new OleDbConnection(ConfigurationManager.AppSettings["ConnectionString"]);
			_dsStudenti = new DataSet();

			try
			{
				// daca inlocuim [Note] cu Note vom obtine o eroare din Access (cuvantul este rezervat)
				_sqlDataAdapter = new OleDbDataAdapter("SELECT Studenti.Cod, Nume, AVG(nota) AS Medie FROM [Studenti] INNER JOIN [Note] ON Studenti.Cod = Note.Cod GROUP BY Nume, Studenti.Cod", sqlConnection);
				var updateCommand = new OleDbCommand("UPDATE Studenti SET Nume = @Nume WHERE Cod = @Cod", sqlConnection);
				updateCommand.Parameters.Add(new OleDbParameter("@Nume", OleDbType.VarChar, 10, "Nume"));
				updateCommand.Parameters.Add(new OleDbParameter("@Cod", OleDbType.Numeric, 32, "Cod"));
				_sqlDataAdapter.UpdateCommand = updateCommand;
				_sqlDataAdapter.Fill(_dsStudenti, "tabelaStudenti");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			//DataBinding Grid
			dgvStudenti.DataSource = _dsStudenti;
			dgvStudenti.DataMember = "tabelaStudenti";

			//DataBinding TextBox
			tbNume.DataBindings.Add("Text", _dsStudenti.Tables["tabelaStudenti"], "Nume");
			tbMedie.DataBindings.Add("Text", _dsStudenti.Tables["tabelaStudenti"], "Medie");

			_currencyManager = (CurrencyManager)BindingContext[_dsStudenti.Tables["tabelaStudenti"]];
		}

		private void btnSalveaza_Click(object sender, EventArgs e)
        {
            // In caz de eroare - vedeti fisierul tema :)
            _sqlDataAdapter.Update(_dsStudenti.Tables[0]);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            _currencyManager.Position += 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _currencyManager.Position -= 1;
        }
    }
}
