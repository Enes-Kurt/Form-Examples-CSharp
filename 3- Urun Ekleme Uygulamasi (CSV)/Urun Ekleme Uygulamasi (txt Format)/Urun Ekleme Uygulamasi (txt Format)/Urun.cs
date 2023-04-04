using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYılmazHoca
{
    public class Urun
    {

        private string urunID;

        public string UrunID
        {
            get { return urunID; }
            set 
            {
                if (value.All(char.IsDigit))
                {
                    urunID = value;
                }
                else
                    throw new Exception("UrunID sadece sayılardan oluşmalıdır.");
            }
        }

        public string UrunAdi { get; set; }


        private string fiyat;

        public string Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value.All(char.IsDigit))
                {      
                    fiyat = value;
                }
                else
                    throw new Exception("Fiyat sadece sayılardan oluşmalıdır.");
            }
        }

        public string Kategori { get; set; }



    }
}
