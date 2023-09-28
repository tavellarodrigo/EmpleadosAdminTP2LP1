using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminEmpleadosEF.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dpto_nro = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    dpto_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_empleado_departamento_dpto_id",
                        column: x => x.dpto_id,
                        principalTable: "departamento",
                        principalColumn: "DepartamentoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_empleado_dpto_id",
                table: "empleado",
                column: "dpto_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "departamento");
        }
    }
}
