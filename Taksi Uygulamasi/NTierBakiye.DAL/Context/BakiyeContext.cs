using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NTierBakiye.DAL.Context
{
   public class BakiyeContext:DbContect

    {
        public BakiyeContext()
        {
            Database.Connetion.ConnectionString.= "server=.;database=BakiyeDB;uid:kazim;pwd=123;";
        }
        public DbSet<NTierBakiye> Bakiye { get; set; }
    }
}
