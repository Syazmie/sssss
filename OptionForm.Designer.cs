namespace KioskIdentiti
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            customButtonClass1 = new CustomButton.CustomButtonClass();
            customButtonClass2 = new CustomButton.CustomButtonClass();
            customButtonClass3 = new CustomButton.CustomButtonClass();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(799, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(658, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(648, 708);
            label1.Name = "label1";
            label1.Size = new Size(1056, 61);
            label1.TabIndex = 1;
            label1.Text = "How would you wish to verify your identity?";
            // 
            // customButtonClass1
            // 
            customButtonClass1.Anchor = AnchorStyles.None;
            customButtonClass1.BackColor = Color.Transparent;
            customButtonClass1.BackgroundColor = Color.Transparent;
            customButtonClass1.BorderColor = Color.White;
            customButtonClass1.BorderRadius = 40;
            customButtonClass1.BorderSize = 5;
            customButtonClass1.FlatAppearance.BorderSize = 0;
            customButtonClass1.FlatStyle = FlatStyle.Flat;
            customButtonClass1.Font = new Font("Arial", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            customButtonClass1.ForeColor = Color.White;
            customButtonClass1.Location = new Point(786, 944);
            customButtonClass1.Name = "customButtonClass1";
            customButtonClass1.Size = new Size(310, 100);
            customButtonClass1.TabIndex = 2;
            customButtonClass1.Text = "Fingerprint";
            customButtonClass1.TextColor = Color.White;
            customButtonClass1.UseVisualStyleBackColor = false;
            customButtonClass1.Click += customButtonClass1_Click;
            // 
            // customButtonClass2
            // 
            customButtonClass2.Anchor = AnchorStyles.None;
            customButtonClass2.BackColor = Color.Transparent;
            customButtonClass2.BackgroundColor = Color.Transparent;
            customButtonClass2.BorderColor = Color.White;
            customButtonClass2.BorderRadius = 40;
            customButtonClass2.BorderSize = 5;
            customButtonClass2.FlatAppearance.BorderSize = 0;
            customButtonClass2.FlatStyle = FlatStyle.Flat;
            customButtonClass2.Font = new Font("Arial", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            customButtonClass2.ForeColor = Color.White;
            customButtonClass2.Location = new Point(1165, 944);
            customButtonClass2.Name = "customButtonClass2";
            customButtonClass2.Size = new Size(332, 100);
            customButtonClass2.TabIndex = 3;
            customButtonClass2.Text = "Face";
            customButtonClass2.TextColor = Color.White;
            customButtonClass2.UseVisualStyleBackColor = false;
            customButtonClass2.Click += customButtonClass2_Click;
            // 
            // customButtonClass3
            // 
            customButtonClass3.BackColor = Color.Transparent;
            customButtonClass3.BackgroundColor = Color.Transparent;
            customButtonClass3.BorderColor = Color.Beige;
            customButtonClass3.BorderRadius = 40;
            customButtonClass3.BorderSize = 0;
            customButtonClass3.FlatAppearance.BorderSize = 0;
            customButtonClass3.FlatStyle = FlatStyle.Flat;
            customButtonClass3.ForeColor = Color.White;
            customButtonClass3.Image = (Image)resources.GetObject("customButtonClass3.Image");
            customButtonClass3.ImageAlign = ContentAlignment.MiddleLeft;
            customButtonClass3.Location = new Point(12, 11);
            customButtonClass3.Name = "customButtonClass3";
            customButtonClass3.Size = new Size(375, 100);
            customButtonClass3.TabIndex = 4;
            customButtonClass3.Text = "      Back";
            customButtonClass3.TextAlign = ContentAlignment.MiddleLeft;
            customButtonClass3.TextColor = Color.White;
            customButtonClass3.UseVisualStyleBackColor = false;
            customButtonClass3.Click += customButtonClass3_Click;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 82, 217);
            ClientSize = new Size(2326, 1257);
            Controls.Add(customButtonClass3);
            Controls.Add(customButtonClass2);
            Controls.Add(customButtonClass1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "OptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CustomButton.CustomButtonClass customButtonClass1;
        private CustomButton.CustomButtonClass customButtonClass2;
        private CustomButton.CustomButtonClass customButtonClass3;
    }
}