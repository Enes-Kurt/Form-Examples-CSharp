namespace Enes_Kurt_Ödev___10._03._2023
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
            lstSifreler = new ListBox();
            chcBuyukHarf = new CheckBox();
            chcKucukHarf = new CheckBox();
            chcRakam = new CheckBox();
            chcOzelKarakter = new CheckBox();
            numSifreUzunkluk = new NumericUpDown();
            numSifreSayısı = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnOlustur = new Button();
            ((System.ComponentModel.ISupportInitialize)numSifreUzunkluk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSifreSayısı).BeginInit();
            SuspendLayout();
            // 
            // lstSifreler
            // 
            lstSifreler.FormattingEnabled = true;
            lstSifreler.ItemHeight = 15;
            lstSifreler.Location = new Point(391, 38);
            lstSifreler.Name = "lstSifreler";
            lstSifreler.Size = new Size(358, 334);
            lstSifreler.TabIndex = 0;
            // 
            // chcBuyukHarf
            // 
            chcBuyukHarf.AutoSize = true;
            chcBuyukHarf.Location = new Point(75, 64);
            chcBuyukHarf.Name = "chcBuyukHarf";
            chcBuyukHarf.Size = new Size(85, 19);
            chcBuyukHarf.TabIndex = 1;
            chcBuyukHarf.Text = "Büyük Harf";
            chcBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chcKucukHarf
            // 
            chcKucukHarf.AutoSize = true;
            chcKucukHarf.Location = new Point(75, 113);
            chcKucukHarf.Name = "chcKucukHarf";
            chcKucukHarf.Size = new Size(85, 19);
            chcKucukHarf.TabIndex = 2;
            chcKucukHarf.Text = "Küçük Harf";
            chcKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chcRakam
            // 
            chcRakam.AutoSize = true;
            chcRakam.Location = new Point(75, 159);
            chcRakam.Name = "chcRakam";
            chcRakam.Size = new Size(62, 19);
            chcRakam.TabIndex = 3;
            chcRakam.Text = "Rakam";
            chcRakam.UseVisualStyleBackColor = true;
            // 
            // chcOzelKarakter
            // 
            chcOzelKarakter.AutoSize = true;
            chcOzelKarakter.Location = new Point(75, 205);
            chcOzelKarakter.Name = "chcOzelKarakter";
            chcOzelKarakter.Size = new Size(95, 19);
            chcOzelKarakter.TabIndex = 4;
            chcOzelKarakter.Text = "Özel Karakter";
            chcOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // numSifreUzunkluk
            // 
            numSifreUzunkluk.Location = new Point(129, 277);
            numSifreUzunkluk.Name = "numSifreUzunkluk";
            numSifreUzunkluk.Size = new Size(201, 23);
            numSifreUzunkluk.TabIndex = 5;
            // 
            // numSifreSayısı
            // 
            numSifreSayısı.Location = new Point(129, 328);
            numSifreSayısı.Name = "numSifreSayısı";
            numSifreSayısı.Size = new Size(201, 23);
            numSifreSayısı.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 279);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 7;
            label1.Text = "Şifre Uzunluğu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 330);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Şifre Sayısı";
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(156, 378);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(136, 44);
            btnOlustur.TabIndex = 9;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOlustur);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numSifreSayısı);
            Controls.Add(numSifreUzunkluk);
            Controls.Add(chcOzelKarakter);
            Controls.Add(chcRakam);
            Controls.Add(chcKucukHarf);
            Controls.Add(chcBuyukHarf);
            Controls.Add(lstSifreler);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSifreUzunkluk).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSifreSayısı).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSifreler;
        private CheckBox chcBuyukHarf;
        private CheckBox chcKucukHarf;
        private CheckBox chcRakam;
        private CheckBox chcOzelKarakter;
        private NumericUpDown numSifreUzunkluk;
        private NumericUpDown numSifreSayısı;
        private Label label1;
        private Label label2;
        private Button btnOlustur;
    }
}