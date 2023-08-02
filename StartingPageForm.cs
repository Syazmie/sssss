namespace KioskIdentiti
{
    public partial class StartingPageForm : Form
    {
        bool keypadExpand;
        int click = 0;
        public StartingPageForm()
        {
            InitializeComponent();
        }

        private void KeypadPanelTimer_Tick(object sender, EventArgs e)
        {
            if (!keypadExpand)
            {
                click = 1;
                KeypadPanel.Height += 600;
                if (KeypadPanel.Height == KeypadPanel.MaximumSize.Height)
                {
                    keypadExpand = true;
                    KeypadPanelTimer.Stop();
                    textBox1.Text = "";

                }
            }

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            KeypadPanelTimer.Start();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            int selectedValue = int.Parse((sender as Button).Text.ToString());

            if (textBox1.Text.ToString() == "")
            {
                textBox1.Text = $"{selectedValue}";
            }
            else
            {
                textBox1.Text = $"{textBox1.Text}{selectedValue}";
            }
        }

        private void clearButton_Click(Object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void customButtonClass1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 8)
            {
                click = 0;
                this.Hide();
                OptionForm form = new OptionForm();
                form.ShowDialog();
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && click > 0)
            {
                customButtonClass1.Enabled = true;
            }
        }
    }
}