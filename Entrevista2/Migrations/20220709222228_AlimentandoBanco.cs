using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entrevista2.Migrations
{
    public partial class AlimentandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: true),
                    QtdFilhos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Idade", "Nome", "QtdFilhos" },
                values: new object[,]
                {
                    { 1, 38, "Paulo", 1 },
                    { 2, 34, "Priscila", 1 },
                    { 3, 36, "Bruno", 1 },
                    { 4, 13, "Julia", 0 },
                    { 5, 30, "Pedro", 1 },
                    { 6, 45, "Rosa", 3 },
                    { 7, 60, "Fatima", 2 },
                    { 8, 31, "Maria", 0 },
                    { 9, 20, "Rodrigo", 0 },
                    { 10, 18, "Rita", 0 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Especie", "Nome", "PessoaId" },
                values: new object[,]
                {
                    { 3, "Cachorro", "Pit", null },
                    { 4, "Cachorro", "Tom", null },
                    { 7, "Cachorro", "Spider", null },
                    { 9, "Gato", "Ross", null },
                    { 11, "Gato", "Chandler", null },
                    { 13, "Gato", "Rachel", null }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Especie", "Nome", "PessoaId" },
                values: new object[,]
                {
                    { 1, "Cachorro", "Rex", 1 },
                    { 2, "Cachorro", "Roy", 1 },
                    { 5, "Cachorro", "Clark", 4 },
                    { 6, "Cachorro", "Bat", 4 },
                    { 8, "Gato", "Mingal", 6 },
                    { 10, "Gato", "Kramer", 6 },
                    { 12, "Gato", "Phoebe", 8 },
                    { 14, "Gato", "Jerry", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PessoaId",
                table: "Pets",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
