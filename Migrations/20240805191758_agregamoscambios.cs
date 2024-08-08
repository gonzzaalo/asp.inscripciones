using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inscripciones.Migrations
{
    /// <inheritdoc />
    public partial class agregamoscambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnioCarreras_carreras_CarreraId",
                table: "AnioCarreras");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleInscripcions_Inscripciones_InscripcionId",
                table: "DetalleInscripcions");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleInscripcions_Materias_MateriaId",
                table: "DetalleInscripcions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_alumnos_AlumnoId",
                table: "Inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_carreras_CarreraId",
                table: "Inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_AnioCarreras_AnioCarreraId",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_mesasexamenes_Materias_MateriaId",
                table: "mesasexamenes");

            migrationBuilder.DropTable(
                name: "anioslectivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inscripciones",
                table: "Inscripciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleInscripcions",
                table: "DetalleInscripcions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnioCarreras",
                table: "AnioCarreras");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "materias");

            migrationBuilder.RenameTable(
                name: "Inscripciones",
                newName: "inscripciones");

            migrationBuilder.RenameTable(
                name: "DetalleInscripcions",
                newName: "detallesinscripciones");

            migrationBuilder.RenameTable(
                name: "AnioCarreras",
                newName: "anioscarreras");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_AnioCarreraId",
                table: "materias",
                newName: "IX_materias_AnioCarreraId");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_CarreraId",
                table: "inscripciones",
                newName: "IX_inscripciones_CarreraId");

            migrationBuilder.RenameIndex(
                name: "IX_Inscripciones_AlumnoId",
                table: "inscripciones",
                newName: "IX_inscripciones_AlumnoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleInscripcions_MateriaId",
                table: "detallesinscripciones",
                newName: "IX_detallesinscripciones_MateriaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleInscripcions_InscripcionId",
                table: "detallesinscripciones",
                newName: "IX_detallesinscripciones_InscripcionId");

            migrationBuilder.RenameIndex(
                name: "IX_AnioCarreras_CarreraId",
                table: "anioscarreras",
                newName: "IX_anioscarreras_CarreraId");

            migrationBuilder.AddColumn<int>(
                name: "CicloLectivoId",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "carreras",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_materias",
                table: "materias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inscripciones",
                table: "inscripciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_detallesinscripciones",
                table: "detallesinscripciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_anioscarreras",
                table: "anioscarreras",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "cicloslectivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cicloslectivos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "horas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsRecreo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inscriptoscarreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(type: "int", nullable: true),
                    CarreraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscriptoscarreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inscriptoscarreras_alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "alumnos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_inscriptoscarreras_carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "carreras",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: true),
                    DocenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuarios_alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "alumnos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_usuarios_docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "docentes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MateriaId = table.Column<int>(type: "int", nullable: true),
                    CantidadHoras = table.Column<int>(type: "int", nullable: false),
                    CicloLectivoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_horarios_cicloslectivos_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "cicloslectivos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_horarios_materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materias",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleshorarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HorarioId = table.Column<int>(type: "int", nullable: true),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    HoraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleshorarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleshorarios_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalleshorarios_horas_HoraId",
                        column: x => x.HoraId,
                        principalTable: "horas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "integranteshorarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HorarioId = table.Column<int>(type: "int", nullable: true),
                    DocenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_integranteshorarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_integranteshorarios_docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "docentes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_integranteshorarios_horarios_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "horarios",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sigla",
                value: "TSDS");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Sigla",
                value: "TSSITI");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 3,
                column: "Sigla",
                value: "TSGO");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 4,
                column: "Sigla",
                value: "TSE");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Sigla",
                value: "PEA");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Sigla",
                value: "PEI");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Sigla",
                value: "PEE");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 8,
                column: "Sigla",
                value: "PET");

            migrationBuilder.UpdateData(
                table: "carreras",
                keyColumn: "Id",
                keyValue: 9,
                column: "Sigla",
                value: "LCM");

            migrationBuilder.InsertData(
                table: "cicloslectivos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "2024" });

            migrationBuilder.InsertData(
                table: "docentes",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Adamo, G." },
                    { 2, "Aimar, M.A." },
                    { 3, "Albaristo, Stef." },
                    { 4, "Alesso, A." },
                    { 5, "Alesso, M." },
                    { 6, "Arnolfo, P." },
                    { 7, "Bazán, D." },
                    { 8, "Blanche, C." },
                    { 9, "Bogni, J." },
                    { 10, "Brondino, D." },
                    { 11, "Brussa, G." },
                    { 12, "Buceta, MB." },
                    { 13, "Bueno, M.F." },
                    { 14, "Cainero, G." },
                    { 15, "Calvo, M." },
                    { 16, "Cavallini, J." },
                    { 17, "Chauderón, L." },
                    { 18, "Chelini, V." },
                    { 19, "Corradi, R." },
                    { 20, "Dalesio, C." },
                    { 21, "Degiorgio, O." },
                    { 22, "Della Rosa, M." },
                    { 23, "Dellaferrera, C." },
                    { 24, "Doglioli, M." },
                    { 25, "Duran, C." },
                    { 26, "Epes, B." },
                    { 27, "Espru, F." },
                    { 28, "Ferreyra, M." },
                    { 29, "Ferrero, M." },
                    { 30, "Ferr, N." },
                    { 31, "Gaido, J.P." },
                    { 32, "Galmes, M." },
                    { 33, "Genero, A." },
                    { 34, "Gongora, L." },
                    { 35, "Gomez, V." },
                    { 36, "Gretter, M.C." },
                    { 37, "Grosso, S." },
                    { 38, "Imhof, R." },
                    { 39, "Imperiale, M." },
                    { 40, "Lodi, L." },
                    { 41, "Lovino, F." },
                    { 42, "Mancilla, J." },
                    { 43, "Manattini, S." },
                    { 44, "Marenoni, A." },
                    { 45, "Martínez, G." },
                    { 46, "Mendoza, M." },
                    { 47, "Miñoz, A." },
                    { 48, "Molina, T." },
                    { 49, "Monzón, M.I." },
                    { 50, "Nasimbera, R." },
                    { 51, "Ortiz, L." },
                    { 52, "Paredes, M." },
                    { 53, "Pedrazzoli, F." },
                    { 54, "Pereyra, S." },
                    { 55, "Peressin, S." },
                    { 56, "Prida, C." },
                    { 57, "Puccio, D." },
                    { 58, "Quaglia, E." },
                    { 59, "Ramirez, R.A." },
                    { 60, "Renteria, D." },
                    { 61, "Rodriguez Quain, J." },
                    { 62, "Rosso, E." },
                    { 63, "Sanchez, R." },
                    { 64, "Sandoval, P." },
                    { 65, "Sancho, I." },
                    { 66, "Sara, J." },
                    { 67, "Strada, J." },
                    { 68, "Tovar, C." },
                    { 69, "Tregnaghi, C." },
                    { 70, "Tschopp, M.R." },
                    { 71, "Verzzali, A." },
                    { 72, "Vigniatti, E." },
                    { 73, "Villa, M.F." }
                });

            migrationBuilder.InsertData(
                table: "horas",
                columns: new[] { "Id", "EsRecreo", "Nombre" },
                values: new object[] { 1, false, "8:00hs a 9:00hs" });

            migrationBuilder.InsertData(
                table: "inscriptoscarreras",
                columns: new[] { "Id", "AlumnoId", "CarreraId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "turnosexamenes",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Julio/Agosto 2024" });

            migrationBuilder.InsertData(
                table: "horarios",
                columns: new[] { "Id", "CantidadHoras", "CicloLectivoId", "MateriaId" },
                values: new object[] { 1, 4, 1, 1 });

            migrationBuilder.InsertData(
                table: "inscripciones",
                columns: new[] { "Id", "AlumnoId", "CarreraId", "CicloLectivoId", "Fecha" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2024, 8, 5, 16, 17, 55, 807, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.InsertData(
                table: "mesasexamenes",
                columns: new[] { "Id", "Horario", "Llamado1", "Llamado2", "MateriaId", "TurnoExamenId" },
                values: new object[,]
                {
                    { 1, "17 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 2, "17 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 3, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 4, "17 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 5, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 6, "18 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1 },
                    { 7, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 8, "17 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 9, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 10, "18 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 1 },
                    { 11, "17 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1 },
                    { 12, "17 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1 },
                    { 13, "17 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1 },
                    { 14, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1 },
                    { 15, "17 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 1 },
                    { 16, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 1 },
                    { 17, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 1 },
                    { 18, "17 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 1 },
                    { 19, "13 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1 },
                    { 20, "13 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 1 },
                    { 21, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 1 },
                    { 22, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 1 },
                    { 23, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 1 },
                    { 24, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 1 },
                    { 25, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 1 },
                    { 26, "17 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 1 },
                    { 27, "17 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 1 },
                    { 28, "17 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 1 },
                    { 29, "17 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 1 },
                    { 30, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 1 },
                    { 31, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 1 },
                    { 32, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 1 },
                    { 33, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1 },
                    { 34, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 1 },
                    { 35, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 1 },
                    { 36, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 1 },
                    { 37, "18 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 1 },
                    { 38, "18 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 161, 1 },
                    { 39, "18 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 1 },
                    { 40, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 156, 1 },
                    { 41, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 154, 1 },
                    { 42, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 155, 1 },
                    { 43, "17 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 166, 1 },
                    { 44, "18 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 170, 1 },
                    { 45, "18 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 163, 1 },
                    { 46, "18 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 164, 1 },
                    { 47, "18 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 1 },
                    { 48, "19 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 172, 1 },
                    { 49, "19 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 178, 1 },
                    { 50, "18 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 133, 1 },
                    { 51, "17 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 1 },
                    { 52, "17 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 132, 1 },
                    { 53, "17 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 1 },
                    { 54, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, 1 },
                    { 55, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 1 },
                    { 56, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, 1 },
                    { 57, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 1 },
                    { 58, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 1 },
                    { 59, "18 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, 1 },
                    { 60, "17 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 144, 1 },
                    { 61, "18 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 1 },
                    { 62, "17 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 142, 1 },
                    { 63, "17 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, 1 },
                    { 64, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 1 },
                    { 65, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 1 },
                    { 66, "17 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, 1 },
                    { 67, "17 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 1 },
                    { 68, "18 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 151, 1 },
                    { 69, "17 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, 1 },
                    { 70, "17 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 146, 1 },
                    { 71, "18 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 152, 1 },
                    { 72, "8 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 1 },
                    { 73, "8 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 1 },
                    { 74, "8 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 1 },
                    { 75, "8 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 1 },
                    { 76, "8 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 1 },
                    { 77, "8 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 1 },
                    { 78, "8 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 1 },
                    { 79, "8 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, 1 },
                    { 80, "8 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 112, 1 },
                    { 81, "8 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 1 },
                    { 82, "8 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, 1 },
                    { 83, "8 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 1 },
                    { 84, "8 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 1 },
                    { 85, "8 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, 1 },
                    { 86, "8 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 1 },
                    { 87, "10 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, 1 },
                    { 88, "8 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, 1 },
                    { 89, "8 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, 1 },
                    { 90, "8 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, 1 },
                    { 91, "8 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 1 },
                    { 92, "13 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 229, 1 },
                    { 93, "13 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 224, 1 },
                    { 94, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 1 },
                    { 95, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 227, 1 },
                    { 96, "13 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 225, 1 },
                    { 97, "13 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 228, 1 },
                    { 98, "13 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 1 },
                    { 99, "13 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 230, 1 },
                    { 100, "13 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 235, 1 },
                    { 101, "13 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 240, 1 },
                    { 102, "13 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 238, 1 },
                    { 103, "13 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 233, 1 },
                    { 104, "13 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 239, 1 },
                    { 105, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 234, 1 },
                    { 106, "13 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 237, 1 },
                    { 107, "13 HS", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 251, 1 },
                    { 108, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 246, 1 },
                    { 109, "13 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 1 },
                    { 110, "13 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 243, 1 },
                    { 111, "13 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 245, 1 },
                    { 112, "13 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 244, 1 },
                    { 113, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 263, 1 },
                    { 114, "13 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 259, 1 },
                    { 115, "13 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 182, 1 },
                    { 116, "13 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 189, 1 },
                    { 117, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, 1 },
                    { 118, "13 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 185, 1 },
                    { 119, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 179, 1 },
                    { 120, "13 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 181, 1 },
                    { 121, "13 HS", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 201, 1 },
                    { 122, "13 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, 1 },
                    { 123, "13 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 198, 1 },
                    { 124, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 197, 1 },
                    { 125, "13 HS", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 195, 1 },
                    { 126, "13 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 199, 1 },
                    { 127, "13 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 192, 1 },
                    { 128, "8 HS", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 209, 1 },
                    { 129, "8 HS", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 204, 1 },
                    { 130, "8 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 1 },
                    { 131, "8 HS", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 207, 1 },
                    { 132, "8 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 206, 1 },
                    { 133, "10 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 210, 1 },
                    { 134, "10 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 214, 1 },
                    { 135, "10 HS", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 215, 1 },
                    { 136, "8 HS", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 219, 1 },
                    { 137, "8 HS", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 1 },
                    { 138, "11 HS", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 218, 1 }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "Id", "AlumnoId", "DocenteId", "Email", "TipoUsuario", "User" },
                values: new object[] { 1, null, 1, "admin@gmail.com", 2, "admin" });

            migrationBuilder.InsertData(
                table: "detalleshorarios",
                columns: new[] { "Id", "Dia", "HoraId", "HorarioId" },
                values: new object[] { 1, 0, 1, 1 });

            migrationBuilder.InsertData(
                table: "detallesinscripciones",
                columns: new[] { "Id", "InscripcionId", "MateriaId", "ModalidadCursado" },
                values: new object[] { 1, 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "detallesmesasexamenes",
                columns: new[] { "Id", "DocenteId", "MesaExamenId", "TipoIntegrante" },
                values: new object[,]
                {
                    { 1, 6, 1, 0 },
                    { 2, 66, 1, 1 },
                    { 3, 56, 1, 2 },
                    { 4, 16, 1, 3 },
                    { 5, 71, 2, 0 },
                    { 6, 43, 2, 1 },
                    { 7, 39, 2, 2 },
                    { 8, 66, 2, 3 },
                    { 9, 66, 3, 0 },
                    { 10, 45, 3, 1 },
                    { 11, 39, 3, 2 },
                    { 12, 28, 3, 3 },
                    { 13, 38, 4, 0 },
                    { 14, 53, 4, 1 },
                    { 15, 6, 4, 2 },
                    { 16, 23, 4, 3 },
                    { 17, 11, 5, 0 },
                    { 18, 58, 5, 1 },
                    { 19, 54, 5, 2 },
                    { 20, 56, 5, 3 },
                    { 21, 47, 6, 0 },
                    { 22, 16, 6, 1 },
                    { 23, 73, 6, 2 },
                    { 24, 16, 6, 3 },
                    { 25, 39, 7, 0 },
                    { 26, 66, 7, 1 },
                    { 27, 45, 7, 2 },
                    { 28, 28, 7, 3 },
                    { 29, 28, 8, 0 },
                    { 30, 73, 8, 1 },
                    { 31, 39, 8, 2 },
                    { 32, 23, 8, 3 },
                    { 33, 73, 9, 0 },
                    { 34, 16, 9, 1 },
                    { 35, 6, 9, 2 },
                    { 36, 56, 9, 3 },
                    { 37, 16, 10, 0 },
                    { 38, 47, 10, 1 },
                    { 39, 73, 10, 2 },
                    { 40, 16, 10, 3 },
                    { 41, 56, 11, 0 },
                    { 42, 6, 11, 1 },
                    { 43, 66, 11, 2 },
                    { 44, 53, 11, 3 },
                    { 45, 43, 12, 0 },
                    { 46, 71, 12, 1 },
                    { 47, 39, 12, 2 },
                    { 48, 66, 12, 3 },
                    { 49, 73, 13, 0 },
                    { 50, 28, 13, 1 },
                    { 51, 39, 13, 2 },
                    { 52, 23, 13, 3 },
                    { 53, 39, 14, 0 },
                    { 54, 66, 14, 1 },
                    { 55, 72, 14, 2 },
                    { 56, 56, 14, 3 },
                    { 57, 39, 15, 0 },
                    { 58, 71, 15, 1 },
                    { 59, 43, 15, 2 },
                    { 60, 66, 15, 3 },
                    { 61, 45, 16, 0 },
                    { 62, 66, 16, 1 },
                    { 63, 39, 16, 2 },
                    { 64, 28, 16, 3 },
                    { 65, 16, 17, 0 },
                    { 66, 73, 17, 1 },
                    { 67, 6, 17, 2 },
                    { 68, 56, 17, 3 },
                    { 69, 57, 18, 0 },
                    { 70, 37, 18, 1 },
                    { 71, 11, 18, 2 },
                    { 72, 59, 18, 3 },
                    { 73, 64, 19, 0 },
                    { 74, 59, 19, 1 },
                    { 75, 37, 19, 2 },
                    { 76, 31, 19, 3 },
                    { 77, 47, 20, 0 },
                    { 78, 22, 20, 1 },
                    { 79, 34, 20, 2 },
                    { 80, 64, 20, 3 },
                    { 81, 15, 21, 0 },
                    { 82, 59, 21, 1 },
                    { 83, 5, 21, 2 },
                    { 84, 53, 21, 3 },
                    { 85, 5, 22, 0 },
                    { 86, 4, 22, 1 },
                    { 87, 59, 22, 2 },
                    { 88, 57, 22, 3 },
                    { 89, 53, 23, 0 },
                    { 90, 4, 23, 1 },
                    { 91, 5, 23, 2 },
                    { 92, 34, 23, 3 },
                    { 93, 31, 24, 0 },
                    { 94, 64, 24, 1 },
                    { 95, 59, 24, 2 },
                    { 96, 59, 24, 3 },
                    { 97, 31, 25, 0 },
                    { 98, 64, 25, 1 },
                    { 99, 59, 25, 2 },
                    { 100, 59, 25, 3 },
                    { 101, 11, 26, 0 },
                    { 102, 22, 26, 1 },
                    { 103, 34, 26, 2 },
                    { 104, 15, 26, 3 },
                    { 105, 22, 27, 0 },
                    { 106, 34, 27, 1 },
                    { 107, 11, 27, 2 },
                    { 108, 15, 27, 3 },
                    { 109, 22, 28, 0 },
                    { 110, 34, 28, 1 },
                    { 111, 11, 28, 2 },
                    { 112, 15, 28, 3 },
                    { 113, 37, 29, 0 },
                    { 114, 57, 29, 1 },
                    { 115, 11, 29, 2 },
                    { 116, 57, 29, 3 },
                    { 117, 59, 30, 0 },
                    { 118, 15, 30, 1 },
                    { 119, 34, 30, 2 },
                    { 120, 53, 30, 3 },
                    { 121, 4, 31, 0 },
                    { 122, 5, 31, 1 },
                    { 123, 59, 31, 2 },
                    { 124, 57, 31, 3 },
                    { 125, 59, 32, 0 },
                    { 126, 53, 32, 1 },
                    { 127, 31, 32, 2 },
                    { 128, 34, 32, 3 },
                    { 129, 59, 33, 0 },
                    { 130, 15, 33, 1 },
                    { 131, 34, 33, 2 },
                    { 132, 53, 33, 3 },
                    { 133, 7, 34, 0 },
                    { 134, 57, 34, 1 },
                    { 135, 15, 34, 2 },
                    { 136, 15, 34, 3 },
                    { 137, 59, 35, 0 },
                    { 138, 4, 35, 1 },
                    { 139, 5, 35, 2 },
                    { 140, 57, 35, 3 },
                    { 141, 59, 36, 0 },
                    { 142, 53, 36, 1 },
                    { 143, 31, 36, 2 },
                    { 144, 34, 36, 3 },
                    { 145, 4, 37, 0 },
                    { 146, 46, 37, 1 },
                    { 147, 47, 37, 2 },
                    { 148, 59, 37, 3 },
                    { 149, 15, 38, 0 },
                    { 150, 47, 38, 1 },
                    { 151, 5, 38, 2 },
                    { 152, 21, 38, 3 },
                    { 153, 47, 39, 0 },
                    { 154, 15, 39, 1 },
                    { 155, 5, 39, 2 },
                    { 156, 21, 39, 3 },
                    { 157, 58, 40, 0 },
                    { 158, 11, 40, 1 },
                    { 159, 54, 40, 2 },
                    { 160, 46, 40, 3 },
                    { 161, 31, 41, 0 },
                    { 162, 64, 41, 1 },
                    { 163, 59, 41, 2 },
                    { 164, 58, 41, 3 },
                    { 165, 31, 42, 0 },
                    { 166, 64, 42, 1 },
                    { 167, 59, 42, 2 },
                    { 168, 58, 42, 3 },
                    { 169, 11, 43, 0 },
                    { 170, 22, 43, 1 },
                    { 171, 34, 43, 2 },
                    { 172, 46, 43, 3 },
                    { 173, 5, 44, 0 },
                    { 174, 47, 44, 1 },
                    { 175, 15, 44, 2 },
                    { 176, 21, 44, 3 },
                    { 177, 42, 45, 0 },
                    { 178, 46, 45, 1 },
                    { 179, 7, 45, 2 },
                    { 180, 53, 45, 3 },
                    { 181, 42, 46, 0 },
                    { 182, 46, 46, 1 },
                    { 183, 7, 46, 2 },
                    { 184, 53, 46, 3 },
                    { 185, 64, 47, 0 },
                    { 186, 21, 47, 1 },
                    { 187, 47, 47, 2 },
                    { 188, 46, 47, 3 },
                    { 189, 7, 48, 0 },
                    { 190, 46, 48, 1 },
                    { 191, 42, 48, 2 },
                    { 192, 53, 48, 3 },
                    { 193, 46, 49, 0 },
                    { 194, 7, 49, 1 },
                    { 195, 42, 49, 2 },
                    { 196, 53, 49, 3 },
                    { 197, 47, 50, 0 },
                    { 198, 60, 50, 1 },
                    { 199, 18, 50, 2 },
                    { 200, 67, 50, 3 },
                    { 201, 48, 51, 0 },
                    { 202, 2, 51, 1 },
                    { 203, 31, 51, 2 },
                    { 204, 28, 51, 3 },
                    { 205, 64, 52, 0 },
                    { 206, 63, 52, 1 },
                    { 207, 2, 52, 2 },
                    { 208, 33, 52, 3 },
                    { 209, 34, 53, 0 },
                    { 210, 67, 53, 1 },
                    { 211, 17, 53, 2 },
                    { 212, 47, 53, 3 },
                    { 213, 36, 54, 0 },
                    { 214, 29, 54, 1 },
                    { 215, 17, 54, 2 },
                    { 216, 48, 54, 3 },
                    { 217, 31, 55, 0 },
                    { 218, 47, 55, 1 },
                    { 219, 67, 55, 2 },
                    { 220, 2, 55, 3 },
                    { 221, 31, 56, 0 },
                    { 222, 47, 56, 1 },
                    { 223, 67, 56, 2 },
                    { 224, 2, 56, 3 },
                    { 225, 67, 57, 0 },
                    { 226, 48, 57, 1 },
                    { 227, 29, 57, 2 },
                    { 228, 28, 57, 3 },
                    { 229, 2, 58, 0 },
                    { 230, 60, 58, 1 },
                    { 231, 36, 58, 2 },
                    { 232, 28, 58, 3 },
                    { 233, 60, 59, 0 },
                    { 234, 47, 59, 1 },
                    { 235, 18, 59, 2 },
                    { 236, 67, 59, 3 },
                    { 237, 29, 60, 0 },
                    { 238, 7, 60, 1 },
                    { 239, 11, 60, 2 },
                    { 240, 37, 60, 3 },
                    { 241, 17, 61, 0 },
                    { 242, 18, 61, 1 },
                    { 243, 7, 61, 2 },
                    { 244, 29, 61, 3 },
                    { 245, 34, 62, 0 },
                    { 246, 18, 62, 1 },
                    { 247, 37, 62, 2 },
                    { 248, 33, 62, 3 },
                    { 249, 34, 63, 0 },
                    { 250, 48, 63, 1 },
                    { 251, 60, 63, 2 },
                    { 252, 47, 63, 3 },
                    { 253, 37, 64, 0 },
                    { 254, 7, 64, 1 },
                    { 255, 33, 64, 2 },
                    { 256, 48, 64, 3 },
                    { 257, 34, 65, 0 },
                    { 258, 18, 65, 1 },
                    { 259, 48, 65, 2 },
                    { 260, 2, 65, 3 },
                    { 261, 67, 66, 0 },
                    { 262, 48, 66, 1 },
                    { 263, 29, 66, 2 },
                    { 264, 29, 66, 3 },
                    { 265, 63, 67, 0 },
                    { 266, 34, 67, 1 },
                    { 267, 18, 67, 2 },
                    { 268, 29, 67, 3 },
                    { 269, 18, 68, 0 },
                    { 270, 17, 68, 1 },
                    { 271, 7, 68, 2 },
                    { 272, 29, 68, 3 },
                    { 273, 18, 69, 0 },
                    { 274, 34, 69, 1 },
                    { 275, 37, 69, 2 },
                    { 276, 29, 69, 3 },
                    { 277, 7, 70, 0 },
                    { 278, 37, 70, 1 },
                    { 279, 33, 70, 2 },
                    { 280, 48, 70, 3 },
                    { 281, 18, 71, 0 },
                    { 282, 34, 71, 1 },
                    { 283, 48, 71, 2 },
                    { 284, 2, 71, 3 },
                    { 285, 61, 72, 0 },
                    { 286, 9, 72, 1 },
                    { 287, 32, 72, 2 },
                    { 288, 3, 72, 3 },
                    { 289, 8, 73, 0 },
                    { 290, 9, 73, 1 },
                    { 291, 12, 73, 2 },
                    { 292, 61, 73, 3 },
                    { 293, 8, 74, 0 },
                    { 294, 9, 74, 1 },
                    { 295, 12, 74, 2 },
                    { 296, 61, 74, 3 },
                    { 297, 3, 75, 0 },
                    { 298, 61, 75, 1 },
                    { 299, 32, 75, 2 },
                    { 300, 9, 75, 3 },
                    { 301, 54, 76, 0 },
                    { 302, 51, 76, 1 },
                    { 303, 61, 76, 2 },
                    { 304, 3, 76, 3 },
                    { 305, 3, 77, 0 },
                    { 306, 51, 77, 1 },
                    { 307, 32, 77, 2 },
                    { 308, 12, 77, 3 },
                    { 309, 9, 78, 0 },
                    { 310, 61, 78, 1 },
                    { 311, 32, 78, 2 },
                    { 312, 3, 78, 3 },
                    { 313, 61, 79, 0 },
                    { 314, 7, 79, 1 },
                    { 315, 54, 79, 2 },
                    { 316, 61, 79, 3 },
                    { 317, 68, 80, 0 },
                    { 318, 24, 80, 1 },
                    { 319, 3, 80, 2 },
                    { 320, 25, 80, 3 },
                    { 321, 24, 81, 0 },
                    { 322, 68, 81, 1 },
                    { 323, 3, 81, 2 },
                    { 324, 25, 81, 3 },
                    { 325, 54, 82, 0 },
                    { 326, 3, 82, 1 },
                    { 327, 51, 82, 2 },
                    { 328, 61, 82, 3 },
                    { 329, 12, 83, 0 },
                    { 330, 49, 83, 1 },
                    { 331, 7, 83, 2 },
                    { 332, 3, 83, 3 },
                    { 333, 49, 84, 0 },
                    { 334, 12, 84, 1 },
                    { 335, 7, 84, 2 },
                    { 336, 3, 84, 3 },
                    { 337, 7, 85, 0 },
                    { 338, 61, 85, 1 },
                    { 339, 54, 85, 2 },
                    { 340, 61, 85, 3 },
                    { 341, 30, 86, 0 },
                    { 342, 35, 86, 1 },
                    { 343, 31, 86, 2 },
                    { 344, 61, 86, 3 },
                    { 345, 37, 87, 0 },
                    { 346, 68, 87, 1 },
                    { 347, 25, 87, 2 },
                    { 348, 25, 87, 3 },
                    { 349, 9, 88, 0 },
                    { 350, 32, 88, 1 },
                    { 351, 51, 88, 2 },
                    { 352, 3, 88, 3 },
                    { 353, 3, 89, 0 },
                    { 354, 54, 89, 1 },
                    { 355, 51, 89, 2 },
                    { 356, 61, 89, 3 },
                    { 357, 61, 90, 0 },
                    { 358, 3, 90, 1 },
                    { 359, 32, 90, 2 },
                    { 360, 9, 90, 3 },
                    { 361, 25, 91, 0 },
                    { 362, 68, 91, 1 },
                    { 363, 51, 91, 2 },
                    { 364, 9, 91, 3 },
                    { 365, 39, 92, 0 },
                    { 366, 72, 92, 1 },
                    { 367, 20, 92, 2 },
                    { 368, 2, 92, 3 },
                    { 369, 28, 93, 0 },
                    { 370, 72, 93, 1 },
                    { 371, 17, 93, 2 },
                    { 372, 34, 93, 3 },
                    { 373, 17, 94, 0 },
                    { 374, 22, 94, 1 },
                    { 375, 44, 94, 2 },
                    { 376, 47, 94, 3 },
                    { 377, 17, 95, 0 },
                    { 378, 22, 95, 1 },
                    { 379, 44, 95, 2 },
                    { 380, 47, 95, 3 },
                    { 381, 42, 96, 0 },
                    { 382, 71, 96, 1 },
                    { 383, 60, 96, 2 },
                    { 384, 48, 96, 3 },
                    { 385, 34, 97, 0 },
                    { 386, 48, 97, 1 },
                    { 387, 44, 97, 2 },
                    { 388, 22, 97, 3 },
                    { 389, 44, 98, 0 },
                    { 390, 48, 98, 1 },
                    { 391, 34, 98, 2 },
                    { 392, 22, 98, 3 },
                    { 393, 60, 99, 0 },
                    { 394, 28, 99, 1 },
                    { 395, 55, 99, 2 },
                    { 396, 28, 99, 3 },
                    { 397, 72, 100, 0 },
                    { 398, 39, 100, 1 },
                    { 399, 20, 100, 2 },
                    { 400, 34, 100, 3 },
                    { 401, 11, 101, 0 },
                    { 402, 30, 101, 1 },
                    { 403, 31, 101, 2 },
                    { 404, 36, 101, 3 },
                    { 405, 30, 102, 0 },
                    { 406, 11, 102, 1 },
                    { 407, 31, 102, 2 },
                    { 408, 36, 102, 3 },
                    { 409, 49, 103, 0 },
                    { 410, 28, 103, 1 },
                    { 411, 71, 103, 2 },
                    { 412, 2, 103, 3 },
                    { 413, 60, 104, 0 },
                    { 414, 42, 104, 1 },
                    { 415, 71, 104, 2 },
                    { 416, 48, 104, 3 },
                    { 417, 28, 105, 0 },
                    { 418, 64, 105, 1 },
                    { 419, 30, 105, 2 },
                    { 420, 17, 105, 3 },
                    { 421, 34, 106, 0 },
                    { 422, 48, 106, 1 },
                    { 423, 44, 106, 2 },
                    { 424, 22, 106, 3 },
                    { 425, 72, 107, 0 },
                    { 426, 28, 107, 1 },
                    { 427, 17, 107, 2 },
                    { 428, 34, 107, 3 },
                    { 429, 22, 108, 0 },
                    { 430, 17, 108, 1 },
                    { 431, 44, 108, 2 },
                    { 432, 47, 108, 3 },
                    { 433, 30, 109, 0 },
                    { 434, 11, 109, 1 },
                    { 435, 31, 109, 2 },
                    { 436, 36, 109, 3 },
                    { 437, 28, 110, 0 },
                    { 438, 49, 110, 1 },
                    { 439, 71, 110, 2 },
                    { 440, 2, 110, 3 },
                    { 441, 71, 111, 0 },
                    { 442, 42, 111, 1 },
                    { 443, 60, 111, 2 },
                    { 444, 48, 111, 3 },
                    { 445, 28, 112, 0 },
                    { 446, 60, 112, 1 },
                    { 447, 55, 112, 2 },
                    { 448, 27, 112, 3 },
                    { 449, 64, 113, 0 },
                    { 450, 28, 113, 1 },
                    { 451, 30, 113, 2 },
                    { 452, 17, 113, 3 },
                    { 453, 48, 114, 0 },
                    { 454, 44, 114, 1 },
                    { 455, 34, 114, 2 },
                    { 456, 22, 114, 3 },
                    { 457, 42, 115, 0 },
                    { 458, 54, 115, 1 },
                    { 459, 31, 115, 2 },
                    { 460, 44, 115, 3 },
                    { 461, 54, 116, 0 },
                    { 462, 42, 116, 1 },
                    { 463, 31, 116, 2 },
                    { 464, 44, 116, 3 },
                    { 465, 49, 117, 0 },
                    { 466, 69, 117, 1 },
                    { 467, 72, 117, 2 },
                    { 468, 10, 117, 3 },
                    { 469, 43, 118, 0 },
                    { 470, 49, 118, 1 },
                    { 471, 54, 118, 2 },
                    { 472, 36, 118, 3 },
                    { 473, 10, 119, 0 },
                    { 474, 13, 119, 1 },
                    { 475, 65, 119, 2 },
                    { 476, 69, 119, 3 },
                    { 477, 73, 120, 0 },
                    { 478, 40, 120, 1 },
                    { 479, 10, 120, 2 },
                    { 480, 72, 120, 3 },
                    { 481, 54, 121, 0 },
                    { 482, 42, 121, 1 },
                    { 483, 31, 121, 2 },
                    { 484, 44, 121, 3 },
                    { 485, 69, 122, 0 },
                    { 486, 49, 122, 1 },
                    { 487, 72, 122, 2 },
                    { 488, 10, 122, 3 },
                    { 489, 49, 123, 0 },
                    { 490, 43, 123, 1 },
                    { 491, 54, 123, 2 },
                    { 492, 36, 123, 3 },
                    { 493, 13, 124, 0 },
                    { 494, 10, 124, 1 },
                    { 495, 65, 124, 2 },
                    { 496, 69, 124, 3 },
                    { 497, 65, 125, 0 },
                    { 498, 10, 125, 1 },
                    { 499, 13, 125, 2 },
                    { 500, 69, 125, 3 },
                    { 501, 44, 126, 0 },
                    { 502, 11, 126, 1 },
                    { 503, 36, 126, 2 },
                    { 504, 49, 126, 3 },
                    { 505, 40, 127, 0 },
                    { 506, 73, 127, 1 },
                    { 507, 10, 127, 2 },
                    { 508, 72, 127, 3 },
                    { 509, 69, 128, 0 },
                    { 510, 52, 128, 1 },
                    { 511, 42, 128, 2 },
                    { 512, 54, 128, 3 },
                    { 513, 21, 129, 0 },
                    { 514, 68, 129, 1 },
                    { 515, 19, 129, 2 },
                    { 516, 54, 129, 3 },
                    { 517, 27, 130, 0 },
                    { 518, 39, 130, 1 },
                    { 519, 14, 130, 2 },
                    { 520, 54, 130, 3 },
                    { 521, 44, 131, 0 },
                    { 522, 11, 131, 1 },
                    { 523, 19, 131, 2 },
                    { 524, 54, 131, 3 },
                    { 525, 72, 132, 0 },
                    { 526, 71, 132, 1 },
                    { 527, 50, 132, 2 },
                    { 528, 3, 132, 3 },
                    { 529, 39, 133, 0 },
                    { 530, 60, 133, 1 },
                    { 531, 27, 133, 2 },
                    { 532, 12, 133, 3 },
                    { 533, 39, 134, 0 },
                    { 534, 60, 134, 1 },
                    { 535, 27, 134, 2 },
                    { 536, 62, 134, 3 },
                    { 537, 39, 135, 0 },
                    { 538, 60, 135, 1 },
                    { 539, 27, 135, 2 },
                    { 540, 62, 135, 3 },
                    { 541, 64, 136, 0 },
                    { 542, 2, 136, 1 },
                    { 543, 60, 136, 2 },
                    { 544, 54, 136, 3 },
                    { 545, 71, 137, 0 },
                    { 546, 50, 137, 1 },
                    { 547, 72, 137, 2 },
                    { 548, 30, 137, 3 },
                    { 549, 39, 138, 0 },
                    { 550, 27, 138, 1 },
                    { 551, 14, 138, 2 },
                    { 552, 12, 138, 3 }
                });

            migrationBuilder.InsertData(
                table: "integranteshorarios",
                columns: new[] { "Id", "DocenteId", "HorarioId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_CicloLectivoId",
                table: "inscripciones",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleshorarios_HoraId",
                table: "detalleshorarios",
                column: "HoraId");

            migrationBuilder.CreateIndex(
                name: "IX_detalleshorarios_HorarioId",
                table: "detalleshorarios",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_CicloLectivoId",
                table: "horarios",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_MateriaId",
                table: "horarios",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_inscriptoscarreras_AlumnoId",
                table: "inscriptoscarreras",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_inscriptoscarreras_CarreraId",
                table: "inscriptoscarreras",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_integranteshorarios_DocenteId",
                table: "integranteshorarios",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_integranteshorarios_HorarioId",
                table: "integranteshorarios",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_AlumnoId",
                table: "usuarios",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_DocenteId",
                table: "usuarios",
                column: "DocenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_anioscarreras_carreras_CarreraId",
                table: "anioscarreras",
                column: "CarreraId",
                principalTable: "carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_detallesinscripciones_inscripciones_InscripcionId",
                table: "detallesinscripciones",
                column: "InscripcionId",
                principalTable: "inscripciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_detallesinscripciones_materias_MateriaId",
                table: "detallesinscripciones",
                column: "MateriaId",
                principalTable: "materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_alumnos_AlumnoId",
                table: "inscripciones",
                column: "AlumnoId",
                principalTable: "alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_carreras_CarreraId",
                table: "inscripciones",
                column: "CarreraId",
                principalTable: "carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_cicloslectivos_CicloLectivoId",
                table: "inscripciones",
                column: "CicloLectivoId",
                principalTable: "cicloslectivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_anioscarreras_AnioCarreraId",
                table: "materias",
                column: "AnioCarreraId",
                principalTable: "anioscarreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mesasexamenes_materias_MateriaId",
                table: "mesasexamenes",
                column: "MateriaId",
                principalTable: "materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anioscarreras_carreras_CarreraId",
                table: "anioscarreras");

            migrationBuilder.DropForeignKey(
                name: "FK_detallesinscripciones_inscripciones_InscripcionId",
                table: "detallesinscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_detallesinscripciones_materias_MateriaId",
                table: "detallesinscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_alumnos_AlumnoId",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_carreras_CarreraId",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_cicloslectivos_CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_anioscarreras_AnioCarreraId",
                table: "materias");

            migrationBuilder.DropForeignKey(
                name: "FK_mesasexamenes_materias_MateriaId",
                table: "mesasexamenes");

            migrationBuilder.DropTable(
                name: "detalleshorarios");

            migrationBuilder.DropTable(
                name: "inscriptoscarreras");

            migrationBuilder.DropTable(
                name: "integranteshorarios");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "horas");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "cicloslectivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_materias",
                table: "materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inscripciones",
                table: "inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_inscripciones_CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_detallesinscripciones",
                table: "detallesinscripciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_anioscarreras",
                table: "anioscarreras");

            migrationBuilder.DeleteData(
                table: "detallesinscripciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "detallesmesasexamenes",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "docentes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "inscripciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "mesasexamenes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "turnosexamenes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CicloLectivoId",
                table: "inscripciones");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "carreras");

            migrationBuilder.RenameTable(
                name: "materias",
                newName: "Materias");

            migrationBuilder.RenameTable(
                name: "inscripciones",
                newName: "Inscripciones");

            migrationBuilder.RenameTable(
                name: "detallesinscripciones",
                newName: "DetalleInscripcions");

            migrationBuilder.RenameTable(
                name: "anioscarreras",
                newName: "AnioCarreras");

            migrationBuilder.RenameIndex(
                name: "IX_materias_AnioCarreraId",
                table: "Materias",
                newName: "IX_Materias_AnioCarreraId");

            migrationBuilder.RenameIndex(
                name: "IX_inscripciones_CarreraId",
                table: "Inscripciones",
                newName: "IX_Inscripciones_CarreraId");

            migrationBuilder.RenameIndex(
                name: "IX_inscripciones_AlumnoId",
                table: "Inscripciones",
                newName: "IX_Inscripciones_AlumnoId");

            migrationBuilder.RenameIndex(
                name: "IX_detallesinscripciones_MateriaId",
                table: "DetalleInscripcions",
                newName: "IX_DetalleInscripcions_MateriaId");

            migrationBuilder.RenameIndex(
                name: "IX_detallesinscripciones_InscripcionId",
                table: "DetalleInscripcions",
                newName: "IX_DetalleInscripcions_InscripcionId");

            migrationBuilder.RenameIndex(
                name: "IX_anioscarreras_CarreraId",
                table: "AnioCarreras",
                newName: "IX_AnioCarreras_CarreraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inscripciones",
                table: "Inscripciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleInscripcions",
                table: "DetalleInscripcions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnioCarreras",
                table: "AnioCarreras",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AnioCarreras_carreras_CarreraId",
                table: "AnioCarreras",
                column: "CarreraId",
                principalTable: "carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleInscripcions_Inscripciones_InscripcionId",
                table: "DetalleInscripcions",
                column: "InscripcionId",
                principalTable: "Inscripciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleInscripcions_Materias_MateriaId",
                table: "DetalleInscripcions",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_alumnos_AlumnoId",
                table: "Inscripciones",
                column: "AlumnoId",
                principalTable: "alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_carreras_CarreraId",
                table: "Inscripciones",
                column: "CarreraId",
                principalTable: "carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_AnioCarreras_AnioCarreraId",
                table: "Materias",
                column: "AnioCarreraId",
                principalTable: "AnioCarreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mesasexamenes_Materias_MateriaId",
                table: "mesasexamenes",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
