using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCProjectRainbow.Migrations.ClasseDb
{
    public partial class ThirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CStrength = table.Column<double>(type: "float", nullable: false),
                    CTeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.CId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classe");
        }
    }
}
