using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class TipoDoc
    {
        public TipoDoc()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipdoc { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
