using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class TipoProcedencia
    {
        public TipoProcedencia()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdTipoProcedencia { get; set; }
        public int? IdOrden { get; set; }

        public virtual Orden IdOrdenNavigation { get; set; }
        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
