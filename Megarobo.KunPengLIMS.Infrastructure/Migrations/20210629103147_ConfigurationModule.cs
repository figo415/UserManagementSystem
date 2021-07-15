using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class ConfigurationModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Positions_PositionID",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "SubClass",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "PositionID",
                table: "Samples",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Url",
                table: "Samples",
                newName: "PurchaseFrom_Url");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Name",
                table: "Samples",
                newName: "PurchaseFrom_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Samples_PositionID",
                table: "Samples",
                newName: "IX_Samples_PositionId");

            migrationBuilder.RenameColumn(
                name: "UnusedQuality_Value",
                table: "Reagents",
                newName: "AvailableQuality_Value");

            migrationBuilder.RenameColumn(
                name: "UnusedQuality_Unit",
                table: "Reagents",
                newName: "AvailableQuality_Unit");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Url",
                table: "Reagents",
                newName: "PurchaseFrom_Url");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Name",
                table: "Reagents",
                newName: "PurchaseFrom_Name");

            migrationBuilder.RenameColumn(
                name: "Cubage_Value",
                table: "Reagents",
                newName: "AvailableCubage_Value");

            migrationBuilder.RenameColumn(
                name: "Cubage_Unit",
                table: "Reagents",
                newName: "AvailableCubage_Unit");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Url",
                table: "Labwares",
                newName: "PurchaseFrom_Url");

            migrationBuilder.RenameColumn(
                name: "BoughtFrom_Name",
                table: "Labwares",
                newName: "PurchaseFrom_Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Samples",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Samples",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Samples",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cubage_Unit",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Cubage_Value",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Quality_Unit",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Quality_Value",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thickness_Unit",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Thickness_Value",
                table: "Samples",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reagents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Reagents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Reagents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Positions",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ArticleNumber",
                table: "Labwares",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Labwares",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Labwares",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Labwares",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Devices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Devices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Devices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModelNumber",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Devices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Supplier",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseFrom_Name",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseFrom_Url",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price_Unit",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price_Value",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Positions_PositionId",
                table: "Samples",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Positions_PositionId",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Cubage_Unit",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Cubage_Value",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Quality_Unit",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Quality_Value",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Thickness_Unit",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Thickness_Value",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Reagents");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "ArticleNumber",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Labwares");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "ModelNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Supplier",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PurchaseFrom_Name",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PurchaseFrom_Url",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Price_Unit",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Price_Value",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "Samples",
                newName: "PositionID");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Url",
                table: "Samples",
                newName: "BoughtFrom_Url");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Name",
                table: "Samples",
                newName: "BoughtFrom_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Samples_PositionId",
                table: "Samples",
                newName: "IX_Samples_PositionID");

            migrationBuilder.RenameColumn(
                name: "AvailableQuality_Value",
                table: "Reagents",
                newName: "UnusedQuality_Value");

            migrationBuilder.RenameColumn(
                name: "AvailableQuality_Unit",
                table: "Reagents",
                newName: "UnusedQuality_Unit");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Url",
                table: "Reagents",
                newName: "BoughtFrom_Url");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Name",
                table: "Reagents",
                newName: "BoughtFrom_Name");

            migrationBuilder.RenameColumn(
                name: "AvailableCubage_Value",
                table: "Reagents",
                newName: "Cubage_Value");

            migrationBuilder.RenameColumn(
                name: "AvailableCubage_Unit",
                table: "Reagents",
                newName: "Cubage_Unit");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Url",
                table: "Labwares",
                newName: "BoughtFrom_Url");

            migrationBuilder.RenameColumn(
                name: "PurchaseFrom_Name",
                table: "Labwares",
                newName: "BoughtFrom_Name");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Samples",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Samples",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Samples",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Reagents",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reagents",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Reagents",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Labwares",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Labwares",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Labwares",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Labwares",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SubClass",
                table: "Devices",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Positions_PositionID",
                table: "Samples",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
