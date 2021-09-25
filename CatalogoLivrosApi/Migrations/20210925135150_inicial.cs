using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoLivrosApi.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Livro",
                columns: table => new
                {
                    LivroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Isbn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Editora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sinopse = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Livro", x => x.LivroID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Usuario", x => x.UsuarioID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Livro");

            migrationBuilder.DropTable(
                name: "TB_Usuario");
        }
    }
}
