using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierSofor.DAL.Model.Entity
{
   public class Sofor
    {

        public int SoforID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Plaka { get; set; }

        public int Puan { get; set; }
    }
}
