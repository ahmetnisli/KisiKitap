using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiKitap
{
  public  class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public bool VarMi { get; set; }
        public int KisiID { get; private set; }
        public override string ToString()
        {
            return KitapAdi;
        }
    }
}
