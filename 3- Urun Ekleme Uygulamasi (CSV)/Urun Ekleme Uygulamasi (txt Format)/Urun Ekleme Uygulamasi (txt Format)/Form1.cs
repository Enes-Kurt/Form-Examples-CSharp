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
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            yonetici.UrunAra(urunler, this);
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            yonetici.ListedenSil(urunler, this);
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            yonetici.ListeyeEkle(urunler, this);
        }
    }
}