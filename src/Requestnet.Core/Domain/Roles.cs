using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int? IdEstadoru { get; set; }

        public virtual EstadosRu IdEstadoruNavigation { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
