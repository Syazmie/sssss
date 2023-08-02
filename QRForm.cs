using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskIdentiti
{
    public partial class QRForm : Form
    {
        public QRForm()
        {
            InitializeComponent();
            FormChangeTimer.Start();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            StartingPageForm form = new StartingPageForm();
            form.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            OptionForm form = new OptionForm();
            form.ShowDialog();
            this.Close();
        }

        private void FormChangeTimer_Tick(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            FinalForm form = new FinalForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
