using Microsoft.EntityFrameworkCore.Migrations;

namespace Jorge_Estrada.Migrations
{
    public partial class desccat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Categorias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Categorias");
        }
    }
}
