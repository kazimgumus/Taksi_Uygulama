using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierAdres.DAL.Context;

namespace NTierAdres.BLL.Service
{
    public class AdresService
    {
        AdresContext context = new AdresContext();

        public List<NTierAdres> GetAdres()
        {
            return context.Adress.ToList();
        }
    }
}
