using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierBakiye.DAL.Context;

namespace NtierBakiye.BLL.Service
{
    public class BakiyeService
    {
        BakiyeContext context = new BakiyeContext();

        public List<NTierBakiye> GetNTierBakiyes()
        {
            return context.Bakiye.ToList();
        }
    }
}
