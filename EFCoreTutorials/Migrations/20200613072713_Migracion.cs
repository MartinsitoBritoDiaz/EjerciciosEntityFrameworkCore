using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorials.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    cursoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.cursoId);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    gradoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    Seccion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.gradoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    estudianteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    photo = table.Column<byte[]>(nullable: false),
                    altura = table.Column<decimal>(nullable: false),
                    peso = table.Column<float>(nullable: false),
                    GradoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.estudianteId);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Grado_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grado",
                        principalColumn: "gradoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DireccionEstudiante",
                columns: table => new
                {
                    direccionEstudianteId = table.Column<int>(nullable: false),
                    direccion = table.Column<string>(nullable: true),
                    ciudad = table.Column<string>(nullable: true),
                    provincia = table.Column<string>(nullable: true),
                    pais = table.Column<string>(nullable: true),
                    estudianteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionEstudiante", x => x.direccionEstudianteId);
                    table.ForeignKey(
                        name: "FK_DireccionEstudiante_Estudiantes_direccionEstudianteId",
                        column: x => x.direccionEstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "estudianteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_GradoId",
                table: "Estudiantes",
                column: "GradoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "DireccionEstudiante");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grado");
        }
    }
}
