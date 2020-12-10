using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class TipoComponente
    {
        public TipoComponente()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdTipoComponente { get; set; }
        public int? Cantidad { get; set; }

        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
