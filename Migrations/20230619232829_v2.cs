using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGrupoG03.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "reseñaId",
                table: "factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sucursalId",
                table: "factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_factura_reseñaId",
                table: "factura",
                column: "reseñaId");

            migrationBuilder.CreateIndex(
                name: "IX_factura_sucursalId",
                table: "factura",
                column: "sucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_factura_Reseña_reseñaId",
                table: "factura",
                column: "reseñaId",
                principalTable: "Reseña",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_factura_Sucursal_sucursalId",
                table: "factura",
                column: "sucursalId",
                principalTable: "Sucursal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factura_Reseña_reseñaId",
                table: "factura");

            migrationBuilder.DropForeignKey(
                name: "FK_factura_Sucursal_sucursalId",
                table: "factura");

            migrationBuilder.DropIndex(
                name: "IX_factura_reseñaId",
                table: "factura");

            migrationBuilder.DropIndex(
                name: "IX_factura_sucursalId",
                table: "factura");

            migrationBuilder.DropColumn(
                name: "reseñaId",
                table: "factura");

            migrationBuilder.DropColumn(
                name: "sucursalId",
                table: "factura");
        }
    }
}
