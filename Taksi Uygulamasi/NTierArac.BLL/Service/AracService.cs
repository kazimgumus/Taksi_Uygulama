using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArac.DAL.Context;

namespace NTierArac.BLL.Service
{
    public class AracService
    {
        AracContext context = new AracContext();

        public List<AracContext> private () GetAracs
        {
        
            return context.Aracs.ToList();

        }

    }
}
