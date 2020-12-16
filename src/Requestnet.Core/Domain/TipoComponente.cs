using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class TipoComponente
    {
        public TipoComponente()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdTipoComponente { get; set; }
        public int? Cantidad { get; set; }
        public String nom_tipo_componente { get; set; }

        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
