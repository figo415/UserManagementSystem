using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddRouteAndButton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Projects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Component",
                table: "Menus",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Hidden",
                table: "Menus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Menus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Menus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Redirect",
                table: "Menus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Menus",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OpButton",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpButton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleButton",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    ButtonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleButton", x => new { x.RoleId, x.ButtonId });
                    table.ForeignKey(
                        name: "FK_RoleButton_OpButton_ButtonId",
                        column: x => x.ButtonId,
                        principalTable: "OpButton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleButton_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleButton_ButtonId",
                table: "RoleButton",
                column: "ButtonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleButton");

            migrationBuilder.DropTable(
                name: "OpButton");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Component",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Hidden",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Redirect",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Menus");
        }
    }
}
