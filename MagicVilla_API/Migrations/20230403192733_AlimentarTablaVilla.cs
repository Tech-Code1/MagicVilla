using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    public partial class AlimentarTablaVilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 1, "", "Detalle de la villa...", new DateTime(2023, 4, 3, 14, 27, 33, 462, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 4, 3, 14, 27, 33, 462, DateTimeKind.Local).AddTicks(23), "", 50, "Villa real", 5, 200.0 });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 2, "", "Detalle de la villa...", new DateTime(2023, 4, 3, 14, 27, 33, 462, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 4, 3, 14, 27, 33, 462, DateTimeKind.Local).AddTicks(50), "", 40, "Premium Vista a la Piscina", 4, 150.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
