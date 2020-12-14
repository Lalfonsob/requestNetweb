
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class IntegranteColaborador
    {
        public IntegranteColaborador()
        {
            Casos = new HashSet<Casos>();
            InventarioEquipos = new HashSet<InventarioEquipos>();
        }

        public int IdCliente { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Casos> Casos { get; set; }
        public virtual ICollection<InventarioEquipos> InventarioEquipos { get; set; }
    }
}
