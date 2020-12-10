using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Jefeinfraestructura
    {
        public Jefeinfraestructura()
        {
            Casos = new HashSet<Casos>();
            InventarioEquipos = new HashSet<InventarioEquipos>();
            Orden = new HashSet<Orden>();
        }

        public int IdJefe { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Casos> Casos { get; set; }
        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
