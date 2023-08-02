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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void customButtonClass3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingPageForm form = new StartingPageForm();
            form.ShowDialog();
            this.Close();
        }

        private void customButtonClass1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FingerprintsForm form = new FingerprintsForm();
            form.ShowDialog();
            this.Close();
        }

        private void customButtonClass2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaceForm form = new FaceForm();
            form.ShowDialog();
            this.Close();
        }

        private void customButtonClass4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalForm form = new FinalForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
