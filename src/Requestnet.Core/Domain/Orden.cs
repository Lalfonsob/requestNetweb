using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Orden
    {
        public Orden()
        {
            TipoProcedencia = new HashSet<TipoProcedencia>();
        }

        public int IdOrden { get; set; }
        public string Descripcion { get; set; }
        public byte[] AdjuntarArchivo { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string Solucion { get; set; }
        public DateTime? FechaSolucion { get; set; }
        public string Notas { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdLider { get; set; }
        public int? IdJefe { get; set; }
        public int? IdTipoOrden { get; set; }
        public int? IdEstado { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual Jefeinfraestructura IdJefeNavigation { get; set; }
        public virtual Liderinventario IdLiderNavigation { get; set; }
        public virtual Proveedores IdProveedorNavigation { get; set; }
        public virtual TipoOrden IdTipoOrdenNavigation { get; set; }
        public virtual ICollection<TipoProcedencia> TipoProcedencia { get; set; }
    }
}
