using System.Collections;

namespace Enes_Kurt_Ödev___10._03._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            lstSifreler.Items.Clear();
            string sifre = "";
            Random rnd = new Random();
            // İstenilen sayıda şifre oluşturma
            for (int k = 0; k < numSifreSayısı.Value; k++)
            {
                // Şifre Oluşturma
                sifre = "";
                for (int i = 0; i < numSifreUzunkluk.Value;)
                {

                    if (chcBuyukHarf.Checked && i < numSifreUzunkluk.Value)
                    {
                        int harfNum = 0;
                        harfNum = rnd.Next(65, 91); // büyük harf
                        sifre += (char)harfNum;
                        i++;
                    }
                    if (chcKucukHarf.Checked && i < numSifreUzunkluk.Value)
                    {
                        int harfNum = 0;
                        harfNum = rnd.Next(97, 123); // küçük harf
                        sifre += (char)harfNum;
                        i++;
                    }
                    if (chcRakam.Checked && i < numSifreUzunkluk.Value)
                    {
                        int harfNum = 0;
                        harfNum = rnd.Next(48, 58); // rakam
                        sifre += (char)harfNum;
                        i++;
                    }
                    if (chcOzelKarakter.Checked && i < numSifreUzunkluk.Value)
                    {
                        int harfNum = 0;
                        harfNum = rnd.Next(33, 48); // özel karakter
                        sifre += (char)harfNum;
                        i++;
                    }
                }

                // Oluşturulan Şifreyi Karıştırma
                char[] charlist = sifre.ToCharArray();
                string newSifre = "";
                int[] numList = new int[sifre.Length];
                for (int i = 0; i < sifre.Length; i++)
                {
                    numList[i] = i;
                }
                while (true)
                {
                    int num = rnd.Next(0, sifre.Length + 1);
                    if (numList.Contains(num))
                    {
                        newSifre += sifre[num];
                        int index = Array.IndexOf(numList, num);
                        numList[index] = -1;

                    }
                    if (numList.Sum() == -1 * numList.Length)
                        break;
                }
                lstSifreler.Items.Add(newSifre);

            }

        }
    }
}