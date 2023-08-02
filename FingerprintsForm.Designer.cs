namespace KioskIdentiti
{
    partial class FingerprintsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerprintsForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            customButtonClass1 = new CustomButton.CustomButtonClass();
            customButtonClass2 = new CustomButton.CustomButtonClass();
            customButtonClass3 = new CustomButton.CustomButtonClass();
            FormChangeTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // customButtonClass1
            // 
            resources.ApplyResources(customButtonClass1, "customButtonClass1");
            customButtonClass1.BackColor = Color.Transparent;
            customButtonClass1.BackgroundColor = Color.Transparent;
            customButtonClass1.BorderColor = Color.FromArgb(51, 255, 255, 255);
            customButtonClass1.BorderRadius = 40;
            customButtonClass1.BorderSize = 5;
            customButtonClass1.FlatAppearance.BorderSize = 0;
            customButtonClass1.ForeColor = Color.FromArgb(51, 255, 255, 255);
            customButtonClass1.Name = "customButtonClass1";
            customButtonClass1.TextColor = Color.FromArgb(51, 255, 255, 255);
            customButtonClass1.UseVisualStyleBackColor = false;
            customButtonClass1.Click += customButtonClass1_Click;
            // 
            // customButtonClass2
            // 
            customButtonClass2.BackColor = Color.Transparent;
            customButtonClass2.BackgroundColor = Color.Transparent;
            customButtonClass2.BorderColor = Color.Beige;
            customButtonClass2.BorderRadius = 40;
            customButtonClass2.BorderSize = 0;
            customButtonClass2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(customButtonClass2, "customButtonClass2");
            customButtonClass2.ForeColor = Color.White;
            customButtonClass2.Name = "customButtonClass2";
            customButtonClass2.TextColor = Color.White;
            customButtonClass2.UseVisualStyleBackColor = false;
            customButtonClass2.Click += customButtonClass2_Click;
            // 
            // customButtonClass3
            // 
            resources.ApplyResources(customButtonClass3, "customButtonClass3");
            customButtonClass3.BackColor = Color.Transparent;
            customButtonClass3.BackgroundColor = Color.Transparent;
            customButtonClass3.BorderColor = Color.Beige;
            customButtonClass3.BorderRadius = 35;
            customButtonClass3.BorderSize = 0;
            customButtonClass3.FlatAppearance.BorderSize = 0;
            customButtonClass3.ForeColor = Color.DarkSlateGray;
            customButtonClass3.Name = "customButtonClass3";
            customButtonClass3.TextColor = Color.DarkSlateGray;
            customButtonClass3.UseVisualStyleBackColor = false;
            customButtonClass3.Click += pictureBox2_Click;
            // 
            // FormChangeTimer
            // 
            FormChangeTimer.Interval = 3000;
            FormChangeTimer.Tick += FormChangeTimer_Tick;
            // 
            // FingerprintsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 82, 217);
            Controls.Add(customButtonClass3);
            Controls.Add(customButtonClass2);
            Controls.Add(customButtonClass1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FingerprintsForm";
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
        private System.Windows.Forms.Timer FormChangeTimer;
    }
}