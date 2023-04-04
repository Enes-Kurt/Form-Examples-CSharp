using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYılmazHoca
{
    public class Urun
    {
        [Index(0)]
        public string UrunID { get; set; }
        [Index(1)]
        public string UrunAdi { get; set; }
        [Index(2)]
        public string Fiyat { get; set; }
        [Index(3)]
        public string Kategori { get; set; }



    }
}
