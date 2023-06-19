using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGrupoG03.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_Role_roleId",
                table: "clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "cliente");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_roleId",
                table: "cliente",
                newName: "IX_cliente_roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "calificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estrellas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "metodoPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    metodo = table.Column<string>(type: "varchar(10)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metodoPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProducto = table.Column<string>(type: "varchar(20)", nullable: false),
                    descripción = table.Column<string>(type: "varchar(100)", nullable: false),
                    precio = table.Column<string>(type: "varchar(10)", nullable: false),
                    Disponibilidad = table.Column<string>(type: "varchar(2)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repartidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreRepartidor = table.Column<string>(type: "varchar(10)", nullable: false),
                    dirección = table.Column<string>(type: "varchar(10)", nullable: false),
                    telefono = table.Column<string>(type: "varchar(10)", nullable: false),
                    horarioTrabajo = table.Column<string>(type: "varchar(10)", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repartidor_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreSucursal = table.Column<string>(type: "varchar(10)", nullable: false),
                    dirección = table.Column<string>(type: "varchar(10)", nullable: false),
                    telefono = table.Column<string>(type: "varchar(10)", nullable: false),
                    horarioApertura = table.Column<string>(type: "varchar(10)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reseña",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reseña = table.Column<string>(type: "varchar(300)", nullable: false),
                    calificacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseña", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reseña_calificacion_calificacionId",
                        column: x => x.calificacionId,
                        principalTable: "calificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    productoId = table.Column<int>(type: "int", nullable: false),
                    metodoPagoId = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<string>(type: "varchar(10)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_factura_cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_factura_metodoPago_metodoPagoId",
                        column: x => x.metodoPagoId,
                        principalTable: "metodoPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_factura_producto_productoId",
                        column: x => x.productoId,
                        principalTable: "producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    productoId = table.Column<int>(type: "int", nullable: false),
                    metodoPagoId = table.Column<int>(type: "int", nullable: false),
                    especificaciones = table.Column<string>(type: "varchar(100)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedido_cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedido_metodoPago_metodoPagoId",
                        column: x => x.metodoPagoId,
                        principalTable: "metodoPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedido_producto_productoId",
                        column: x => x.productoId,
                        principalTable: "producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_factura_clienteId",
                table: "factura",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_factura_metodoPagoId",
                table: "factura",
                column: "metodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_factura_productoId",
                table: "factura",
                column: "productoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_clienteId",
                table: "pedido",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_metodoPagoId",
                table: "pedido",
                column: "metodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_productoId",
                table: "pedido",
                column: "productoId");

            migrationBuilder.CreateIndex(
                name: "IX_Repartidor_roleId",
                table: "Repartidor",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_calificacionId",
                table: "Reseña",
                column: "calificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_Role_roleId",
                table: "cliente",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_Role_roleId",
                table: "cliente");

            migrationBuilder.DropTable(
                name: "factura");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "Repartidor");

            migrationBuilder.DropTable(
                name: "Reseña");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "metodoPago");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "calificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "clientes");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_roleId",
                table: "clientes",
                newName: "IX_clientes_roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_Role_roleId",
                table: "clientes",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
