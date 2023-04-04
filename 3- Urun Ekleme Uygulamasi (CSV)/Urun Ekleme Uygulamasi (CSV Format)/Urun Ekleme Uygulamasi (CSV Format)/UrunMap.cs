using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYılmazHoca
{
    public class UrunMap : ClassMap<Urun>
    {
        public UrunMap()
        {
            Map(p => p.UrunID).Index(0);
            Map(p => p.UrunAdi).Index(1);
            Map(p => p.Fiyat).Index(2);
            Map(p => p.Kategori).Index(3);
        }


    }
}
