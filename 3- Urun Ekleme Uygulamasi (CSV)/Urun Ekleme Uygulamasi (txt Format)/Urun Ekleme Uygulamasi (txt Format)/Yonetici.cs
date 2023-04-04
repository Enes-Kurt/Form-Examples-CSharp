using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYılmazHoca
{
    public class Yonetici
    {
       
        public void DosyadanOku (List<Urun> urunler,Form1 form)
        {
            StreamReader sr = new StreamReader(@"C:\Users\enesk\OneDrive\Desktop\GitHub Repo\Form\3- Urun Ekleme Uygulamasi (CSV)\Urun Ekleme Uygulamasi (txt Format)\Urun Ekleme Uygulamasi (txt Format)\Urun Ekleme Uygulamasi (txt Format)\urunler.csv");
            string[] bilgiler;
            string str = sr.ReadToEnd();
            if (str != "")
            {
                str = str.Remove(str.Length - 1);
                bilgiler = str.Split(',');

                int count = 0;
                for (int i = 0; i < bilgiler.Length / 4; i++)
                {
                    Urun urun = new Urun();
                    urun.UrunID = bilgiler[count++];
                    urun.UrunAdi = bilgiler[count++];
                    urun.Fiyat = bilgiler[count++];
                    urun.Kategori = bilgiler[count++];
                    urunler.Add(urun);
                }
                form.dbvUrunler.DataSource = urunler;
            }
            sr.Close();
        }
        public void DosyayaKaydet(List<Urun> urunler)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\enesk\OneDrive\Desktop\GitHub Repo\Form\3- Urun Ekleme Uygulamasi (CSV)\Urun Ekleme Uygulamasi (txt Format)\Urun Ekleme Uygulamasi (txt Format)\Urun Ekleme Uygulamasi (txt Format)\urunler.csv");
            foreach (Urun urun in urunler)
            {
                sw.Write(urun.UrunID + ",");
                sw.Write(urun.UrunAdi + ",");
                sw.Write(urun.Fiyat + ",");
                sw.Write(urun.Kategori + ",");
            }
            sw.Close();
        }
        public void ListeyeEkle(List<Urun> urunler, Form1 form)
        {
            Urun urun = new Urun();
            bool control = true;
            foreach (var item in urunler)
            {
                if (item.UrunID == form.txtUrunID.Text)
                {
                    control = false;
                    break;
                }
            }
            if (form.txtUrunID.Text != "" && form.txtUrunAdi.Text != "" && form.txtFiyat.Text != "" && form.txtKategori.Text != "" && control)
            {
                try
                {
                    urun.UrunID = form.txtUrunID.Text;
                    urun.UrunAdi = form.txtUrunAdi.Text;
                    urun.Fiyat = form.txtFiyat.Text;
                    urun.Kategori = form.txtKategori.Text;
                    urunler.Add(urun);
                    /* alternarif yöntem
                     
                     str += urun.UrunID + "," + urun.UrunAdi + "," + urun.Fiyat + "," + urun.Kategori + ",";

                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            form.dbvUrunler.DataSource = null;
            form.dbvUrunler.DataSource = urunler;
        }
        public void ListedenSil(List<Urun> urunler, Form1 form)
        {
            DialogResult dialogResult = MessageBox.Show("Gerçekten bunu ürünü silmek istiyor musunuz?", "Önemli", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                form.dbvUrunler.DataSource = null;
                for (int i = 0; i < urunler.Count; i++)
                {
                    if (urunler[i].UrunID == form.txtUrunID.Text)
                    {
                        urunler.Remove(urunler[i]);
                    }
                }
                form.dbvUrunler.DataSource = urunler;
                form.dbvUrunler.Refresh();
                MessageBox.Show("Ürün listenizden silindi.\n NOT: Kalıcı olarak silmek için dosyayı kaydetmeyi unutmayın!");
            }


            /* alternatif yöntem
                    

            int urunStartPoint = 0;
            int urunLength = 0;
            str = "," + str;
            str += ",";
            foreach (var item in urunler)
            {
                if (item.UrunID == txtUrunID.Text)
                {
                    urunStartPoint = str.IndexOf(","+item.UrunID+",")+1;
                    urunLength = item.UrunID.Length + item.UrunAdi.Length + item.Fiyat.Length + item.Kategori.Length + 4;
                    break;
                }
            }
            if (urunStartPoint + urunLength <= str.Length)
                str = str.Remove(urunStartPoint, urunLength);
            else
                str = str.Remove(urunStartPoint, urunLength - 1);
            str = str.Substring(1, str.Length - 1);
            bilgiler = str.Split(',');
            urunler = new List<Urun>();
            int count = 0;
            for (int i = 0; i < bilgiler.Length / 4; i++)
            {
                Urun urun = new Urun();
                urun.UrunID = bilgiler[count++];
                urun.UrunAdi = bilgiler[count++];
                urun.Fiyat = bilgiler[count++];
                urun.Kategori = bilgiler[count++];
                urunler.Add(urun);
            }
            dbvUrunler.DataSource = urunler;
            dbvUrunler.Refresh();

            */
        }

        public void UrunAra(List<Urun> urunler, Form1 form)
        {
            foreach (var urun in urunler)
            {
                if (urun.UrunID == form.txtUrunID.Text)
                {
                    form.txtUrunAdi.Text = urun.UrunAdi;
                    form.txtFiyat.Text = urun.Fiyat;
                    form.txtKategori.Text = urun.Kategori;
                }
            }
        }
    }
}
