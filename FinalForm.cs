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
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingPageForm form = new StartingPageForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
