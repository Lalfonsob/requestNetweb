using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class TipoOrden
    {
        public TipoOrden()
        {
            Orden = new HashSet<Orden>();
        }

        public int IdTipoOrden { get; set; }

        public virtual ICollection<Orden> Orden { get; set; }
    }
}
