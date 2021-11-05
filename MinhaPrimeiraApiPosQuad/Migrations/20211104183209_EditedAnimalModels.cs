using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaPrimeiraApiPosQuad.Migrations
{
    public partial class EditedAnimalModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Animal",
                newName: "Idade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Animal",
                newName: "Quantidade");
        }
    }
}
