using System;
using System.Collections.Generic;

namespace Requestnet.Infrastructure
{
    public partial class Casos
    {
        public int IdCaso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public string Solucion { get; set; }
        public DateTime? FechaSol { get; set; }
        public string Notas { get; set; }
        public int? IdTipoCaso { get; set; }
        public int? IdTecnico { get; set; }
        public int? IdJefe { get; set; }
        public int? IdLider { get; set; }
        public int? IdEstado { get; set; }
        public int IdCliente { get; set; }

        public virtual IntegranteColaborador IdClienteNavigation { get; set; }
        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual Jefeinfraestructura IdJefeNavigation { get; set; }
        public virtual Liderinventario IdLiderNavigation { get; set; }
        public virtual Tecnico IdTecnicoNavigation { get; set; }
        public virtual TipoCaso IdTipoCasoNavigation { get; set; }
    }
}
