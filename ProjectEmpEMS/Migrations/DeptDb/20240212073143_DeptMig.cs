using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEmpEMS.Migrations.DeptDb
{
    public partial class DeptMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    DeptCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.DeptCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dept");
        }
    }
}
