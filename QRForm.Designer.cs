namespace KioskIdentiti
{
    partial class QRForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRForm));
            BackBtn = new CustomButton.CustomButtonClass();
            homeBtn = new CustomButton.CustomButtonClass();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            FormChangeTimer = new System.Windows.Forms.Timer(components);
            customButtonClass1 = new CustomButton.CustomButtonClass();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundColor = Color.Transparent;
            BackBtn.BorderColor = Color.Beige;
            BackBtn.BorderRadius = 40;
            BackBtn.BorderSize = 0;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Arial", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.White;
            BackBtn.Image = (Image)resources.GetObject("BackBtn.Image");
            BackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BackBtn.Location = new Point(8, 17);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(160, 100);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "    Back";
            BackBtn.TextAlign = ContentAlignment.MiddleLeft;
            BackBtn.TextColor = Color.White;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            homeBtn.BackColor = Color.Transparent;
            homeBtn.BackgroundColor = Color.Transparent;
            homeBtn.BorderColor = Color.Beige;
            homeBtn.BorderRadius = 40;
            homeBtn.BorderSize = 0;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.ForeColor = Color.DarkSlateGray;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleRight;
            homeBtn.Location = new Point(2356, 12);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(70, 100);
            homeBtn.TabIndex = 1;
            homeBtn.TextColor = Color.DarkSlateGray;
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(920, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(658, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(822, 493);
            label1.Name = "label1";
            label1.Size = new Size(869, 122);
            label1.TabIndex = 3;
            label1.Text = "Please scan the QR code below on\nyour iDentiti mobile application";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(968, 755);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(558, 558);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FormChangeTimer
            // 
            FormChangeTimer.Interval = 5000;
            FormChangeTimer.Tick += FormChangeTimer_Tick;
            // 
            // customButtonClass1
            // 
            customButtonClass1.Anchor = AnchorStyles.None;
            customButtonClass1.BackColor = Color.White;
            customButtonClass1.BackgroundColor = Color.White;
            customButtonClass1.BorderColor = Color.White;
            customButtonClass1.BorderRadius = 40;
            customButtonClass1.BorderSize = 0;
            customButtonClass1.Enabled = false;
            customButtonClass1.FlatAppearance.BorderSize = 0;
            customButtonClass1.FlatStyle = FlatStyle.Flat;
            customButtonClass1.ForeColor = Color.DarkSlateGray;
            customButtonClass1.Location = new Point(929, 714);
            customButtonClass1.Name = "customButtonClass1";
            customButtonClass1.Size = new Size(634, 634);
            customButtonClass1.TabIndex = 5;
            customButtonClass1.TextColor = Color.DarkSlateGray;
            customButtonClass1.UseVisualStyleBackColor = false;
            // 
            // QRForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 82, 217);
            ClientSize = new Size(2438, 1531);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(homeBtn);
            Controls.Add(BackBtn);
            Controls.Add(customButtonClass1);
            Name = "QRForm";
            Text = "QRForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton.CustomButtonClass BackBtn;
        private CustomButton.CustomButtonClass homeBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer FormChangeTimer;
        private CustomButton.CustomButtonClass customButtonClass1;
    }
}