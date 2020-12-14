
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class Tecnico
    {
        public Tecnico()
        {
            Casos = new HashSet<Casos>();
        }

        public int IdTecnico { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Casos> Casos { get; set; }
    }
}
