using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jorge_Estrada.Migrations
{
    public partial class prodcat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActual",
                table: "Categorias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaActual",
                table: "Categorias");
        }
    }
}
