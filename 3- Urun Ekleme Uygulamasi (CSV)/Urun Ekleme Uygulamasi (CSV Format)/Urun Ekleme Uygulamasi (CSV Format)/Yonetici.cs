using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYılmazHoca
{
    internal class Yonetici
    {
        public void DosyadanOku(List<Urun> urunler , Form1 form)
        {
            StreamReader sr = new StreamReader(@"C:\Users\enesk\OneDrive\Desktop\GitHub Repo\Form\3- Urun Ekleme Uygulamasi (CSV)\Urun Ekleme Uygulamasi (CSV Format)\Urun Ekleme Uygulamasi (CSV Format)\urunler.csv");
            CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);

            csvReader.Context.RegisterClassMap<UrunMap>();
            var record = csvReader.GetRecords<Urun>();

            foreach (var item in record)
            {
                urunler.Add(item);
            }
            form.dbvUrunler.DataSource = urunler;
            sr.Close();
        }

        public void DosyayaKaydet(List<Urun> urunler)
        {
            Urun urun = new Urun();
            StreamWriter sw = new StreamWriter(@"C:\Users\enesk\OneDrive\Desktop\GitHub Repo\Form\3- Urun Ekleme Uygulamasi (CSV)\Urun Ekleme Uygulamasi (CSV Format)\Urun Ekleme Uygulamasi (CSV Format)\urunler.csv");
            CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
            csvWriter.WriteField("UrunID");
            csvWriter.WriteField("UrunAdi");
            csvWriter.WriteField("Fiyat");
            csvWriter.WriteField("Kategori");
            csvWriter.NextRecord();
            foreach (var item in urunler)
            {
                csvWriter.WriteField(item.UrunID);
                csvWriter.WriteField(item.UrunAdi);
                csvWriter.WriteField(item.Fiyat);
                csvWriter.WriteField(item.Kategori);
                csvWriter.NextRecord();
            }
            sw.Close();
        }

        public void UrunAra(List<Urun> urunler , Form1 form)
        {
            bool control = false;
            foreach (var item in urunler)
            {
                if (form.txtUrunID.Text == item.UrunID)
                {
                    control = true;
                    form.txtUrunAdi.Text = item.UrunAdi;
                    form.txtFiyat.Text = item.Fiyat;
                    form.txtKategori.Text = item.Kategori;

                }
            }
            if (control == false)
            {
                MessageBox.Show("Ürün listede yok!!");
                form.txtFiyat.Text = null;
                form.txtUrunAdi.Text = null;
                form.txtKategori.Text = null;
            }
        }

        public void UrunSil(List<Urun> urunler, Form1 form)
        {
            for (int i = 0; i < urunler.Count; i++)
            {
                if (urunler[i].UrunID == form.txtUrunID.Text && urunler[i].UrunAdi == form.txtUrunAdi.Text && urunler[i].Fiyat == form.txtFiyat.Text && urunler[i].Kategori == form.txtKategori.Text)
                    urunler.Remove(urunler[i]);
            }

            form.dbvUrunler.DataSource = null;
            form.dbvUrunler.DataSource = urunler;
        }

        public void UrunEkle(List<Urun> urunler, Form1 form)
        {
            Urun urun = new Urun();
            bool control = true;
            foreach (var item in urunler)
            {
                if (item.UrunID == form.txtUrunID.Text)
                    control = false;
            }
            if (form.txtUrunID.Text != "" && form.txtKategori.Text != "" && form.txtFiyat.Text != "" && form.txtUrunAdi.Text != "" && control)
            {
                urun.UrunID = form.txtUrunID.Text;
                urun.UrunAdi = form.txtUrunAdi.Text;
                urun.Fiyat = form.txtFiyat.Text;
                urun.Kategori = form.txtKategori.Text;
                urunler.Add(urun);
            }
            form.dbvUrunler.DataSource = null;
            form.dbvUrunler.DataSource = urunler;
        }



    }
}
