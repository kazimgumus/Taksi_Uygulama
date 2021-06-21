using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YeniKayit.DAL.Model.Entity;

namespace YeniKayit.DAL.Context
{
   public class KayitContext:DbContext
    {
        public KayitContext()

        {
            Database.Connection.ConnectionString =
                "server=.;database=KayitDB;uid=kazim;pwd=123;";
        }


        public DbSet<Kayit> Kayitlar { get; set; }


    }
}
