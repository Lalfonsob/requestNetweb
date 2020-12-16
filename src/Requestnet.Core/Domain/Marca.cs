using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class Marca
    {
        public Marca()
        {
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdMarca { get; set; }
        public string nom_marca { get; set; }

        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
