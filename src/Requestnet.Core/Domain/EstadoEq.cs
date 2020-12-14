
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class EstadoEq
    {
        public EstadoEq()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdEstadoeq { get; set; }

        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
