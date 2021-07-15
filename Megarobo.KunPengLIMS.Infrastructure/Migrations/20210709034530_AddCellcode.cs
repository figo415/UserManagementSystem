using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddCellcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellCode",
                table: "Cell",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellCode",
                table: "Cell");
        }
    }
}
