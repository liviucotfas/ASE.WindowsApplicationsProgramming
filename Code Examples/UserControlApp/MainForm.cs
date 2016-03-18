using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AplicatieTest
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        static extern void Beep(int nota, int durata);

        public MainForm()
        {
            InitializeComponent();
        }

        private void ceas1_Suna(object sender, EventArgs e)
        {
            int DO = 262;
            Beep(DO, 200);
        }

        private void tbOra_MouseDown(object sender, MouseEventArgs e)
        {
            //se fixeaza sursa de date
            tbOra.DoDragDrop(tbOra.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void ceas1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ceas1_DragDrop(object sender, DragEventArgs e)
        {
            string[] sir;
            string date = e.Data.GetData(DataFormats.Text).ToString();
            sir = date.Split(':');
            ceas1.Ora = Int32.Parse(sir[0]);
            ceas1.Min = Int32.Parse(sir[1]);
            //Setam acceasi ora/min si pentru alarma =>va porni alarma
            ceas1.OraAlarm = ceas1.Ora;
            ceas1.MinAlarm = ceas1.Min;
            ceas1.Invalidate();
        }

        private void btnGetSystemTime_Click(object sender, EventArgs e)
        {
            ceas1.Ora = DateTime.Now.Hour;
            ceas1.Min = DateTime.Now.Minute;
            ceas1.Sec = DateTime.Now.Second;
        }
    }
}