namespace KioskIdentiti
{
    partial class FaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            BackBtn = new CustomButton.CustomButtonClass();
            pictureBox1 = new PictureBox();
            HomeBtn = new CustomButton.CustomButtonClass();
            CameraFrame = new PictureBox();
            label1 = new Label();
            cameraTimer = new System.Windows.Forms.Timer(components);
            FormChangeTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CameraFrame).BeginInit();
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
            BackBtn.Location = new Point(8, 23);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(375, 100);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "    Back";
            BackBtn.TextAlign = ContentAlignment.MiddleLeft;
            BackBtn.TextColor = Color.White;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(760, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            HomeBtn.ForeColor = Color.DarkSlateGray;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.Location = new Point(1741, 25);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(66, 88);
            HomeBtn.TabIndex = 2;
            HomeBtn.TextColor = Color.DarkSlateGray;
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // CameraFrame
            // 
            CameraFrame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CameraFrame.BackColor = Color.Black;
            CameraFrame.Location = new Point(13, 143);
            CameraFrame.Name = "CameraFrame";
            CameraFrame.Size = new Size(1788, 1100);
            CameraFrame.SizeMode = PictureBoxSizeMode.Zoom;
            CameraFrame.TabIndex = 3;
            CameraFrame.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 1283);
            label1.Name = "label1";
            label1.Size = new Size(1106, 122);
            label1.TabIndex = 4;
            label1.Text = "Position your face in front of the camera\nand do not move until verification is complete";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cameraTimer
            // 
            cameraTimer.Interval = 17;
            cameraTimer.Tick += cameraTimer_Tick;
            // 
            // FormChangeTimer
            // 
            FormChangeTimer.Interval = 3000;
            FormChangeTimer.Tick += FormChangeTimer_Tick;
            // 
            // FaceForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 82, 217);
            ClientSize = new Size(1812, 1441);
            Controls.Add(label1);
            Controls.Add(CameraFrame);
            Controls.Add(HomeBtn);
            Controls.Add(pictureBox1);
            Controls.Add(BackBtn);
            Name = "FaceForm";
            Text = "FaceForm";
            WindowState = FormWindowState.Maximized;
            Load += FaceForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CameraFrame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton.CustomButtonClass BackBtn;
        private PictureBox pictureBox1;
        private CustomButton.CustomButtonClass HomeBtn;
        private PictureBox CameraFrame;
        private Label label1;
        private System.Windows.Forms.Timer cameraTimer;
        private System.Windows.Forms.Timer FormChangeTimer;
    }
}