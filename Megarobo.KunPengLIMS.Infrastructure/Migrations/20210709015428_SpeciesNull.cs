using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class SpeciesNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Species_SpeciesId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples");

            migrationBuilder.AlterColumn<Guid>(
                name: "CellId",
                table: "Samples",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "SpeciesId",
                table: "Cell",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Species_SpeciesId",
                table: "Cell",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples",
                column: "CellId",
                principalTable: "Cell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Species_SpeciesId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples");

            migrationBuilder.AlterColumn<Guid>(
                name: "CellId",
                table: "Samples",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SpeciesId",
                table: "Cell",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Species_SpeciesId",
                table: "Cell",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples",
                column: "CellId",
                principalTable: "Cell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
