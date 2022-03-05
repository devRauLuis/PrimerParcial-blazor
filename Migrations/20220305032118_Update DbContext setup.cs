using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.Migrations
{
    public partial class UpdateDbContextsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "ProductoDetalles");

            migrationBuilder.DropColumn(
                name: "Ganancia",
                table: "ProductoDetalles");

            migrationBuilder.DropColumn(
                name: "ValorInventario",
                table: "ProductoDetalles");

            migrationBuilder.AddColumn<float>(
                name: "Costo",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Existencia",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ganancia",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<float>(
                name: "ValorInventario",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Ganancia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ValorInventario",
                table: "Productos");

            migrationBuilder.AddColumn<float>(
                name: "Costo",
                table: "ProductoDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ganancia",
                table: "ProductoDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ValorInventario",
                table: "ProductoDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
