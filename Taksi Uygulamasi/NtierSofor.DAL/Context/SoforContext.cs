using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NtierSofor.DAL.Context
{
    public class SoforContext : DbContext
    {

        public SoforContext()

        {
            Database.Connection.ConnectionString =
                "server=.;database=KayitDB;uid=kazim;pwd=123;";
        }


        public DbSet<Sofor> Soforler { get; set; }

    }
}
