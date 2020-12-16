using Microsoft.EntityFrameworkCore;
using Requestnet.Core.Domain;

namespace Requestnet.Infrastructure.Data
{
    public partial class RequestnetDbContext : DbContext
    {
        public RequestnetDbContext()
        {
        }

        public RequestnetDbContext(DbContextOptions<RequestnetDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Casos> Casos { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<EstadoEq> EstadoEq { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstadosRu> EstadosRu { get; set; }
        public virtual DbSet<IntegranteColaborador> IntegranteColaborador { get; set; }
        public virtual DbSet<InventarioEquipos> InventarioEquipos { get; set; }
        public virtual DbSet<Jefeinfraestructura> Jefeinfraestructura { get; set; }
        public virtual DbSet<Liderinventario> Liderinventario { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<TipoCaso> TipoCaso { get; set; }
        public virtual DbSet<TipoComponente> TipoComponente { get; set; }
        public virtual DbSet<TipoDoc> TipoDoc { get; set; }
        public virtual DbSet<TipoOrden> TipoOrden { get; set; }
        public virtual DbSet<TipoProcedencia> TipoProcedencia { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       /*     if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=requestnetweb;server=localhost;port=3306;user id=admin;password=123456");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Casos>(entity =>
            {
                entity.HasKey(e => e.IdCaso)
                    .HasName("PRIMARY");

                entity.ToTable("casos");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_id_cliente");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("id_estado");

                entity.HasIndex(e => e.IdJefe)
                    .HasName("id_jefe");

                entity.HasIndex(e => e.IdLider)
                    .HasName("id_lider");

                entity.HasIndex(e => e.IdTecnico)
                    .HasName("id_tecnico");

                entity.HasIndex(e => e.IdTipoCaso)
                    .HasName("id_tipo_caso");

                entity.Property(e => e.IdCaso)
                    .HasColumnName("id_caso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaSol)
                    .HasColumnName("fecha_sol")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("id_estado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdJefe)
                    .HasColumnName("id_jefe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdLider)
                    .HasColumnName("id_lider")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTecnico)
                    .HasColumnName("id_tecnico")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipoCaso)
                    .HasColumnName("id_tipo_caso")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Solucion)
                    .HasColumnName("solucion")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_cliente");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("casos_ibfk_5");

                entity.HasOne(d => d.IdJefeNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdJefe)
                    .HasConstraintName("casos_ibfk_3");

                entity.HasOne(d => d.IdLiderNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdLider)
                    .HasConstraintName("casos_ibfk_4");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("casos_ibfk_2");

                entity.HasOne(d => d.IdTipoCasoNavigation)
                    .WithMany(p => p.Casos)
                    .HasForeignKey(d => d.IdTipoCaso)
                    .HasConstraintName("casos_ibfk_1");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PRIMARY");

                entity.ToTable("ciudades");

                entity.Property(e => e.IdCiudad)
                    .HasColumnName("id_ciudad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nombre_ciu)
                    .HasColumnName("nombre_ciu")
                    .HasColumnType("string");
            });

            modelBuilder.Entity<EstadoEq>(entity =>
            {
                entity.HasKey(e => e.IdEstadoeq)
                    .HasName("PRIMARY");

                entity.ToTable("estado_eq");

                entity.Property(e => e.IdEstadoeq)
                    .HasColumnName("id_estadoeq")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nom_estadoeq)
                    .HasColumnName("nom_estadoeq")
                    .HasColumnType("string");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("estados");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("id_estado")
                    .HasColumnType("int(11)");    
                
                entity.Property(e => e.nom_estado)
                    .HasColumnName("nom_estado")
                    .HasColumnType("string");

            });

            modelBuilder.Entity<EstadosRu>(entity =>
            {
                entity.HasKey(e => e.IdEstadoru)
                    .HasName("PRIMARY");

                entity.ToTable("estados_ru");

                entity.Property(e => e.IdEstadoru)
                    .HasColumnName("id_estadoru")
                    .HasColumnType("int(11)");


                entity.Property(e => e.nom_estadoru)
                    .HasColumnName("nom_estadoru")
                    .HasColumnType("string");


            });

            modelBuilder.Entity<IntegranteColaborador>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("integrante_colaborador");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.IntegranteColaborador)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("integrante_colaborador_ibfk_1");
            });

            modelBuilder.Entity<InventarioEquipos>(entity =>
            {
                entity.HasKey(e => e.IdEquipo)
                    .HasName("PRIMARY");

                entity.ToTable("inventario_equipos");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdEstadoeq)
                    .HasName("id_estadoeq");

                entity.HasIndex(e => e.IdJefe)
                    .HasName("id_jefe");

                entity.HasIndex(e => e.IdLider)
                    .HasName("id_lider");

                entity.HasIndex(e => e.IdMarca)
                    .HasName("id_marca");

                entity.HasIndex(e => e.IdTipoComponente)
                    .HasName("id_tipo_componente");

                entity.HasIndex(e => e.IdTipoProcedencia)
                    .HasName("id_tipo_procedencia");

                entity.Property(e => e.IdEquipo)
                    .HasColumnName("id_equipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEstadoeq)
                    .HasColumnName("id_estadoeq")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdJefe)
                    .HasColumnName("id_jefe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdLider)
                    .HasColumnName("id_lider")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("id_marca")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipoComponente)
                    .HasColumnName("id_tipo_componente")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipoProcedencia)
                    .HasColumnName("id_tipo_procedencia")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("inventario_equipos_ibfk_1");

                entity.HasOne(d => d.IdEstadoeqNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdEstadoeq)
                    .HasConstraintName("inventario_equipos_ibfk_7");

                entity.HasOne(d => d.IdJefeNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdJefe)
                    .HasConstraintName("inventario_equipos_ibfk_5");

                entity.HasOne(d => d.IdLiderNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdLider)
                    .HasConstraintName("inventario_equipos_ibfk_6");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("inventario_equipos_ibfk_3");

                entity.HasOne(d => d.IdTipoComponenteNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdTipoComponente)
                    .HasConstraintName("inventario_equipos_ibfk_2");

                entity.HasOne(d => d.IdTipoProcedenciaNavigation)
                    .WithMany(p => p.InventarioEquipos)
                    .HasForeignKey(d => d.IdTipoProcedencia)
                    .HasConstraintName("inventario_equipos_ibfk_4");
            });

            modelBuilder.Entity<Jefeinfraestructura>(entity =>
            {
                entity.HasKey(e => e.IdJefe)
                    .HasName("PRIMARY");

                entity.ToTable("jefeinfraestructura");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdJefe)
                    .HasColumnName("id_jefe")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Jefeinfraestructura)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("jefeinfraestructura_ibfk_1");
            });

            modelBuilder.Entity<Liderinventario>(entity =>
            {
                entity.HasKey(e => e.IdLider)
                    .HasName("PRIMARY");

                entity.ToTable("liderinventario");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdLider)
                    .HasColumnName("id_lider")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Liderinventario)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("liderinventario_ibfk_1");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PRIMARY");

                entity.ToTable("marca");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("id_marca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nom_marca)
                    .HasColumnName("nom_marca")
                    .HasColumnType("string");
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasKey(e => e.IdOrden)
                    .HasName("PRIMARY");

                entity.ToTable("orden");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("id_estado");

                entity.HasIndex(e => e.IdJefe)
                    .HasName("id_jefe");

                entity.HasIndex(e => e.IdLider)
                    .HasName("id_lider");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("id_proveedor");

                entity.HasIndex(e => e.IdTipoOrden)
                    .HasName("id_tipo_orden");

                entity.Property(e => e.IdOrden)
                    .HasColumnName("id_orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdjuntarArchivo)
                    .HasColumnName("adjuntar_archivo")
                    .HasColumnType("blob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnName("fecha_aprobacion")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaSolucion)
                    .HasColumnName("fecha_solucion")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("id_estado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdJefe)
                    .HasColumnName("id_jefe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdLider)
                    .HasColumnName("id_lider")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("id_proveedor")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipoOrden)
                    .HasColumnName("id_tipo_orden")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Solucion)
                    .HasColumnName("solucion")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("orden_ibfk_5");

                entity.HasOne(d => d.IdJefeNavigation)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.IdJefe)
                    .HasConstraintName("orden_ibfk_3");

                entity.HasOne(d => d.IdLiderNavigation)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.IdLider)
                    .HasConstraintName("orden_ibfk_2");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("orden_ibfk_1");

                entity.HasOne(d => d.IdTipoOrdenNavigation)
                    .WithMany(p => p.Orden)
                    .HasForeignKey(d => d.IdTipoOrden)
                    .HasConstraintName("orden_ibfk_4");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("proveedores");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("id_proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("proveedores_ibfk_1");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.HasIndex(e => e.IdEstadoru)
                    .HasName("id_estadoru");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstadoru)
                    .HasColumnName("id_estadoru")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreRol)
                    .HasColumnName("nombre_rol")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdEstadoruNavigation)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.IdEstadoru)
                    .HasConstraintName("roles_ibfk_1");
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.IdTecnico)
                    .HasName("PRIMARY");

                entity.ToTable("tecnico");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdTecnico)
                    .HasColumnName("id_tecnico")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Tecnico)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("tecnico_ibfk_1");
            });

            modelBuilder.Entity<TipoCaso>(entity =>
            {
                entity.HasKey(e => e.IdTipoCaso)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_caso");

                entity.Property(e => e.IdTipoCaso)
                    .HasColumnName("id_tipo_caso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nom_tipo_caso)
                    .HasColumnName("nom_tipo_caso")
                    .HasColumnType("string");
            });

            modelBuilder.Entity<TipoComponente>(entity =>
            {
                entity.HasKey(e => e.IdTipoComponente)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_componente");

                entity.Property(e => e.IdTipoComponente)
                    .HasColumnName("id_tipo_componente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nom_tipo_componente)
                     .HasColumnName("nom_tipo_componente")
                     .HasColumnType("string");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

            });

            modelBuilder.Entity<TipoDoc>(entity =>
            {
                entity.HasKey(e => e.IdTipdoc)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_doc");

                entity.Property(e => e.IdTipdoc)
                    .HasColumnName("id_tipdoc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.nombre_tipdoc)
                    .HasColumnName("nombre_tipdoc")
                    .HasColumnType("string");


            });

            modelBuilder.Entity<TipoOrden>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrden)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_orden");

                entity.Property(e => e.IdTipoOrden)
                    .HasColumnName("id_tipo_orden")
                    .HasColumnType("int(11)");      
                

                entity.Property(e => e.nom_tipo_orden)
                    .HasColumnName("nom_tipo_orden")
                    .HasColumnType("string");


            });

            modelBuilder.Entity<TipoProcedencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoProcedencia)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_procedencia");

                entity.HasIndex(e => e.IdOrden)
                    .HasName("id_orden");

                entity.Property(e => e.IdTipoProcedencia)
                    .HasColumnName("id_tipo_procedencia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrden)
                    .HasColumnName("id_orden")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.TipoProcedencia)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("tipo_procedencia_ibfk_1");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdCiudad)
                    .HasName("id_ciudad");  
                
/*                entity.HasIndex(e => e.nombre_ciu)
                    .HasName("nombre_ciu");
*/

                entity.HasIndex(e => e.IdEstadoru)
                    .HasName("id_estadoru");

                entity.HasIndex(e => e.IdRol)
                    .HasName("id_rol");

                entity.HasIndex(e => e.IdTipdoc)
                    .HasName("id_tipdoc");

                entity.HasIndex(e => e.NumDocumento)
                    .HasName("num_documento")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(50);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasColumnName("cargo")
                    .HasMaxLength(55);

                entity.Property(e => e.Contraseña)
                    .HasColumnName("contraseña")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasMaxLength(70);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaIngresoCom)
                    .HasColumnName("fecha_ingreso_com")
                    .HasColumnType("date");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCiudad)
                    .HasColumnName("id_ciudad")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEstadoru)
                    .HasColumnName("id_estadoru")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipdoc)
                    .HasColumnName("id_tipdoc")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("num_documento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("usuarios_ibfk_3");

                entity.HasOne(d => d.IdEstadoruNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstadoru)
                    .HasConstraintName("usuarios_ibfk_4");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("usuarios_ibfk_1");

                entity.HasOne(d => d.IdTipdocNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipdoc)
                    .HasConstraintName("usuarios_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
