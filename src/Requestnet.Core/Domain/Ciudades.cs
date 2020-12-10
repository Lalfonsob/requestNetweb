using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdCiudad { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
