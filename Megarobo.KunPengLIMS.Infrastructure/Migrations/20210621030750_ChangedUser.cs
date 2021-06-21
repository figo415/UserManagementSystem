using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class ChangedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_Skills_SkillID",
                table: "UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_Users_UserID",
                table: "UserSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill");

            migrationBuilder.DropColumn(
                name: "WorkTime_End",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkTime_Start",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkTime_Unit",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UserSkill",
                newName: "UserSkills");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkill_SkillID",
                table: "UserSkills",
                newName: "IX_UserSkills_SkillID");

            migrationBuilder.AddColumn<string>(
                name: "WorkTime",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills",
                columns: new[] { "UserID", "SkillID" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillID",
                table: "UserSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Users_UserID",
                table: "UserSkills",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillID",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Users_UserID",
                table: "UserSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills");

            migrationBuilder.DropColumn(
                name: "WorkTime",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UserSkills",
                newName: "UserSkill");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_SkillID",
                table: "UserSkill",
                newName: "IX_UserSkill_SkillID");

            migrationBuilder.AddColumn<int>(
                name: "WorkTime_End",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkTime_Start",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkTime_Unit",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill",
                columns: new[] { "UserID", "SkillID" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_Skills_SkillID",
                table: "UserSkill",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_Users_UserID",
                table: "UserSkill",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
