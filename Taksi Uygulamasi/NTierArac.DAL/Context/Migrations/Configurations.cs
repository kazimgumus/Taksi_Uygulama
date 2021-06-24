using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac.DAL.Migrations


internal sealed class Configurations :
    System.Data.Entity.Migrations.DbMigrationsConfiguration<NtierArac.DAL.Context.AracContext>

{
    public Configurations()
    {
        AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(NtierArac.DAL.Context.AracContext context)
}
