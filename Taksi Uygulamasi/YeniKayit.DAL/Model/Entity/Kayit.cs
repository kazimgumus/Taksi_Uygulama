using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniKayit.DAL.Model.Entity
{
   public class Kayit
    {
        public int KayitID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public string Sifre { get; set; }

    }
}
