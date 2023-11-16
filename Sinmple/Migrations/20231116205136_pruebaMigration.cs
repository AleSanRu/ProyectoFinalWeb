using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinmple.Migrations
{
    /// <inheritdoc />
    public partial class pruebaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovimientosInventario",
                table: "MovimientosInventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lote",
                table: "Lote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Almacen",
                table: "Almacen");

            migrationBuilder.DropColumn(
                name: "Id_usuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Productos_id",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Id_movimiento",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "id_lote",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "Id_lote",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "Almacen_id",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "Nombre_lote",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "Productos_id",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "usuario_id",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "Id_cuenta",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "Id_almacen",
                table: "Almacen");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Producto",
                newName: "Tipo");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuario",
                table: "Usuario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "IdProducto",
                table: "Producto",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoMovimiento",
                table: "MovimientosInventario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "MovimientosInventario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "MovimientosInventario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IdMovimiento",
                table: "MovimientosInventario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "MovimientosInventario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdLoteFk",
                table: "MovimientosInventario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdLoteFkNavigationIdLote",
                table: "MovimientosInventario",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FechaVencimiento",
                table: "Lote",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "FechaElaboracion",
                table: "Lote",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Lote",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IdLote",
                table: "Lote",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdProducto",
                table: "Lote",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdProductoNavigationIdProducto",
                table: "Lote",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuario",
                table: "Lote",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuarioNavigationIdUsuario",
                table: "Lote",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreLote",
                table: "Lote",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Cuenta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Contraseña",
                table: "Cuenta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "IdCuenta",
                table: "Cuenta",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdUsuario",
                table: "Cuenta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuarioNavigationIdUsuario",
                table: "Cuenta",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ubicacion",
                table: "Almacen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Almacen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "IdAlmacen",
                table: "Almacen",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "IdProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovimientosInventario",
                table: "MovimientosInventario",
                column: "IdMovimiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lote",
                table: "Lote",
                column: "IdLote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta",
                column: "IdCuenta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Almacen",
                table: "Almacen",
                column: "IdAlmacen");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosInventario_IdLoteFkNavigationIdLote",
                table: "MovimientosInventario",
                column: "IdLoteFkNavigationIdLote");

            migrationBuilder.CreateIndex(
                name: "IX_Lote_IdProductoNavigationIdProducto",
                table: "Lote",
                column: "IdProductoNavigationIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Lote_IdUsuarioNavigationIdUsuario",
                table: "Lote",
                column: "IdUsuarioNavigationIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdUsuarioNavigationIdUsuario",
                table: "Cuenta",
                column: "IdUsuarioNavigationIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_Usuario_IdUsuarioNavigationIdUsuario",
                table: "Cuenta",
                column: "IdUsuarioNavigationIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Lote_Producto_IdProductoNavigationIdProducto",
                table: "Lote",
                column: "IdProductoNavigationIdProducto",
                principalTable: "Producto",
                principalColumn: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Lote_Usuario_IdUsuarioNavigationIdUsuario",
                table: "Lote",
                column: "IdUsuarioNavigationIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimientosInventario_Lote_IdLoteFkNavigationIdLote",
                table: "MovimientosInventario",
                column: "IdLoteFkNavigationIdLote",
                principalTable: "Lote",
                principalColumn: "IdLote");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_Usuario_IdUsuarioNavigationIdUsuario",
                table: "Cuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Lote_Producto_IdProductoNavigationIdProducto",
                table: "Lote");

            migrationBuilder.DropForeignKey(
                name: "FK_Lote_Usuario_IdUsuarioNavigationIdUsuario",
                table: "Lote");

            migrationBuilder.DropForeignKey(
                name: "FK_MovimientosInventario_Lote_IdLoteFkNavigationIdLote",
                table: "MovimientosInventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovimientosInventario",
                table: "MovimientosInventario");

            migrationBuilder.DropIndex(
                name: "IX_MovimientosInventario_IdLoteFkNavigationIdLote",
                table: "MovimientosInventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lote",
                table: "Lote");

            migrationBuilder.DropIndex(
                name: "IX_Lote_IdProductoNavigationIdProducto",
                table: "Lote");

            migrationBuilder.DropIndex(
                name: "IX_Lote_IdUsuarioNavigationIdUsuario",
                table: "Lote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta");

            migrationBuilder.DropIndex(
                name: "IX_Cuenta_IdUsuarioNavigationIdUsuario",
                table: "Cuenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Almacen",
                table: "Almacen");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "IdMovimiento",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "IdLoteFk",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "IdLoteFkNavigationIdLote",
                table: "MovimientosInventario");

            migrationBuilder.DropColumn(
                name: "IdLote",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "IdProductoNavigationIdProducto",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "IdUsuarioNavigationIdUsuario",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "NombreLote",
                table: "Lote");

            migrationBuilder.DropColumn(
                name: "IdCuenta",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "IdUsuarioNavigationIdUsuario",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "IdAlmacen",
                table: "Almacen");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Producto",
                newName: "tipo");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Usuario",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Usuario",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_usuario",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Producto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Producto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Productos_id",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "TipoMovimiento",
                table: "MovimientosInventario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "MovimientosInventario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "MovimientosInventario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_movimiento",
                table: "MovimientosInventario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "id_lote",
                table: "MovimientosInventario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Lote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaElaboracion",
                table: "Lote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Lote",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_lote",
                table: "Lote",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Almacen_id",
                table: "Lote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nombre_lote",
                table: "Lote",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Productos_id",
                table: "Lote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuario_id",
                table: "Lote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Cuenta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contraseña",
                table: "Cuenta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_cuenta",
                table: "Cuenta",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Ubicacion",
                table: "Almacen",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Almacen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_almacen",
                table: "Almacen",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id_usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Productos_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovimientosInventario",
                table: "MovimientosInventario",
                column: "Id_movimiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lote",
                table: "Lote",
                column: "Id_lote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta",
                column: "Id_cuenta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Almacen",
                table: "Almacen",
                column: "Id_almacen");
        }
    }
}
