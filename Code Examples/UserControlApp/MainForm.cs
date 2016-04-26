using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClockUserControlAppSample
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
            ceas.Ora = int.Parse(sir[0]);
            ceas.Min = int.Parse(sir[1]);
            //Setam acceasi ora/min si pentru alarma =>va porni alarma
            ceas.OraAlarm = ceas.Ora;
            ceas.MinAlarm = ceas.Min;
            ceas.Invalidate();
        }

        private void btnGetSystemTime_Click(object sender, EventArgs e)
        {
            ceas.Ora = DateTime.Now.Hour;
            ceas.Min = DateTime.Now.Minute;
            ceas.Sec = DateTime.Now.Second;
        }
    }
}