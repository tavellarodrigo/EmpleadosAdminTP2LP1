using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminEmpleadosEF.Migrations
{
    /// <inheritdoc />
    public partial class empleadoanulado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "anulado",
                table: "empleado",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anulado",
                table: "empleado");
        }
    }
}
