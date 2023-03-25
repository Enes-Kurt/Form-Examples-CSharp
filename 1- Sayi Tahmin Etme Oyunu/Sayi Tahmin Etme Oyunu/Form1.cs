using System.Diagnostics.Metrics;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = -1;
        int counter = 60;
        int progressCounter = 0;
        Random rnd = new Random();
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            counter = 60;
            progressCounter = 0;
            progressBar1.Value = 0;
            lblIpucu.Text = "";
            lblBilgi.Text = "Kaybedeceksin boþuna oynama!";
            timer1.Start();
            timer2.Start();
            btnTahmin.Enabled = true;
            num = rnd.Next(0, 101);
            counter--;
            btnBaslat.Enabled = false;
            if (counter == 0) Durdur();
        }

        private void Durdur()
        {
            btnTahmin.Enabled = false;
            timer1.Stop();
            timer2.Stop();
            numSayi.Value = 0;
            btnBaslat.Enabled = true;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(numSayi.Value);
            if (tahmin == num)
            {
                lblIpucu.Text = "KAZANDINIZ!!!";
                lblBilgi.Text = "KAZANDINIZ!!!";
                Durdur();
            }
            else if (num > tahmin) lblIpucu.Text = tahmin + "'den büyük.";
            else if (num < tahmin) lblIpucu.Text = tahmin + "'den küçük.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressCounter < 60)
            {
                btnTahmin.Text = $"Tahmin Et ({counter})";
                progressCounter++;
                progressBar1.Value = progressCounter;
                counter--;
            }
            else
            {
                lblIpucu.Text = "HAHAHA KAYBETTÝN!!!";
                lblBilgi.Text = "HAHAHA KAYBETTÝN!!!";
                Durdur();
            }

        }

        string[] str = { "Kazanamayacaksýn hahaha", "Kaybettin bile", "Boþuna uðraþma", "Süren kalmadý" };
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblBilgi.Text = str[rnd.Next(0, 4)];
        }

    }
}