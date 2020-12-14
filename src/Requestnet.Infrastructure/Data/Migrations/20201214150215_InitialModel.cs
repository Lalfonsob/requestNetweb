using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Requestnet.Infrastructure.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ciudades",
                columns: table => new
                {
                    id_ciudad = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_ciudad);
                });

            migrationBuilder.CreateTable(
                name: "estado_eq",
                columns: table => new
                {
                    id_estadoeq = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_estadoeq);
                });

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    id_estado = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "estados_ru",
                columns: table => new
                {
                    id_estadoru = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_estadoru);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    id_marca = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_marca);
                });

            migrationBuilder.CreateTable(
                name: "tipo_caso",
                columns: table => new
                {
                    id_tipo_caso = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipo_caso);
                });

            migrationBuilder.CreateTable(
                name: "tipo_componente",
                columns: table => new
                {
                    id_tipo_componente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    cantidad = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipo_componente);
                });

            migrationBuilder.CreateTable(
                name: "tipo_doc",
                columns: table => new
                {
                    id_tipdoc = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipdoc);
                });

            migrationBuilder.CreateTable(
                name: "tipo_orden",
                columns: table => new
                {
                    id_tipo_orden = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipo_orden);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id_rol = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre_rol = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "'NULL'"),
                    id_estadoru = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_rol);
                    table.ForeignKey(
                        name: "roles_ibfk_1",
                        column: x => x.id_estadoru,
                        principalTable: "estados_ru",
                        principalColumn: "id_estadoru",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_tipdoc = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    num_documento = table.Column<int>(type: "int(11)", nullable: false),
                    nombres = table.Column<string>(maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    telefono = table.Column<long>(type: "bigint(20)", nullable: false),
                    correo = table.Column<string>(maxLength: 70, nullable: false),
                    id_ciudad = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    direccion = table.Column<string>(maxLength: 50, nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "'NULL'"),
                    fecha_ingreso_com = table.Column<DateTime>(type: "date", nullable: false),
                    cargo = table.Column<string>(maxLength: 55, nullable: false),
                    id_rol = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    contraseña = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'NULL'"),
                    id_estadoru = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_usuario);
                    table.ForeignKey(
                        name: "usuarios_ibfk_3",
                        column: x => x.id_ciudad,
                        principalTable: "ciudades",
                        principalColumn: "id_ciudad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuarios_ibfk_4",
                        column: x => x.id_estadoru,
                        principalTable: "estados_ru",
                        principalColumn: "id_estadoru",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuarios_ibfk_1",
                        column: x => x.id_rol,
                        principalTable: "roles",
                        principalColumn: "id_rol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuarios_ibfk_2",
                        column: x => x.id_tipdoc,
                        principalTable: "tipo_doc",
                        principalColumn: "id_tipdoc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "integrante_colaborador",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_cliente);
                    table.ForeignKey(
                        name: "integrante_colaborador_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jefeinfraestructura",
                columns: table => new
                {
                    id_jefe = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_jefe);
                    table.ForeignKey(
                        name: "jefeinfraestructura_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "liderinventario",
                columns: table => new
                {
                    id_lider = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_lider);
                    table.ForeignKey(
                        name: "liderinventario_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id_proveedor = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_proveedor);
                    table.ForeignKey(
                        name: "proveedores_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tecnico",
                columns: table => new
                {
                    id_tecnico = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tecnico);
                    table.ForeignKey(
                        name: "tecnico_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orden",
                columns: table => new
                {
                    id_orden = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(nullable: false),
                    adjuntar_archivo = table.Column<byte[]>(type: "blob", nullable: true, defaultValueSql: "'NULL'"),
                    fecha_aprobacion = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "'NULL'"),
                    solucion = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
                    fecha_solucion = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "'NULL'"),
                    notas = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
                    id_proveedor = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_lider = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_jefe = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_tipo_orden = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_estado = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_orden);
                    table.ForeignKey(
                        name: "orden_ibfk_5",
                        column: x => x.id_estado,
                        principalTable: "estados",
                        principalColumn: "id_estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "orden_ibfk_3",
                        column: x => x.id_jefe,
                        principalTable: "jefeinfraestructura",
                        principalColumn: "id_jefe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "orden_ibfk_2",
                        column: x => x.id_lider,
                        principalTable: "liderinventario",
                        principalColumn: "id_lider",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "orden_ibfk_1",
                        column: x => x.id_proveedor,
                        principalTable: "proveedores",
                        principalColumn: "id_proveedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "orden_ibfk_4",
                        column: x => x.id_tipo_orden,
                        principalTable: "tipo_orden",
                        principalColumn: "id_tipo_orden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "casos",
                columns: table => new
                {
                    id_caso = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion = table.Column<DateTime>(type: "date", nullable: false),
                    descripcion = table.Column<string>(nullable: false),
                    solucion = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
                    fecha_sol = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "'NULL'"),
                    notas = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
                    id_tipo_caso = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_tecnico = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_jefe = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_lider = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_estado = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_cliente = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_caso);
                    table.ForeignKey(
                        name: "fk_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "integrante_colaborador",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "casos_ibfk_5",
                        column: x => x.id_estado,
                        principalTable: "estados",
                        principalColumn: "id_estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "casos_ibfk_3",
                        column: x => x.id_jefe,
                        principalTable: "jefeinfraestructura",
                        principalColumn: "id_jefe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "casos_ibfk_4",
                        column: x => x.id_lider,
                        principalTable: "liderinventario",
                        principalColumn: "id_lider",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "casos_ibfk_2",
                        column: x => x.id_tecnico,
                        principalTable: "tecnico",
                        principalColumn: "id_tecnico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "casos_ibfk_1",
                        column: x => x.id_tipo_caso,
                        principalTable: "tipo_caso",
                        principalColumn: "id_tipo_caso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tipo_procedencia",
                columns: table => new
                {
                    id_tipo_procedencia = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_orden = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipo_procedencia);
                    table.ForeignKey(
                        name: "tipo_procedencia_ibfk_1",
                        column: x => x.id_orden,
                        principalTable: "orden",
                        principalColumn: "id_orden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inventario_equipos",
                columns: table => new
                {
                    id_equipo = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_estadoeq = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    serial = table.Column<string>(maxLength: 40, nullable: false),
                    id_cliente = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_tipo_componente = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_marca = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_tipo_procedencia = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_jefe = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    id_lider = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_equipo);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_1",
                        column: x => x.id_cliente,
                        principalTable: "integrante_colaborador",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_7",
                        column: x => x.id_estadoeq,
                        principalTable: "estado_eq",
                        principalColumn: "id_estadoeq",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_5",
                        column: x => x.id_jefe,
                        principalTable: "jefeinfraestructura",
                        principalColumn: "id_jefe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_6",
                        column: x => x.id_lider,
                        principalTable: "liderinventario",
                        principalColumn: "id_lider",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_3",
                        column: x => x.id_marca,
                        principalTable: "marca",
                        principalColumn: "id_marca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_2",
                        column: x => x.id_tipo_componente,
                        principalTable: "tipo_componente",
                        principalColumn: "id_tipo_componente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "inventario_equipos_ibfk_4",
                        column: x => x.id_tipo_procedencia,
                        principalTable: "tipo_procedencia",
                        principalColumn: "id_tipo_procedencia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_id_cliente",
                table: "casos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "id_estado",
                table: "casos",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "id_jefe",
                table: "casos",
                column: "id_jefe");

            migrationBuilder.CreateIndex(
                name: "id_lider",
                table: "casos",
                column: "id_lider");

            migrationBuilder.CreateIndex(
                name: "id_tecnico",
                table: "casos",
                column: "id_tecnico");

            migrationBuilder.CreateIndex(
                name: "id_tipo_caso",
                table: "casos",
                column: "id_tipo_caso");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "integrante_colaborador",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "id_cliente",
                table: "inventario_equipos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "id_estadoeq",
                table: "inventario_equipos",
                column: "id_estadoeq");

            migrationBuilder.CreateIndex(
                name: "id_jefe",
                table: "inventario_equipos",
                column: "id_jefe");

            migrationBuilder.CreateIndex(
                name: "id_lider",
                table: "inventario_equipos",
                column: "id_lider");

            migrationBuilder.CreateIndex(
                name: "id_marca",
                table: "inventario_equipos",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "id_tipo_componente",
                table: "inventario_equipos",
                column: "id_tipo_componente");

            migrationBuilder.CreateIndex(
                name: "id_tipo_procedencia",
                table: "inventario_equipos",
                column: "id_tipo_procedencia");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "jefeinfraestructura",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "liderinventario",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "id_estado",
                table: "orden",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "id_jefe",
                table: "orden",
                column: "id_jefe");

            migrationBuilder.CreateIndex(
                name: "id_lider",
                table: "orden",
                column: "id_lider");

            migrationBuilder.CreateIndex(
                name: "id_proveedor",
                table: "orden",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "id_tipo_orden",
                table: "orden",
                column: "id_tipo_orden");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "proveedores",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "id_estadoru",
                table: "roles",
                column: "id_estadoru");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "tecnico",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "id_orden",
                table: "tipo_procedencia",
                column: "id_orden");

            migrationBuilder.CreateIndex(
                name: "id_ciudad",
                table: "usuarios",
                column: "id_ciudad");

            migrationBuilder.CreateIndex(
                name: "id_estadoru",
                table: "usuarios",
                column: "id_estadoru");

            migrationBuilder.CreateIndex(
                name: "id_rol",
                table: "usuarios",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "id_tipdoc",
                table: "usuarios",
                column: "id_tipdoc");

            migrationBuilder.CreateIndex(
                name: "num_documento",
                table: "usuarios",
                column: "num_documento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "casos");

            migrationBuilder.DropTable(
                name: "inventario_equipos");

            migrationBuilder.DropTable(
                name: "tecnico");

            migrationBuilder.DropTable(
                name: "tipo_caso");

            migrationBuilder.DropTable(
                name: "integrante_colaborador");

            migrationBuilder.DropTable(
                name: "estado_eq");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "tipo_componente");

            migrationBuilder.DropTable(
                name: "tipo_procedencia");

            migrationBuilder.DropTable(
                name: "orden");

            migrationBuilder.DropTable(
                name: "estados");

            migrationBuilder.DropTable(
                name: "jefeinfraestructura");

            migrationBuilder.DropTable(
                name: "liderinventario");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "tipo_orden");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "ciudades");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "tipo_doc");

            migrationBuilder.DropTable(
                name: "estados_ru");
        }
    }
}
