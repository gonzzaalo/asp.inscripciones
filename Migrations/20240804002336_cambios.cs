using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anioslectivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anioslectivos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "docentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_docentes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "turnosexamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turnosexamenes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mesasexamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Llamado1 = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Llamado2 = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TurnoExamenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesasexamenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mesasexamenes_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mesasexamenes_turnosexamenes_TurnoExamenId",
                        column: x => x.TurnoExamenId,
                        principalTable: "turnosexamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detallesmesasexamenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MesaExamenId = table.Column<int>(type: "int", nullable: false),
                    DocenteId = table.Column<int>(type: "int", nullable: false),
                    TipoIntegrante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallesmesasexamenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detallesmesasexamenes_docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "docentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detallesmesasexamenes_mesasexamenes_MesaExamenId",
                        column: x => x.MesaExamenId,
                        principalTable: "mesasexamenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_detallesmesasexamenes_DocenteId",
                table: "detallesmesasexamenes",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_detallesmesasexamenes_MesaExamenId",
                table: "detallesmesasexamenes",
                column: "MesaExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_mesasexamenes_MateriaId",
                table: "mesasexamenes",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_mesasexamenes_TurnoExamenId",
                table: "mesasexamenes",
                column: "TurnoExamenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anioslectivos");

            migrationBuilder.DropTable(
                name: "detallesmesasexamenes");

            migrationBuilder.DropTable(
                name: "docentes");

            migrationBuilder.DropTable(
                name: "mesasexamenes");

            migrationBuilder.DropTable(
                name: "turnosexamenes");
        }
    }
}
