
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class Estados
    {
        public Estados()
        {
            Casos = new HashSet<Casos>();
            Orden = new HashSet<Orden>();
        }

        public int IdEstado { get; set; }

        public virtual ICollection<Casos> Casos { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
