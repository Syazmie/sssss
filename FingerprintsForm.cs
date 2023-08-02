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
    public partial class FingerprintsForm : Form
    {
        public FingerprintsForm()
        {
            InitializeComponent();
            // if device is present then tukar from disable to enable.
            FormChangeTimer.Start();

        }

        private void customButtonClass2_Click(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            OptionForm form = new OptionForm();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            StartingPageForm form = new StartingPageForm();
            form.ShowDialog();
            this.Close();
        }

        private void customButtonClass1_Click(object sender, EventArgs e)
        {
            // if enable then change text fingerprints not detected to detected.
            // change page.
        }

        private void FormChangeTimer_Tick(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            QRForm form = new QRForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
