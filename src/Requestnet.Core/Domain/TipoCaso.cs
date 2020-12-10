using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class TipoCaso
    {
        public TipoCaso()
        {
            Casos = new HashSet<Casos>();
        }

        public int IdTipoCaso { get; set; }

        public virtual ICollection<Casos> Casos { get; set; }
    }
}
