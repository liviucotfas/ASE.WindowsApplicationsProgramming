using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseDataSetSQLServer
{
    public partial class DataBinding : Form
    {
	    private SqlDataAdapter _sqlDataAdapter;
	    private DataSet _dsStudenti;
	    private CurrencyManager _currencyManager;

        public DataBinding()
        {
	        InitializeComponent();
			Load += DataBinding_Load;
        }

		private void DataBinding_Load(object sender, EventArgs e)
		{
			var sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
			_dsStudenti = new DataSet();

			try
			{
				_sqlDataAdapter = new SqlDataAdapter("SELECT Studenti.Cod, Nume, AVG(nota) AS Medie FROM Studenti INNER JOIN Note ON Studenti.Cod = Note.Cod GROUP BY Nume, Studenti.Cod", sqlConnection);
				var updateCommand = new SqlCommand("UPDATE Studenti SET Nume = @Nume WHERE Cod = @Cod", sqlConnection);
				updateCommand.Parameters.Add(new SqlParameter("@Nume", SqlDbType.VarChar, 10, "Nume"));
				updateCommand.Parameters.Add(new SqlParameter("@Cod", SqlDbType.Int, 32, "Cod"));
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
