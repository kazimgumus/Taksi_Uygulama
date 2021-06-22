using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniKayit.DAL.Migrations


internal sealed class Configurations :
    System.Data.Entity.Migrations.DbMigrationsConfiguration<NtierSofor.DAL.Context.SoforContext>

{
    public Configurations()
    {
        AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(NtierSofor.DAL.Context.SoforContext context)
}


