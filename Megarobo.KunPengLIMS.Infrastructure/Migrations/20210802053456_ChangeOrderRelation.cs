using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class ChangeOrderRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CarrierStructure = table.Column<string>(nullable: true),
                    PlasmidType = table.Column<int>(nullable: false),
                    PlasmidSize = table.Column<int>(nullable: false),
                    InsertionSequence = table.Column<string>(nullable: true),
                    DemandTiter = table.Column<float>(nullable: false),
                    TotelDemand = table.Column<float>(nullable: false),
                    SeroType = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    PackagingTrayNumber = table.Column<int>(nullable: false),
                    ProductionDate = table.Column<DateTime>(nullable: false),
                    FinisheDate = table.Column<DateTime>(nullable: false),
                    SubpackageCubage = table.Column<float>(nullable: false),
                    SubpackageNumber = table.Column<int>(nullable: false),
                    Plasmid1 = table.Column<float>(nullable: false),
                    Plasmid2 = table.Column<float>(nullable: false),
                    Plasmid3 = table.Column<float>(nullable: false),
                    Plasmid4 = table.Column<float>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MolecularCloning",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    Thickness_Unit = table.Column<string>(nullable: true),
                    Thickness_Value = table.Column<float>(nullable: true),
                    Od = table.Column<float>(nullable: false),
                    Enzyme = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    CarrierStructure = table.Column<string>(nullable: true),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MolecularCloning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MolecularCloning_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlasmidPurification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    PlasmidType = table.Column<int>(nullable: false),
                    Thickness_Unit = table.Column<string>(nullable: true),
                    Thickness_Value = table.Column<float>(nullable: true),
                    Od = table.Column<float>(nullable: false),
                    Enzyme = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    CarrierStructure = table.Column<string>(nullable: true),
                    PlasmidSize = table.Column<int>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlasmidPurification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlasmidPurification_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QpcrDetection",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    DetectionDate = table.Column<DateTime>(nullable: false),
                    Titer = table.Column<float>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QpcrDetection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QpcrDetection_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SdsPageDetection",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    DetectionDate = table.Column<DateTime>(nullable: false),
                    ProteinTiter = table.Column<float>(nullable: false),
                    IsPurityQualified = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SdsPageDetection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SdsPageDetection_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    ShipmentDate = table.Column<DateTime>(nullable: false),
                    Consignee = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    DeliveryAddress_Province = table.Column<string>(nullable: true),
                    DeliveryAddress_City = table.Column<string>(nullable: true),
                    DeliveryAddress_District = table.Column<string>(nullable: true),
                    DeliveryAddress_Detail = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SterilityDetection",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    DetectionDate = table.Column<DateTime>(nullable: false),
                    IsBacterialPollute = table.Column<bool>(nullable: false),
                    IsFluorescence = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SterilityDetection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SterilityDetection_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockIn",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ContractCode = table.Column<string>(nullable: true),
                    ContractType = table.Column<int>(nullable: false),
                    CarrierCode = table.Column<string>(nullable: true),
                    StockInDate = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    OrderCreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockIn_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MolecularCloning_OrderId",
                table: "MolecularCloning",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlasmidPurification_OrderId",
                table: "PlasmidPurification",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QpcrDetection_OrderId",
                table: "QpcrDetection",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SdsPageDetection_OrderId",
                table: "SdsPageDetection",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_OrderId",
                table: "Shipment",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SterilityDetection_OrderId",
                table: "SterilityDetection",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockIn_OrderId",
                table: "StockIn",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MolecularCloning");

            migrationBuilder.DropTable(
                name: "PlasmidPurification");

            migrationBuilder.DropTable(
                name: "QpcrDetection");

            migrationBuilder.DropTable(
                name: "SdsPageDetection");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "SterilityDetection");

            migrationBuilder.DropTable(
                name: "StockIn");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
