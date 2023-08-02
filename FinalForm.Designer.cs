namespace KioskIdentiti
{
    partial class FinalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            customButtonClass1 = new CustomButton.CustomButtonClass();
            HomeBtn = new CustomButton.CustomButtonClass();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(634, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(414, 719);
            label1.Name = "label1";
            label1.Size = new Size(1261, 61);
            label1.TabIndex = 1;
            label1.Text = "Credential successfully issued to your mobile wallet";
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
            customButtonClass1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButtonClass1.ForeColor = Color.White;
            customButtonClass1.Location = new Point(876, 977);
            customButtonClass1.Name = "customButtonClass1";
            customButtonClass1.Size = new Size(375, 100);
            customButtonClass1.TabIndex = 2;
            customButtonClass1.Text = "Close";
            customButtonClass1.TextColor = Color.White;
            customButtonClass1.UseVisualStyleBackColor = false;
            customButtonClass1.Click += HomeBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.BackgroundColor = Color.Transparent;
            HomeBtn.BorderColor = Color.Beige;
            HomeBtn.BorderRadius = 40;
            HomeBtn.BorderSize = 0;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.ForeColor = Color.DarkTurquoise;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = ContentAlignment.MiddleRight;
            HomeBtn.Location = new Point(1969, 16);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(58, 85);
            HomeBtn.TabIndex = 3;
            HomeBtn.TextColor = Color.DarkTurquoise;
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 82, 217);
            ClientSize = new Size(2045, 1460);
            Controls.Add(HomeBtn);
            Controls.Add(customButtonClass1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FinalForm";
            Text = "FinalForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CustomButton.CustomButtonClass customButtonClass1;
        private CustomButton.CustomButtonClass HomeBtn;
    }
}