
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class InventarioEquipos
    {
        public int IdEquipo { get; set; }
        public int? IdEstadoeq { get; set; }
        public string Serial { get; set; }
        public int? IdCliente { get; set; }
        public int? IdTipoComponente { get; set; }
        public int? IdMarca { get; set; }
        public int? IdTipoProcedencia { get; set; }
        public int? IdJefe { get; set; }
        public int? IdLider { get; set; }

        public virtual IntegranteColaborador IdClienteNavigation { get; set; }
        public virtual EstadoEq IdEstadoeqNavigation { get; set; }
        public virtual Jefeinfraestructura IdJefeNavigation { get; set; }
        public virtual Liderinventario IdLiderNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual TipoComponente IdTipoComponenteNavigation { get; set; }
        public virtual TipoProcedencia IdTipoProcedenciaNavigation { get; set; }
    }
}
