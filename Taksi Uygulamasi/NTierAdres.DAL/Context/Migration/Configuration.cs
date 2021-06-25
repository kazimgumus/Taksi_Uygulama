using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adres.DAL.Migrations


internal sealed class Configurations :
    System.Data.Entity.Migrations.DbMigrationsConfiguration<NtierAdres.DAL.Context.AdresContext>

{
    public Configurations()
    {
        AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(NtierAdres.DAL.Context.AdresContext context)
}
