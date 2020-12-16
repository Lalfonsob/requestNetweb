
using System;
using System.Collections.Generic;

namespace Requestnet.Core.Domain
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            IntegranteColaborador = new HashSet<IntegranteColaborador>();
            Jefeinfraestructura = new HashSet<Jefeinfraestructura>();
            Liderinventario = new HashSet<Liderinventario>();
            Proveedores = new HashSet<Proveedores>();
            Tecnico = new HashSet<Tecnico>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipdoc { get; set; }
        public int NumDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }
        public int? IdCiudad { get; set; }
        /*public string nombre_ciu { get; set; }*/
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime FechaIngresoCom { get; set; }
        public string Cargo { get; set; }
        public int? IdRol { get; set; }
        public string Contraseña { get; set; }
        public int? IdEstadoru { get; set; }

        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual EstadosRu IdEstadoruNavigation { get; set; }
        public virtual Roles IdRolNavigation { get; set; }
        public virtual TipoDoc IdTipdocNavigation { get; set; }
        public virtual ICollection<IntegranteColaborador> IntegranteColaborador { get; set; }
        public virtual ICollection<Jefeinfraestructura> Jefeinfraestructura { get; set; }
        public virtual ICollection<Liderinventario> Liderinventario { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<Tecnico> Tecnico { get; set; }
    }
}
