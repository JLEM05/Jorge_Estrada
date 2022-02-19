using Microsoft.EntityFrameworkCore.Migrations;

namespace Jorge_Estrada.Migrations
{
    public partial class prodcat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateogriaId",
                table: "Productos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombrecategoria = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CateogriaId",
                table: "Productos",
                column: "CateogriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CateogriaId",
                table: "Productos",
                column: "CateogriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CateogriaId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CateogriaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CateogriaId",
                table: "Productos");
        }
    }
}
