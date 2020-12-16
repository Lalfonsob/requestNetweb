using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class TipoCaso
    {
        public TipoCaso()
        {
            Casos = new HashSet<Casos>();
        }

        public int IdTipoCaso { get; set; }
        public string nom_tipo_caso { get; set; }

        public virtual ICollection<Casos> Casos { get; set; }
    }
}
