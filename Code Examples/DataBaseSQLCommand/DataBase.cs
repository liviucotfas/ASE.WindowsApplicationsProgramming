using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseSQLCommand
{
    public partial class DataBase : Form
    {
	    private readonly SqlConnection _sqlConnection;

        public DataBase()
        {
            InitializeComponent();
            _sqlConnection = new SqlConnection("Data Source=N5110;Initial Catalog=ASESeminar;Integrated Security=True");
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            tbAfisare.Text = "";
            
            const string stringSql = "select * from Studenti";
            try
            {
                _sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(stringSql, _sqlConnection);
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                    tbAfisare.Text = tbAfisare.Text + "\r\n" + sqlReader["Nume"];
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_sqlConnection.State != ConnectionState.Closed) _sqlConnection.Close();
            }
        }

        private void btnInstert_Click(object sender, EventArgs e)
        {
			var sqlCommand = new SqlCommand("select Max(Cod) from Studenti");
            sqlCommand.Connection = _sqlConnection;
	        var nume = "Student 1";
			var varsta = 20;
			var cnp = "0000000000000";
            try
            {
                _sqlConnection.Open();
                sqlCommand.Transaction = _sqlConnection.BeginTransaction();
                int cod = Convert.ToInt16(sqlCommand.ExecuteScalar());

                sqlCommand.CommandText = "insert into Studenti values(@cd,@num,@varsta,@CNP)";
                var par1 = new SqlParameter("@cd", SqlDbType.Int, 4, "cod");
                par1.Value = cod + 1;
				var par2 = new SqlParameter("@num", SqlDbType.VarChar, 10, "nume");
                par2.Value = nume;
				var par3 = new SqlParameter("@varsta", SqlDbType.Int, 4, "varsta");
                par3.Value = varsta;
				var par4 = new SqlParameter("@CNP", SqlDbType.VarChar, 13, "CNP");
                par4.Value = cnp;

                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Transaction.Commit();
                MessageBox.Show(" Inregistrare inserata cu succes!");
            }
            catch (Exception ex)
            {
                sqlCommand.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_sqlConnection.State != ConnectionState.Closed) _sqlConnection.Close();
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "StudentiVarsta";
            sqlCommand.CommandType = CommandType.StoredProcedure;
	        try
            {
                _sqlConnection.Open();
                sqlCommand.Parameters.Add("@varsta", SqlDbType.Int);
                sqlCommand.Parameters["@varsta"].Value = 26;
                sqlCommand.Parameters["@varsta"].Direction = ParameterDirection.Input;
                var sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    tbAfisare.Text = tbAfisare.Text + "\r\n" + sqlDataReader["Nume"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (_sqlConnection.State != ConnectionState.Closed) _sqlConnection.Close();
            }
        }

       private void btnGoleste_Click(object sender, EventArgs e)
        {
            tbAfisare.Text = "";
        }
    }
}