using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddButtonAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleMenu",
                table: "RoleMenu");

            migrationBuilder.DropColumn(
                name: "Buttons",
                table: "RoleMenu");

            migrationBuilder.DropColumn(
                name: "Buttons",
                table: "Menus");

            migrationBuilder.AddColumn<Guid>(
                name: "ButtonId",
                table: "RoleMenu",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleMenu",
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" });

            migrationBuilder.CreateTable(
                name: "Button",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    MenuId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Button", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Button_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_ButtonId",
                table: "RoleMenu",
                column: "ButtonId");

            migrationBuilder.CreateIndex(
                name: "IX_Button_MenuId",
                table: "Button",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenu_Button_ButtonId",
                table: "RoleMenu",
                column: "ButtonId",
                principalTable: "Button",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenu_Button_ButtonId",
                table: "RoleMenu");

            migrationBuilder.DropTable(
                name: "Button");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleMenu",
                table: "RoleMenu");

            migrationBuilder.DropIndex(
                name: "IX_RoleMenu_ButtonId",
                table: "RoleMenu");

            migrationBuilder.DropColumn(
                name: "ButtonId",
                table: "RoleMenu");

            migrationBuilder.AddColumn<string>(
                name: "Buttons",
                table: "RoleMenu",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Buttons",
                table: "Menus",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleMenu",
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId" });
        }
    }
}
