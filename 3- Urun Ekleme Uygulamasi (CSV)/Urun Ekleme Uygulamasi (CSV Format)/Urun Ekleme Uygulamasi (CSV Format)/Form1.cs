using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace OdevYılmazHoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunler = new List<Urun>();
        Yonetici yonetici = new Yonetici();

        private void Form1_Load(object sender, EventArgs e)
        {
            yonetici.DosyadanOku(urunler, this);
        }

        private void btnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            yonetici.DosyayaKaydet(urunler);
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            yonetici.UrunAra(urunler, this);
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            yonetici.UrunSil(urunler, this);
            Temizle();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            yonetici.UrunEkle(urunler, this);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void Temizle()
        {
            txtFiyat.Text = null;
            txtUrunID.Text = null;
            txtUrunAdi.Text = null;
            txtKategori.Text = null;
        }


    }
}