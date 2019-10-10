using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NatilleraApiDataAccess.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdNatillera",
                table: "Natilleras",
                newName: "NatilleraId");

            migrationBuilder.AddColumn<int>(
                name: "DiasGraciaMora",
                table: "Natilleras",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActualizacionRow",
                table: "Natilleras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacionRow",
                table: "Natilleras",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicioPagoCuota",
                table: "Natilleras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NumeroCuotas",
                table: "Natilleras",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Natilleras",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPago",
                table: "Natilleras",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorCuotaPagar",
                table: "Natilleras",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "ValorMoraDiaFijo",
                table: "Natilleras",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorMoraPagar",
                table: "Natilleras",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "TiposDocumentos",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentos", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    SocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    NumeroDocumento = table.Column<string>(maxLength: 20, nullable: true),
                    Nombres = table.Column<string>(maxLength: 200, nullable: true),
                    Apellidos = table.Column<string>(maxLength: 250, nullable: true),
                    Telefono = table.Column<string>(maxLength: 20, nullable: true),
                    Celular = table.Column<string>(maxLength: 20, nullable: true),
                    Direccion = table.Column<string>(maxLength: 250, nullable: true),
                    CorreoElectronico = table.Column<string>(maxLength: 150, nullable: true),
                    TiposDocumentosTipoDocumentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.SocioId);
                    table.ForeignKey(
                        name: "FK_Socios_TiposDocumentos_TiposDocumentosTipoDocumentoId",
                        column: x => x.TiposDocumentosTipoDocumentoId,
                        principalTable: "TiposDocumentos",
                        principalColumn: "TipoDocumentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActividadesRecaudos",
                columns: table => new
                {
                    ActividadRecaudoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    NatillerasNatilleraId = table.Column<int>(nullable: true),
                    SociosSocioId = table.Column<int>(nullable: true),
                    DescripcionActividad = table.Column<string>(nullable: true),
                    ValorInvertido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorRecaudado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorNetoGanancia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaRealizaActividad = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadesRecaudos", x => x.ActividadRecaudoId);
                    table.ForeignKey(
                        name: "FK_ActividadesRecaudos_Natilleras_NatillerasNatilleraId",
                        column: x => x.NatillerasNatilleraId,
                        principalTable: "Natilleras",
                        principalColumn: "NatilleraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActividadesRecaudos_Socios_SociosSocioId",
                        column: x => x.SociosSocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuotasSocios",
                columns: table => new
                {
                    CuotaSocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    SociosSocioId = table.Column<int>(nullable: true),
                    FechaPagoCuota = table.Column<DateTime>(nullable: false),
                    ValorCuota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorMulta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotalCuota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NatillerasNatilleraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuotasSocios", x => x.CuotaSocioId);
                    table.ForeignKey(
                        name: "FK_CuotasSocios_Natilleras_NatillerasNatilleraId",
                        column: x => x.NatillerasNatilleraId,
                        principalTable: "Natilleras",
                        principalColumn: "NatilleraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuotasSocios_Socios_SociosSocioId",
                        column: x => x.SociosSocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NatilleraSocios",
                columns: table => new
                {
                    NatilleraSocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    NatillerasNatilleraId = table.Column<int>(nullable: true),
                    SociosSocioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatilleraSocios", x => x.NatilleraSocioId);
                    table.ForeignKey(
                        name: "FK_NatilleraSocios_Natilleras_NatillerasNatilleraId",
                        column: x => x.NatillerasNatilleraId,
                        principalTable: "Natilleras",
                        principalColumn: "NatilleraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NatilleraSocios_Socios_SociosSocioId",
                        column: x => x.SociosSocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    SociosSocioId = table.Column<int>(nullable: true),
                    FechaDesembolso = table.Column<DateTime>(nullable: false),
                    ValorCuotasNatillaActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorPrestado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcentajeInteres = table.Column<int>(nullable: false),
                    ResponsablePagoPrestamo = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoId);
                    table.ForeignKey(
                        name: "FK_Prestamos_Socios_SociosSocioId",
                        column: x => x.SociosSocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuotasPrestamos",
                columns: table => new
                {
                    CuotaPrestamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FechaCreacionRow = table.Column<DateTime>(nullable: false),
                    FechaActualizacionRow = table.Column<DateTime>(nullable: false),
                    PrestamosPrestamoId = table.Column<int>(nullable: true),
                    ValorCuota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorInteres = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaEsperaPago = table.Column<DateTime>(nullable: false),
                    FechaLimitePago = table.Column<DateTime>(nullable: false),
                    DiasMora = table.Column<int>(nullable: false),
                    ValorDiasMora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorNetoPagoCuota = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuotasPrestamos", x => x.CuotaPrestamoId);
                    table.ForeignKey(
                        name: "FK_CuotasPrestamos_Prestamos_PrestamosPrestamoId",
                        column: x => x.PrestamosPrestamoId,
                        principalTable: "Prestamos",
                        principalColumn: "PrestamoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesRecaudos_NatillerasNatilleraId",
                table: "ActividadesRecaudos",
                column: "NatillerasNatilleraId");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesRecaudos_SociosSocioId",
                table: "ActividadesRecaudos",
                column: "SociosSocioId");

            migrationBuilder.CreateIndex(
                name: "IX_CuotasPrestamos_PrestamosPrestamoId",
                table: "CuotasPrestamos",
                column: "PrestamosPrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_CuotasSocios_NatillerasNatilleraId",
                table: "CuotasSocios",
                column: "NatillerasNatilleraId");

            migrationBuilder.CreateIndex(
                name: "IX_CuotasSocios_SociosSocioId",
                table: "CuotasSocios",
                column: "SociosSocioId");

            migrationBuilder.CreateIndex(
                name: "IX_NatilleraSocios_NatillerasNatilleraId",
                table: "NatilleraSocios",
                column: "NatillerasNatilleraId");

            migrationBuilder.CreateIndex(
                name: "IX_NatilleraSocios_SociosSocioId",
                table: "NatilleraSocios",
                column: "SociosSocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_SociosSocioId",
                table: "Prestamos",
                column: "SociosSocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_TiposDocumentosTipoDocumentoId",
                table: "Socios",
                column: "TiposDocumentosTipoDocumentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadesRecaudos");

            migrationBuilder.DropTable(
                name: "CuotasPrestamos");

            migrationBuilder.DropTable(
                name: "CuotasSocios");

            migrationBuilder.DropTable(
                name: "NatilleraSocios");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Socios");

            migrationBuilder.DropTable(
                name: "TiposDocumentos");

            migrationBuilder.DropColumn(
                name: "DiasGraciaMora",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "FechaActualizacionRow",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "FechaCreacionRow",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "FechaInicioPagoCuota",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "NumeroCuotas",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "ValorCuotaPagar",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "ValorMoraDiaFijo",
                table: "Natilleras");

            migrationBuilder.DropColumn(
                name: "ValorMoraPagar",
                table: "Natilleras");

            migrationBuilder.RenameColumn(
                name: "NatilleraId",
                table: "Natilleras",
                newName: "IdNatillera");
        }
    }
}
