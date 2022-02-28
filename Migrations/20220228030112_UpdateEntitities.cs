using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.Migrations
{
    public partial class UpdateEntitities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ValorInventario",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "ProductoDetalles",
                columns: table => new
                {
                    ProductoDetallesId = table.Column<int>(type: "INTEGER", nullable: false),
                    Presentacion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Cantidad = table.Column<float>(type: "REAL", nullable: false),
                    Costo = table.Column<float>(type: "REAL", nullable: false),
                    Precio = table.Column<float>(type: "REAL", nullable: false),
                    ValorInventario = table.Column<float>(type: "REAL", nullable: false),
                    Ganancia = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoDetalles", x => x.ProductoDetallesId);
                    table.ForeignKey(
                        name: "FK_ProductoDetalles_Productos_ProductoDetallesId",
                        column: x => x.ProductoDetallesId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoDetalles");

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

            migrationBuilder.AddColumn<float>(
                name: "ValorInventario",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
