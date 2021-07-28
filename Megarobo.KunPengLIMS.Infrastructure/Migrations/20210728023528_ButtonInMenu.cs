using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class ButtonInMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevicePosition");

            migrationBuilder.DropTable(
                name: "LabwarePositions");

            migrationBuilder.DropTable(
                name: "ReagentPositions");

            migrationBuilder.DropTable(
                name: "RoleButton");

            migrationBuilder.DropTable(
                name: "SamplePosition");

            migrationBuilder.DropTable(
                name: "SolutionReagentDosages");

            migrationBuilder.DropTable(
                name: "SolutionSampleDosages");

            migrationBuilder.DropTable(
                name: "OpButton");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "ReagentDosages");

            migrationBuilder.AddColumn<string>(
                name: "Buttons",
                table: "RoleMenu",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Buttons",
                table: "Menus",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Buttons",
                table: "RoleMenu");

            migrationBuilder.DropColumn(
                name: "Buttons",
                table: "Menus");

            migrationBuilder.CreateTable(
                name: "OpButton",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpButton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Hole = table.Column<int>(type: "integer", nullable: false),
                    Layer = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Room = table.Column<string>(type: "text", nullable: true),
                    Tower = table.Column<int>(type: "integer", nullable: false),
                    Well = table.Column<string>(type: "text", nullable: true),
                    Zone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReagentDosages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReagentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Cubage_Unit = table.Column<string>(type: "text", nullable: true),
                    Cubage_Value = table.Column<float>(type: "real", nullable: true),
                    Quality_Unit = table.Column<string>(type: "text", nullable: true),
                    Quality_Value = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReagentDosages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReagentDosages_Reagents_ReagentId",
                        column: x => x.ReagentId,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolutionSampleDosages",
                columns: table => new
                {
                    SolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleDosageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionSampleDosages", x => new { x.SolutionId, x.SampleDosageId });
                    table.ForeignKey(
                        name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageId",
                        column: x => x.SampleDosageId,
                        principalTable: "SampleDosages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolutionSampleDosages_Solutions_SolutionId",
                        column: x => x.SolutionId,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleButton",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ButtonId = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "DevicePosition",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false)
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
                name: "LabwarePositions",
                columns: table => new
                {
                    LabwareId = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabwarePositions", x => new { x.LabwareId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_LabwarePositions_Labwares_LabwareId",
                        column: x => x.LabwareId,
                        principalTable: "Labwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabwarePositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReagentPositions",
                columns: table => new
                {
                    ReagentId = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReagentPositions", x => new { x.ReagentId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_ReagentPositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReagentPositions_Reagents_ReagentId",
                        column: x => x.ReagentId,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SamplePosition",
                columns: table => new
                {
                    SampleId = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false)
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
                name: "SolutionReagentDosages",
                columns: table => new
                {
                    SolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReagentDosageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionReagentDosages", x => new { x.SolutionId, x.ReagentDosageId });
                    table.ForeignKey(
                        name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageId",
                        column: x => x.ReagentDosageId,
                        principalTable: "ReagentDosages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolutionReagentDosages_Solutions_SolutionId",
                        column: x => x.SolutionId,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevicePosition_PositionId",
                table: "DevicePosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_LabwarePositions_PositionId",
                table: "LabwarePositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReagentDosages_ReagentId",
                table: "ReagentDosages",
                column: "ReagentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReagentPositions_PositionId",
                table: "ReagentPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleButton_ButtonId",
                table: "RoleButton",
                column: "ButtonId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplePosition_PositionId",
                table: "SamplePosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionReagentDosages_ReagentDosageId",
                table: "SolutionReagentDosages",
                column: "ReagentDosageId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionSampleDosages_SampleDosageId",
                table: "SolutionSampleDosages",
                column: "SampleDosageId");
        }
    }
}
