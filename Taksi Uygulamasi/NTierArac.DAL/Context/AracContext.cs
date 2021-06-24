using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NTierArac.DAL.Context
{
    public class AracContext : DBContext

    {
        public AracContext() => Database.Connection.ConnectionString = "server=.;database=AracDB;uid=kazim;pwd=123;";
        public DbSet<NTierArac> Aracs { get; set; }

    }
}
