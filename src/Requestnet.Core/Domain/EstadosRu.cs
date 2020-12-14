
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class EstadosRu
    {
        public EstadosRu()
        {
            Roles = new HashSet<Roles>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdEstadoru { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
