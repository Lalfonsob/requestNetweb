using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Orden = new HashSet<Orden>();
        }

        public int IdProveedor { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
