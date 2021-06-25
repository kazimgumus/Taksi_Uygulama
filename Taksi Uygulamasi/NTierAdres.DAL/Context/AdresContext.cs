using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NTierAdres.DAL.Model.Entity;

namespace NTierAdres.DAL.Context
{
    public class AdresContext:DBContext

    {

        public AdresContext()
        {
            Database.Connection.ConnectionString )= "server=.;database=AdresDB;uid=kazim;pwd=123;";
        }
        public DbSet<Adres> Adress { get; set; }

    }
}
