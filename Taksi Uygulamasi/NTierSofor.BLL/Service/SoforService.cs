using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtierSofor.DAL.Model.Entity;
using NTierSofor.DAL.Context;

namespace NTierSofor.BLL.Service
{
    public class SoforService
    {
        SoforContext context = new SoforContext();

        public List<Sofor> Sofors
        {
            get
            {
                return context.Soforler.ToList();
            }
        }
    }
}
