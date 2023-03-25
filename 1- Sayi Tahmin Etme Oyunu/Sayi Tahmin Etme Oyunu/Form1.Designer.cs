namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnTahmin = new Button();
            label1 = new Label();
            lblIpucu = new Label();
            lblBilgi = new Label();
            numSayi = new NumericUpDown();
            btnBaslat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numSayi).BeginInit();
            SuspendLayout();
            // 
            // btnTahmin
            // 
            btnTahmin.Enabled = false;
            btnTahmin.Location = new Point(329, 158);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(185, 38);
            btnTahmin.TabIndex = 0;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Bir sayı giriniz: ";
            // 
            // lblIpucu
            // 
            lblIpucu.BackColor = SystemColors.ActiveCaption;
            lblIpucu.Location = new Point(231, 223);
            lblIpucu.Name = "lblIpucu";
            lblIpucu.Size = new Size(283, 38);
            lblIpucu.TabIndex = 2;
            lblIpucu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBilgi
            // 
            lblBilgi.BackColor = SystemColors.ActiveCaption;
            lblBilgi.Location = new Point(231, 340);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(283, 46);
            lblBilgi.TabIndex = 3;
            lblBilgi.Text = "Kaybedeceksin boşuna oynama!";
            lblBilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSayi
            // 
            numSayi.Location = new Point(329, 117);
            numSayi.Name = "numSayi";
            numSayi.Size = new Size(185, 23);
            numSayi.TabIndex = 4;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(285, 40);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(168, 46);
            btnBaslat.TabIndex = 5;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10000;
            timer2.Tick += timer2_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(233, 276);
            progressBar1.Maximum = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(281, 46);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(btnBaslat);
            Controls.Add(numSayi);
            Controls.Add(lblBilgi);
            Controls.Add(lblIpucu);
            Controls.Add(label1);
            Controls.Add(btnTahmin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSayi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTahmin;
        private Label label1;
        private Label lblIpucu;
        private Label lblBilgi;
        private NumericUpDown numSayi;
        private Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
    }
}