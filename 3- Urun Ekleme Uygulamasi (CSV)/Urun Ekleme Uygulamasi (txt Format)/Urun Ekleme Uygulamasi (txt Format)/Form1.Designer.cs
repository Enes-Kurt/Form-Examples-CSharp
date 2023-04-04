namespace OdevYılmazHoca
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUrunID = new TextBox();
            txtUrunAdi = new TextBox();
            txtFiyat = new TextBox();
            txtKategori = new TextBox();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            btnDosyayaKaydet = new Button();
            btnAra = new Button();
            dbvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dbvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "ÜrünID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 98);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 151);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 0;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 200);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 0;
            label4.Text = "Kategori";
            // 
            // txtUrunID
            // 
            txtUrunID.Location = new Point(156, 44);
            txtUrunID.Name = "txtUrunID";
            txtUrunID.Size = new Size(191, 27);
            txtUrunID.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(156, 95);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(191, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(156, 143);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(191, 27);
            txtFiyat.TabIndex = 2;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(156, 192);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(191, 27);
            txtKategori.TabIndex = 3;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = SystemColors.ActiveCaption;
            btnUrunEkle.Location = new Point(401, 182);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(131, 42);
            btnUrunEkle.TabIndex = 5;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = SystemColors.ActiveCaption;
            btnUrunSil.Location = new Point(549, 182);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(128, 42);
            btnUrunSil.TabIndex = 6;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnDosyayaKaydet
            // 
            btnDosyayaKaydet.BackColor = SystemColors.ActiveCaption;
            btnDosyayaKaydet.Location = new Point(718, 143);
            btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            btnDosyayaKaydet.Size = new Size(106, 81);
            btnDosyayaKaydet.TabIndex = 7;
            btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            btnDosyayaKaydet.UseVisualStyleBackColor = false;
            btnDosyayaKaydet.Click += btnDosyayaKaydet_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = SystemColors.ActiveCaption;
            btnAra.Location = new Point(401, 34);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(131, 42);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // dbvUrunler
            // 
            dbvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbvUrunler.Location = new Point(66, 259);
            dbvUrunler.Name = "dbvUrunler";
            dbvUrunler.RowHeadersWidth = 51;
            dbvUrunler.RowTemplate.Height = 29;
            dbvUrunler.Size = new Size(758, 354);
            dbvUrunler.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 645);
            Controls.Add(dbvUrunler);
            Controls.Add(btnDosyayaKaydet);
            Controls.Add(btnUrunSil);
            Controls.Add(btnAra);
            Controls.Add(btnUrunEkle);
            Controls.Add(txtKategori);
            Controls.Add(txtFiyat);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtUrunID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dbvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public TextBox txtUrunID;
        public TextBox txtUrunAdi;
        public TextBox txtFiyat;
        public TextBox txtKategori;
        public Button btnUrunEkle;
        public Button btnUrunSil;
        public Button btnDosyayaKaydet;
        public Button btnAra;
        public DataGridView dbvUrunler;
    }
}