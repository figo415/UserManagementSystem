using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class DevicePosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Devices_DeviceID",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Positions_PositionId",
                table: "Samples");

            migrationBuilder.DropIndex(
                name: "IX_Samples_PositionId",
                table: "Samples");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DeviceID",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "DeviceID",
                table: "Positions");

            migrationBuilder.AddColumn<Guid>(
                name: "CellId",
                table: "Samples",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DevicePosition",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(nullable: false),
                    PositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicePosition", x => new { x.DeviceId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_DevicePosition_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevicePosition_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SamplePosition",
                columns: table => new
                {
                    SampleId = table.Column<Guid>(nullable: false),
                    PositionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamplePosition", x => new { x.SampleId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_SamplePosition_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamplePosition_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ChineseName = table.Column<string>(nullable: true),
                    EnglishName = table.Column<string>(nullable: true),
                    LatinName = table.Column<string>(nullable: true),
                    SpeciesId_Name = table.Column<string>(nullable: true),
                    SpeciesId_Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cell",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PurchaseFrom_Name = table.Column<string>(nullable: true),
                    PurchaseFrom_Url = table.Column<string>(nullable: true),
                    Price_Unit = table.Column<string>(nullable: true),
                    Price_Value = table.Column<float>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Supplier = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TissueType = table.Column<string>(nullable: true),
                    CellLineType = table.Column<string>(nullable: true),
                    CultivationMethod = table.Column<string>(nullable: true),
                    BioSafetyLevel = table.Column<int>(nullable: false),
                    Disease = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    CrisprOrderLevel = table.Column<int>(nullable: false),
                    AtccId = table.Column<string>(nullable: true),
                    AtccUrl = table.Column<string>(nullable: true),
                    SpeciesId = table.Column<Guid>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cell_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samples_CellId",
                table: "Samples",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Cell_SpeciesId",
                table: "Cell",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePosition_PositionId",
                table: "DevicePosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplePosition_PositionId",
                table: "SamplePosition",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples",
                column: "CellId",
                principalTable: "Cell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Cell_CellId",
                table: "Samples");

            migrationBuilder.DropTable(
                name: "Cell");

            migrationBuilder.DropTable(
                name: "DevicePosition");

            migrationBuilder.DropTable(
                name: "SamplePosition");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Samples_CellId",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "CellId",
                table: "Samples");

            migrationBuilder.AddColumn<Guid>(
                name: "PositionId",
                table: "Samples",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceID",
                table: "Positions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Samples_PositionId",
                table: "Samples",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DeviceID",
                table: "Positions",
                column: "DeviceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Devices_DeviceID",
                table: "Positions",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Positions_PositionId",
                table: "Samples",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
