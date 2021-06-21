using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierKayit.DAL.Context;

namespace NTierKayit.BLL.Service
{
    public class KayitService
    {

        KayitContext context = new KayitContext();

        public List<Kayit> GetKayits ()
        {
            return context.Kayit.ToList();
        }




    }
}
