using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddDictData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("57cd18af-26e3-4aa0-91b4-f6127ce80265"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("938926df-4c75-4a4e-88d0-487e5bf2ff1f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a44c25a1-b4e0-4925-a929-f7bcda3031f3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ac5ecc27-d7ae-44d3-831d-2486c854f740"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bef5a4e2-4581-4a44-9163-1390306f1c68"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d4c5e07b-a663-4c58-a3a8-1268e416f5c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e5561cfc-191f-4e8f-b639-03549c7e8e69"));

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("772d87c0-87a8-4a9f-9eed-ac03789badf6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("b18609d3-cfb3-480f-bb6b-6e68d2858d46") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("b7919203-5b26-4aad-82cc-dfcba56bcb89") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("f171f9a2-d4fa-4c4f-99a7-aec74e91e956") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("048c83ab-38a7-4583-a9f6-54b510387921") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("4a2675e0-78c9-4339-90f8-fd5f6d1a2c0a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("7d0f42de-cee3-459b-9766-c84c19efefbc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("ebeffd64-2c62-4fbe-9b07-c8fc9ed82160") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("45b5c253-94c1-4c5f-b3cb-e283a8711243") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("4c4d2f31-aa9b-4321-a1fc-591eab8bfb32") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("50211a2f-9aa9-4431-829b-c0e355c9cd07") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("7526a5cd-9635-4b4e-8281-15b9b00ebcb7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("3a167599-4fc9-4b5e-a3d2-e819151c5a10") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("8e88541e-a7b8-413d-9763-305a0db06cb1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("c3b44418-a8a5-44e0-acc0-139b2ed7a45c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("c3dc9cfb-72c1-46bf-a6e1-c1f27472a2cf") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("2027f88f-3562-4e02-948d-8ebc6b06f77a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("549db880-e764-4273-b489-e004dde5c19d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("d2ed3697-438a-482a-a9a7-d2d090df27c0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("f1c22dba-0990-4ac2-80a6-dcd50e150bd0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("2806e5f6-0913-4c86-a6fd-d3712b47b75b"), new Guid("87c3e722-b69c-4480-b0ec-0b42243fa21a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("0448d884-5b0c-456b-8feb-0d9fa3990415") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("1651bd6b-1c41-4fa5-8653-ba50fd87a306") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("504048ee-fbde-40df-90cc-7ae074eab642") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("dd499b8a-6d66-4d9a-8937-4cb576ddae76") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("5bb11723-1d83-42b1-bf40-5f91e321a387") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("ad833ada-c1fe-4f77-aee7-1bf014487cc5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("cd8b207c-4b13-4cc2-9b18-d9bf28a0c362") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("f96aa350-94b6-4437-a9f6-f64a13305a85") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("40d2ede0-becc-428f-bfd4-fe5bbbbd5749") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("934c1c56-8ca0-4ee1-abcc-3b6620b0cade") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("cbf711ac-7fcd-4567-b9d9-1002878d35f7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("cdc1ddd8-c48b-4fa5-8900-6b30806a6175") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("46f040e7-6e9c-4876-989f-8aca2a43892a"), new Guid("6a9f2a8d-a381-435b-be9c-cf13d0aefb39") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("8f99a12a-332d-43f2-8d95-d20f80cfb90d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("d1154d60-f1d3-46d1-87b8-14abd32dfd4e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("e727894f-d0fe-4a61-9c55-058dbb807485") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("fd0b874f-bd7a-432f-a94d-f7694fb63fdc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("147c1e94-df99-407c-bc5d-32db5ef4d2c2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("7f179360-1bdf-4578-9e91-6501030bc380") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("919e89fc-e015-4cab-a931-16fd197a32ae") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("e43f67ea-6a39-475d-8e33-2e17bc31a110") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("663ec245-a1fa-488f-9ce6-09f8a2b8c246") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("72d159ef-0b5e-4ed7-b109-f85c816163fd") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("8bf1c7ca-34d6-4f8d-8d18-7bc204879ed5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("e69066d2-051c-465c-9ddc-794cfe62a692") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("7d03be34-6fb6-4dea-9085-27ee5f4f1323") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("9bf5c256-b15c-4350-a958-df4c2a3d9f13") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("a3895501-2917-47d4-951e-3234134f30ea") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("d39ffa41-7160-4cce-8a06-ffbf4101821c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("0bad6c29-27a7-4cab-b154-f1db3732fd40") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("99d0b4bb-12cc-4f97-8d3d-d9a870ebe814") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("b7070bc7-7ac0-4f66-a874-b131486e7893") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("d74bdbf7-c019-41e2-81c9-9c7f57228234") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("13348422-197b-4ea6-b19c-e21463ea713f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("ae756e5a-80f7-4920-b594-edc9db4a2326") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("c1c6209c-4021-4a56-a32e-7d88ea92d336") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("d1367b99-84bf-4a19-9e21-ec344dceb17d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("8b1a27cc-d6b0-4663-940e-84bd94ec003b"), new Guid("42248e94-7021-4b3e-a959-4b552fe783fa") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("4533bbb4-6b8d-4333-9882-d340910ca371") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("55e8ae74-5705-4d5a-b504-2de42c712593") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("c08e1bb1-cc50-4dc1-b633-76efb7824b21") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("c690cc78-aa0b-4898-a81b-9b7c9c2e7ac5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("ce9ce7b3-c7af-4c51-b1b5-6d2492eac5c6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c08903f4-e213-4b0b-92cc-94215e3c5231"), new Guid("22f252e5-c3e8-4501-aca4-118b8cfd2600") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("11299edd-571d-4aee-983c-a45dd27b81e7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("2470d27f-5194-4871-aefc-22ce13c82681") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("82903849-06bb-4a6e-92c9-d40dbf20625f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("a66410d3-df7e-46f2-8535-7dab18f1b191") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("0fc0ecbc-6470-465a-9b01-9db147698428") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("4ad196d3-5ed8-47af-9ca4-45a731dbc4b2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("a3d61144-4e3e-46f3-a445-f7f9be882844") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("f65bcbd0-8426-4c13-9d20-8f2550d7ea35") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("fe5b706c-cf43-4467-8341-6e20980d2d6e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("2a141afe-0acf-4437-90c6-bc7bbf96307c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("71ad007d-3fb8-4a1b-bfe2-4e68aa62da6c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("cc8714d0-2f55-4eb6-9951-34e7a31b2896") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("d1acf2f5-c2a9-452e-9489-c6bb970a0aea") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("fd518834-4281-4cab-a7d5-efcfa69b3632"), new Guid("d99b42e1-db69-42a4-9e5d-b8b780a9a23a") });

            migrationBuilder.DeleteData(
                table: "UserDepartmentRole",
                keyColumns: new[] { "UserId", "DepartmentId", "RoleId" },
                keyValues: new object[] { new Guid("9525002b-2459-4dec-bd40-c5ebb2060cf4"), new Guid("28189d8c-466f-42b7-aab8-9e2592bd6961"), new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81") });

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0448d884-5b0c-456b-8feb-0d9fa3990415"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("048c83ab-38a7-4583-a9f6-54b510387921"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0bad6c29-27a7-4cab-b154-f1db3732fd40"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0fc0ecbc-6470-465a-9b01-9db147698428"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("11299edd-571d-4aee-983c-a45dd27b81e7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("13348422-197b-4ea6-b19c-e21463ea713f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("147c1e94-df99-407c-bc5d-32db5ef4d2c2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1651bd6b-1c41-4fa5-8653-ba50fd87a306"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2027f88f-3562-4e02-948d-8ebc6b06f77a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("22f252e5-c3e8-4501-aca4-118b8cfd2600"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2470d27f-5194-4871-aefc-22ce13c82681"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2a141afe-0acf-4437-90c6-bc7bbf96307c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3a167599-4fc9-4b5e-a3d2-e819151c5a10"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("40d2ede0-becc-428f-bfd4-fe5bbbbd5749"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("42248e94-7021-4b3e-a959-4b552fe783fa"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4533bbb4-6b8d-4333-9882-d340910ca371"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("45b5c253-94c1-4c5f-b3cb-e283a8711243"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4a2675e0-78c9-4339-90f8-fd5f6d1a2c0a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4ad196d3-5ed8-47af-9ca4-45a731dbc4b2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4c4d2f31-aa9b-4321-a1fc-591eab8bfb32"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("50211a2f-9aa9-4431-829b-c0e355c9cd07"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("504048ee-fbde-40df-90cc-7ae074eab642"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("549db880-e764-4273-b489-e004dde5c19d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("55e8ae74-5705-4d5a-b504-2de42c712593"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5bb11723-1d83-42b1-bf40-5f91e321a387"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("663ec245-a1fa-488f-9ce6-09f8a2b8c246"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6a9f2a8d-a381-435b-be9c-cf13d0aefb39"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("71ad007d-3fb8-4a1b-bfe2-4e68aa62da6c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("72d159ef-0b5e-4ed7-b109-f85c816163fd"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7526a5cd-9635-4b4e-8281-15b9b00ebcb7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("772d87c0-87a8-4a9f-9eed-ac03789badf6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7d03be34-6fb6-4dea-9085-27ee5f4f1323"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7d0f42de-cee3-459b-9766-c84c19efefbc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7f179360-1bdf-4578-9e91-6501030bc380"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("82903849-06bb-4a6e-92c9-d40dbf20625f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("87c3e722-b69c-4480-b0ec-0b42243fa21a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8bf1c7ca-34d6-4f8d-8d18-7bc204879ed5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8e88541e-a7b8-413d-9763-305a0db06cb1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8f99a12a-332d-43f2-8d95-d20f80cfb90d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("919e89fc-e015-4cab-a931-16fd197a32ae"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("934c1c56-8ca0-4ee1-abcc-3b6620b0cade"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("99d0b4bb-12cc-4f97-8d3d-d9a870ebe814"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9bf5c256-b15c-4350-a958-df4c2a3d9f13"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a3895501-2917-47d4-951e-3234134f30ea"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a3d61144-4e3e-46f3-a445-f7f9be882844"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a66410d3-df7e-46f2-8535-7dab18f1b191"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ad833ada-c1fe-4f77-aee7-1bf014487cc5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ae756e5a-80f7-4920-b594-edc9db4a2326"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b18609d3-cfb3-480f-bb6b-6e68d2858d46"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b7070bc7-7ac0-4f66-a874-b131486e7893"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b7919203-5b26-4aad-82cc-dfcba56bcb89"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c08e1bb1-cc50-4dc1-b633-76efb7824b21"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c1c6209c-4021-4a56-a32e-7d88ea92d336"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c3b44418-a8a5-44e0-acc0-139b2ed7a45c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c3dc9cfb-72c1-46bf-a6e1-c1f27472a2cf"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c690cc78-aa0b-4898-a81b-9b7c9c2e7ac5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cbf711ac-7fcd-4567-b9d9-1002878d35f7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cc8714d0-2f55-4eb6-9951-34e7a31b2896"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cd8b207c-4b13-4cc2-9b18-d9bf28a0c362"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cdc1ddd8-c48b-4fa5-8900-6b30806a6175"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ce9ce7b3-c7af-4c51-b1b5-6d2492eac5c6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d1154d60-f1d3-46d1-87b8-14abd32dfd4e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d1367b99-84bf-4a19-9e21-ec344dceb17d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d1acf2f5-c2a9-452e-9489-c6bb970a0aea"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d2ed3697-438a-482a-a9a7-d2d090df27c0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d39ffa41-7160-4cce-8a06-ffbf4101821c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d74bdbf7-c019-41e2-81c9-9c7f57228234"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d99b42e1-db69-42a4-9e5d-b8b780a9a23a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dd499b8a-6d66-4d9a-8937-4cb576ddae76"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e43f67ea-6a39-475d-8e33-2e17bc31a110"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e69066d2-051c-465c-9ddc-794cfe62a692"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e727894f-d0fe-4a61-9c55-058dbb807485"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ebeffd64-2c62-4fbe-9b07-c8fc9ed82160"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f171f9a2-d4fa-4c4f-99a7-aec74e91e956"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f1c22dba-0990-4ac2-80a6-dcd50e150bd0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f65bcbd0-8426-4c13-9d20-8f2550d7ea35"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f96aa350-94b6-4437-a9f6-f64a13305a85"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fd0b874f-bd7a-432f-a94d-f7694fb63fdc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fe5b706c-cf43-4467-8341-6e20980d2d6e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("28189d8c-466f-42b7-aab8-9e2592bd6961"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9525002b-2459-4dec-bd40-c5ebb2060cf4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("169af775-c9e0-417c-950d-190bc12cc65a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2806e5f6-0913-4c86-a6fd-d3712b47b75b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("354ccee8-859b-44f5-8069-b053190ee170"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("46f040e7-6e9c-4876-989f-8aca2a43892a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8b1a27cc-d6b0-4663-940e-84bd94ec003b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c08903f4-e213-4b0b-92cc-94215e3c5231"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fd518834-4281-4cab-a7d5-efcfa69b3632"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ContactNumber", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Manager", "Name", "OrdinalNumber", "ParentId" },
                values: new object[] { new Guid("7f0d9e25-b4b3-4607-a568-fd503eaf5da7"), "13245679856", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(1822), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "张三", "深圳镁伽", 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "DictItems",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "KeyName", "LastModifiedAt", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("73189c40-606d-46ed-9d8e-426e9b5e08ad"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(556), false, "质量", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ng,μg,mg,g,kg" },
                    { new Guid("dd5ce7ac-86dd-484b-a158-aac8e0f05713"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(554), false, "供应商", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen" },
                    { new Guid("b91d7ee0-7519-4931-94ff-7c2a7ebfa5cf"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(549), false, "体积", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "μL,mL", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("f8d1359f-3029-47af-9af4-dd9cd334036b"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(547), false, "种族", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Black,Caucasian,Asian,ELSE" },
                    { new Guid("2ba03fd0-8d4f-45eb-9f3c-7e60e037a8cd"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(552), false, "浓度", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "%,mg/ml" },
                    { new Guid("89d1aacb-3209-448c-8fa5-1117e792a273"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(538), false, "疾病", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("df598876-a501-468e-a2d2-3ab605b044be"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(535), false, "培养方式", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Adherent,Suspension,ELSE" },
                    { new Guid("09b0711a-6966-4440-8c22-8b03cb9199fe"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(516), false, "细胞系种类", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "epithelial,ELSE" },
                    { new Guid("e2ac5b99-e9d3-482c-9df0-69f0c07d5538"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(74), false, "组织类型", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "cervix,lung,ELSE" },
                    { new Guid("161cb133-76ec-47aa-8e11-9106ad3db918"), new DateTime(2021, 8, 4, 14, 2, 23, 302, DateTimeKind.Local).AddTicks(545), false, "性别", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Female,Male,ELSE" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Component", "CreatedAt", "Hidden", "Icon", "IsActive", "IsDeleted", "LastModifiedAt", "Name", "OrdinalNumber", "ParentId", "Path", "Redirect", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { new Guid("b407ee58-dd9e-46b3-ab02-489f3ca8a240"), "排程", "items/aps/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8157), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_aps", 25, new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "aps", null, "排程", 1, "aps" },
                    { new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "项目管理", "Layout", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8089), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itiems", 20, new Guid("00000000-0000-0000-0000-000000000000"), "/items", "/items", "项目管理", 0, "/items" },
                    { new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), "Protocol Step管理", "items/proStep/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8092), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_protocol", 21, new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "protocol", null, "Protocol Step管理", 1, "protocol" },
                    { new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), "节点管理", "items/node/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8101), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_node", 22, new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "node", null, "节点管理", 1, "node" },
                    { new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), "项目管理", "items/project/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8110), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_project", 23, new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "project", null, "项目管理", 1, "project" },
                    { new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), "Take管理", "items/task/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8118), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_take", 24, new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"), "take", null, "Take管理", 1, "take" },
                    { new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "生产管理", "Layout", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8161), false, "el-icon-s-cooperation", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce", 26, new Guid("00000000-0000-0000-0000-000000000000"), "/produce", "/produce", "生产管理", 0, "/produce" },
                    { new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), "无菌检测", "produce/asepticCheck/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8203), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_asepticCheck", 32, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "asepticCheck", null, "无菌检测", 1, "asepticCheck" },
                    { new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), "分子克隆", "produce/clone/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8177), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_clone", 28, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "clone", null, "分子克隆", 1, "clone" },
                    { new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), "质粒纯化", "produce/plasmid/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8184), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_plasmid", 29, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "plasmid", null, "质粒纯化", 1, "plasmid" },
                    { new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"), "qPCR检测", "produce/qPCR/indexproduce/qPCR/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8190), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_qPCR", 30, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "qPCR", null, "qPCR检测", 1, "qPCR" },
                    { new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), "SDS-PAGE检测", "produce/SDS/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8198), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_SDS", 31, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "SDS", null, "SDS-PAGE检测", 1, "SDS" },
                    { new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), "今日任务", "task/today/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8082), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_today", 19, new Guid("92355936-3b04-41a4-bc8d-692836d0935b"), "today", null, "今日任务", 1, "today" },
                    { new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), "入库登记", "produce/wareHouse/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8208), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_wareHouse", 33, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "wareHouse", null, "入库登记", 1, "wareHouse" },
                    { new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), "发货记录", "produce/deliverGoods/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8215), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_deliverGoods", 34, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "deliverGoods", null, "发货记录", 1, "deliverGoods" },
                    { new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "订单", "produce/order/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8164), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_order", 27, new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"), "order", null, "订单", 1, "order" },
                    { new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), "我的任务", "task/myTask/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8072), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_owner", 18, new Guid("92355936-3b04-41a4-bc8d-692836d0935b"), "owner", null, "我的任务", 1, "owner" },
                    { new Guid("d9ae9fb8-127e-444d-9cbe-e7e4a71d46c6"), "耗材管理", "basic/material/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8043), false, "el-icon-printer", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_material", 13, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "material", null, "耗材管理", 1, "material" },
                    { new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), "样本管理", "sample/sample/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8060), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample_sample", 16, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "sample", null, "样本管理", 1, "sample" },
                    { new Guid("01391115-b139-4712-b555-8b241ab356f5"), "系统管理", "Layout", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(5247), false, "el-icon-s-tools", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", 1, new Guid("00000000-0000-0000-0000-000000000000"), "/system", "/system/user", "系统管理", 0, "/system" },
                    { new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "用户管理", "system/user/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7113), false, "el-icon-user", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_user", 2, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "user", null, "用户管理", 1, "user" },
                    { new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), "技能管理", "system/skill/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7905), false, "skill", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_skill", 3, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "skill", null, "技能管理", 1, "skill" },
                    { new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), "部门管理", "system/department/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7921), false, "peoples", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_department", 4, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "department", null, "部门管理", 1, "department" },
                    { new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), "角色管理", "system/role/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7978), false, "el-icon-s-opportunity", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_role", 5, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "role", null, "角色管理", 1, "role" },
                    { new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), "菜单管理", "system/menu/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7987), false, "el-icon-menu", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_menu", 6, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "menu", null, "菜单管理", 1, "menu" },
                    { new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "字典项管理", "system/dictionary/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(7997), false, "el-icon-tickets", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_dictionary", 7, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "dictionary", null, "字典项管理", 1, "dictionary" },
                    { new Guid("e9138d88-16b6-4328-8000-cd199250c52e"), "日志管理", "system/logs/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8005), false, "el-icon-edit-outline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_log", 8, new Guid("01391115-b139-4712-b555-8b241ab356f5"), "log", null, "日志管理", 1, "log" },
                    { new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "基础数据配置", "Layout", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8011), false, "el-icon-files", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic", 9, new Guid("00000000-0000-0000-0000-000000000000"), "/basic", "/basic/user", "基础数据配置", 0, "/basic" },
                    { new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), "物种管理", "basic/species/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8021), false, "el-icon-more", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_species", 10, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "species", null, "物种管理", 1, "species" },
                    { new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), "细胞管理", "basic/cells/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8030), false, "cells", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_cells", 11, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "cells", null, "细胞管理", 1, "cells" },
                    { new Guid("142c6afc-6c03-493d-bd81-12c573fcdb85"), "位置管理", "basic/place/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8039), false, "el-icon-location", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_place", 12, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "place", null, "位置管理", 1, "place" },
                    { new Guid("648d6d97-bde2-4e9f-92d1-16deae5cbe06"), "试剂管理", "basic/reagent/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8047), false, "chemistry", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_reagent", 14, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "reagent", null, "试剂管理", 1, "reagent" },
                    { new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), "设备管理", "basic/equipment/index", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8053), false, "el-icon-suitcase", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_equipment", 15, new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"), "equipment", null, "设备管理", 1, "equipment" },
                    { new Guid("92355936-3b04-41a4-bc8d-692836d0935b"), "任务管理", "Layout", new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(8069), false, "el-icon-document-copy", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task", 17, new Guid("00000000-0000-0000-0000-000000000000"), "/task", "/task/today", "任务管理", 0, "/task" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Name" },
                values: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new DateTime(2021, 8, 4, 14, 2, 23, 301, DateTimeKind.Local).AddTicks(3474), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "超级管理员" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "IsActive", "IsDeleted", "LastModifiedAt", "MobileNumber", "Password", "UserName", "WorkTime" },
                values: new object[] { new Guid("dc09a30c-699c-420a-82fe-37476dda1890"), new DateTime(2021, 8, 4, 14, 2, 23, 298, DateTimeKind.Local).AddTicks(7643), "234298234@qq.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13523429876", null, "admin@admin.com", "8:00-9:00" });

            migrationBuilder.InsertData(
                table: "Button",
                columns: new[] { "Id", "Code", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("1d69715a-8bd6-4ce5-9922-0ae6f8d72aba"), "QueryUser", new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "查询用户" },
                    { new Guid("68624aca-6794-47af-9b2c-e5163c723ec0"), "AddTake", new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), "新增Take" },
                    { new Guid("683055b8-6d45-4d3d-b0cc-f1f001e02f21"), "QueryTake", new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), "查询Take" },
                    { new Guid("441d1453-662c-4227-810b-345ada55a063"), "DeleteProject", new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), "删除项目" },
                    { new Guid("a4ef5f38-c096-4a41-8ce6-2659b95f2222"), "UpdateProject", new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), "修改项目" },
                    { new Guid("f1a7d4cf-039b-423f-8f15-eb024016c271"), "AddProject", new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), "新增项目" },
                    { new Guid("a248465e-0469-4d43-9d85-dab7e4c2ee35"), "QueryProject", new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), "查询项目" },
                    { new Guid("9dd59eba-7a0f-4f34-938b-1ef9e0f108a7"), "DeleteNode", new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), "删除节点" },
                    { new Guid("4e95416d-fc6a-4990-87a8-9f6bf97d0110"), "UpdateNode", new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), "修改节点" },
                    { new Guid("0ba90fe1-ff93-45ff-b5dd-34bb191913a1"), "AddNode", new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), "新增节点" },
                    { new Guid("718a2127-2b7f-4dff-bfbd-bd523b87b065"), "QueryNode", new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), "查询节点" },
                    { new Guid("6c4923e0-b13d-4604-b32d-a03235e24c53"), "DeleteProtocolStep", new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), "删除ProtocolStep" },
                    { new Guid("1028415e-4daf-438f-bbf6-2c4b63119424"), "UpdateProtocolStep", new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), "修改ProtocolStep" },
                    { new Guid("fbb83a98-faeb-4198-9b70-ad7a13595a77"), "AddProtocolStep", new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), "新增ProtocolStep" },
                    { new Guid("58885f2a-cc81-42e3-8d33-5495a9f62e2a"), "QueryProtocolStep", new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), "查询ProtocolStep" },
                    { new Guid("2ae7e99c-a6d5-44d4-a8f3-507d4cfa4c1d"), "DeleteTask", new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), "删除今日任务" },
                    { new Guid("50e243d1-2b09-4d6d-87a3-2c71e5c5d180"), "UpdateTask", new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), "修改今日任务" },
                    { new Guid("a5e3dda1-6c94-4124-8c33-a84c17078465"), "AddTask", new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), "新增今日任务" },
                    { new Guid("751e709a-6320-493e-8ae8-6373155aeb1b"), "QueryTask", new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), "查询今日任务" },
                    { new Guid("4837cff0-0a49-4d3a-932f-a2971fa4e9e1"), "DeleteMyTask", new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), "删除我的任务" },
                    { new Guid("f87689fa-6ff5-45ae-b53e-e9fb6cb6b7df"), "UpdateTake", new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), "修改Take" },
                    { new Guid("9be7938d-3053-43d8-85fd-f6f6769d016d"), "DeleteTake", new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), "删除Take" },
                    { new Guid("c1ec031a-5b4f-4881-9076-25a5ebdc401f"), "QuerySchedule", new Guid("b407ee58-dd9e-46b3-ab02-489f3ca8a240"), "查询排程" },
                    { new Guid("c9bfee7a-c77f-4cea-87c2-63514ebb3219"), "QueryOrder", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "查询订单" },
                    { new Guid("d4a8ce4c-d623-47cb-9772-772c59a44968"), "QueryShipment", new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), "查询发货记录" },
                    { new Guid("89c69f20-bda0-479d-b194-4727a9c389ff"), "FinishWarehousing", new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), "完成入库记录" },
                    { new Guid("b3171048-ab03-4ee7-a1f9-55b823909ca4"), "QueryWarehousing", new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), "查询入库记录" },
                    { new Guid("28c73fcb-3334-417c-a2b8-7acf9fa53d11"), "FinishSterility", new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), "完成无菌检测" },
                    { new Guid("7a6b5d07-e2c7-4b72-979e-de0464a6f3e9"), "QuerySterility", new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), "查询无菌检测" },
                    { new Guid("075b2343-2578-4227-ae94-f60a5dacbeb6"), "FinishSdspage", new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), "完成SDS-PAGE检测" },
                    { new Guid("ffda1e5b-1ab8-42a5-86e8-56dfd94153c4"), "QuerySdspage", new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), "查询SDS-PAGE检测" },
                    { new Guid("8d5fe15e-6304-40c3-9efd-e7f3cd77912c"), "FinishPurifying", new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), "完成质粒纯化" },
                    { new Guid("5183be46-2d4e-4418-affe-d7bfd02b603b"), "QueryPurifying", new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), "查询质粒纯化" },
                    { new Guid("4d7333bc-191f-44f1-9db8-a8f60f7d724c"), "UpdateMyTask", new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), "修改我的任务" },
                    { new Guid("c155eb39-5b7b-4787-b8e3-dfd27b3e2d5b"), "FinishQpcr", new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), "完成qPCR检测" },
                    { new Guid("09902b31-1c05-4094-a7e1-3af8b88a5565"), "FinishCloning", new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), "完成分子克隆" },
                    { new Guid("de2bea7f-c84c-4b71-9d27-83fb608138fc"), "QueryCloning", new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), "查询分子克隆" },
                    { new Guid("bd32aeb7-168c-4a67-90ac-1ee5280d289a"), "FinishOrder", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "完成" },
                    { new Guid("347b9448-aa51-41c0-9e4f-a9f9ff7a829c"), "Warehousing", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "QC&入库" },
                    { new Guid("046641cc-41ac-4937-b621-f769dbc425d8"), "StartProduce", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "进入生产" },
                    { new Guid("def600da-e197-4dcf-b83b-4f9a291a5b20"), "PurifyPlasmid", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "质粒纯化" },
                    { new Guid("6a7d097f-9945-418d-82d7-f40544fdce37"), "CloneMolecule", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "分子克隆" },
                    { new Guid("91f6e8f6-f550-410f-8fec-633d7689f24a"), "UpdateOrder", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "修改订单" },
                    { new Guid("48bbc7e8-2bd3-42b8-901f-77a4529f6db0"), "AddOrder", new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), "新增订单" },
                    { new Guid("364ec6c5-4962-4610-b907-6c189c91b1db"), "QueryQpcr", new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), "查询qPCR检测" },
                    { new Guid("1069195a-0207-4bba-813c-e67af4b7077e"), "AddMyTask", new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), "新增我的任务" },
                    { new Guid("f00a4640-dc72-436b-81e4-5ae24b1a8165"), "QueryMyTask", new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), "查询我的任务" },
                    { new Guid("a94099cc-00ae-4ffb-b436-7a976ba31ce6"), "DeleteSample", new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), "删除样本" },
                    { new Guid("84e8059b-1ab5-4a16-a86a-71576931b20c"), "DeleteMenu", new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), "删除菜单" },
                    { new Guid("70ee8547-7219-4adc-b9ff-5ae20781f7e9"), "UpdateMenu", new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), "修改菜单" },
                    { new Guid("ec128b9a-650e-4ad1-9123-cdc0456956b9"), "AddMenu", new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), "新增菜单" },
                    { new Guid("9a89e85a-66d0-4215-9778-cb13d4178e2d"), "QueryMenu", new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), "查询菜单" },
                    { new Guid("13ef5794-9e54-4b38-8561-cf118e297f41"), "DeleteRole", new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), "删除角色" },
                    { new Guid("89cd1433-c1c8-42b5-9dcc-bd1b467c1849"), "UpdateRole", new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), "修改角色" },
                    { new Guid("54a5e294-cd7e-4148-8013-3613be0821c6"), "AddRole", new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), "新增角色" },
                    { new Guid("68534b4a-66ec-4ed7-9df4-f34af68b94b5"), "QueryRole", new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), "查询角色" },
                    { new Guid("552c28a8-d929-4f0c-8f07-0aa5637e5224"), "DeleteDepartment", new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), "删除部门" },
                    { new Guid("a606cc31-e09b-438f-ab36-6da256be38b8"), "QueryDict", new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "查询字典项" },
                    { new Guid("8eb144f3-aceb-419c-998a-2544f18fe7c9"), "UpdateDepartment", new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), "修改部门" },
                    { new Guid("3f6b21b8-dfc7-4dc3-b521-11a4e716e025"), "QueryDepartment", new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), "查询部门" },
                    { new Guid("ae81ea0a-28ac-4b30-bcd3-47548f3a1791"), "DeleteSkill", new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), "删除技能" },
                    { new Guid("57b25249-a86b-4c2d-89d1-1bca14d3481a"), "UpdateSkill", new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), "修改技能" },
                    { new Guid("012cda32-a2fb-43c6-9b76-2ec669f6fd35"), "AddSkill", new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), "新增技能" },
                    { new Guid("09ef5812-179a-4bb9-ae83-6d62dea75d43"), "QuerySkill", new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), "查询技能" },
                    { new Guid("daee4f52-497e-457c-9753-bc03c880a31b"), "ResetUser", new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "重置用户" },
                    { new Guid("a549899f-9ea4-47bc-b80c-7d395a8e4d5d"), "DeleteUser", new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "删除用户" },
                    { new Guid("13cf0cf9-a7ec-4750-b24d-2fac424eebcc"), "UpdateUser", new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "修改用户" },
                    { new Guid("c08f730b-9fac-4881-a1cc-e1425b7035a4"), "AddUser", new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), "新增用户" },
                    { new Guid("57ba6a34-b252-4b0d-86d0-126b3ac11a62"), "AddDepartment", new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), "新增部门" },
                    { new Guid("9cb4f820-f76e-442e-920d-7a7805cc46b2"), "FinishShipment", new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), "完成发货记录" },
                    { new Guid("a7cb75be-93fd-4233-acda-fcf8f5ebb9db"), "AddDict", new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "新增字典项" },
                    { new Guid("dd138026-b77e-4b7a-be6a-2ae9c558e4db"), "DeleteDict", new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "删除字典项" },
                    { new Guid("1aad03c0-cbf4-4039-bba4-df3339c65989"), "UpdateSample", new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), "修改样本" },
                    { new Guid("31c80f0d-6315-4794-b5e6-cdea6ef3b807"), "AddSample", new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), "新增样本" },
                    { new Guid("71e3d88a-3d34-4eb8-b785-8dc84a986d32"), "QuerySample", new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), "查询样本" },
                    { new Guid("c5ee4c47-f840-4ee0-99f9-6b8e7b7616fd"), "DeleteDevice", new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), "删除设备" },
                    { new Guid("15d664ec-bd9d-4923-a8c5-df07aee6ed86"), "UpdateDevice", new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), "修改设备" },
                    { new Guid("71dbfe2c-c6cf-4bd1-b38f-96f91408a5a6"), "AddDevice", new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), "新增设备" },
                    { new Guid("2a42c765-cedb-4b0f-9c83-dc0bac9a3b58"), "QueryDevice", new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), "查询设备" },
                    { new Guid("1390f9f1-d68e-47f3-a1ce-cf33311b9d7b"), "QueryReagent", new Guid("648d6d97-bde2-4e9f-92d1-16deae5cbe06"), "查询试剂" },
                    { new Guid("056b4897-9453-4029-86f5-3cd533dbd33b"), "QueryLabware", new Guid("d9ae9fb8-127e-444d-9cbe-e7e4a71d46c6"), "查询耗材" },
                    { new Guid("e9a78fd1-1e37-4ce9-a6c5-2a9390417979"), "UpdateDict", new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "修改字典项" },
                    { new Guid("8ca3359e-526c-42a4-9af1-edc3a8ce46a3"), "QueryPosition", new Guid("142c6afc-6c03-493d-bd81-12c573fcdb85"), "查询位置" },
                    { new Guid("5927c638-909c-4411-8bac-0feaf977ae13"), "UpdateCell", new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), "修改细胞" },
                    { new Guid("2e680f09-9e6a-407d-b4a1-c988005f72c7"), "AddCell", new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), "新增细胞" },
                    { new Guid("6311122a-0edd-428e-b5fa-2b7f3be06d7d"), "QueryCell", new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), "查询细胞" },
                    { new Guid("aa0ffbe2-72eb-41e9-8f3c-6847967d84ba"), "DeleteSpecies", new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), "删除物种" },
                    { new Guid("d3271dca-fe4c-4b84-b36f-c76347503f3f"), "UpdateSpecies", new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), "修改物种" },
                    { new Guid("edda64b2-08df-49ca-9a29-fe569ed8c662"), "AddSpecies", new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), "新增物种" },
                    { new Guid("5de2cbc6-89c8-43b4-aa74-a9d0b4a5bf3d"), "QuerySpecies", new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), "查询物种" },
                    { new Guid("e9104308-1843-4750-a147-29df6195f1df"), "QueryLog", new Guid("e9138d88-16b6-4328-8000-cd199250c52e"), "查询日志" },
                    { new Guid("cf6210e8-98c9-4c8a-a0f5-9b0394676a8d"), "UpdateDictValue", new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), "修改字典项值" },
                    { new Guid("fc80caf3-9fcf-4d34-ad8a-f5faa2080828"), "DeleteCell", new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), "删除细胞" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartmentRole",
                columns: new[] { "UserId", "DepartmentId", "RoleId" },
                values: new object[] { new Guid("dc09a30c-699c-420a-82fe-37476dda1890"), new Guid("7f0d9e25-b4b3-4607-a568-fd503eaf5da7"), new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f") });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" },
                values: new object[,]
                {
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("1d69715a-8bd6-4ce5-9922-0ae6f8d72aba") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("683055b8-6d45-4d3d-b0cc-f1f001e02f21") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("441d1453-662c-4227-810b-345ada55a063") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("a4ef5f38-c096-4a41-8ce6-2659b95f2222") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("f1a7d4cf-039b-423f-8f15-eb024016c271") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("a248465e-0469-4d43-9d85-dab7e4c2ee35") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("9dd59eba-7a0f-4f34-938b-1ef9e0f108a7") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("4e95416d-fc6a-4990-87a8-9f6bf97d0110") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("0ba90fe1-ff93-45ff-b5dd-34bb191913a1") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("718a2127-2b7f-4dff-bfbd-bd523b87b065") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("6c4923e0-b13d-4604-b32d-a03235e24c53") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("1028415e-4daf-438f-bbf6-2c4b63119424") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("fbb83a98-faeb-4198-9b70-ad7a13595a77") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("58885f2a-cc81-42e3-8d33-5495a9f62e2a") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("2ae7e99c-a6d5-44d4-a8f3-507d4cfa4c1d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("50e243d1-2b09-4d6d-87a3-2c71e5c5d180") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("a5e3dda1-6c94-4124-8c33-a84c17078465") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("751e709a-6320-493e-8ae8-6373155aeb1b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("4837cff0-0a49-4d3a-932f-a2971fa4e9e1") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("4d7333bc-191f-44f1-9db8-a8f60f7d724c") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("68624aca-6794-47af-9b2c-e5163c723ec0") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("f87689fa-6ff5-45ae-b53e-e9fb6cb6b7df") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("9be7938d-3053-43d8-85fd-f6f6769d016d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b407ee58-dd9e-46b3-ab02-489f3ca8a240"), new Guid("c1ec031a-5b4f-4881-9076-25a5ebdc401f") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), new Guid("89c69f20-bda0-479d-b194-4727a9c389ff") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), new Guid("b3171048-ab03-4ee7-a1f9-55b823909ca4") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), new Guid("28c73fcb-3334-417c-a2b8-7acf9fa53d11") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), new Guid("7a6b5d07-e2c7-4b72-979e-de0464a6f3e9") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), new Guid("075b2343-2578-4227-ae94-f60a5dacbeb6") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), new Guid("ffda1e5b-1ab8-42a5-86e8-56dfd94153c4") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), new Guid("8d5fe15e-6304-40c3-9efd-e7f3cd77912c") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), new Guid("5183be46-2d4e-4418-affe-d7bfd02b603b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"), new Guid("c155eb39-5b7b-4787-b8e3-dfd27b3e2d5b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("1069195a-0207-4bba-813c-e67af4b7077e") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"), new Guid("364ec6c5-4962-4610-b907-6c189c91b1db") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), new Guid("de2bea7f-c84c-4b71-9d27-83fb608138fc") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("bd32aeb7-168c-4a67-90ac-1ee5280d289a") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("347b9448-aa51-41c0-9e4f-a9f9ff7a829c") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("046641cc-41ac-4937-b621-f769dbc425d8") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("def600da-e197-4dcf-b83b-4f9a291a5b20") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("6a7d097f-9945-418d-82d7-f40544fdce37") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("91f6e8f6-f550-410f-8fec-633d7689f24a") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("48bbc7e8-2bd3-42b8-901f-77a4529f6db0") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("c9bfee7a-c77f-4cea-87c2-63514ebb3219") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), new Guid("09902b31-1c05-4094-a7e1-3af8b88a5565") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), new Guid("d4a8ce4c-d623-47cb-9772-772c59a44968") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("f00a4640-dc72-436b-81e4-5ae24b1a8165") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("1aad03c0-cbf4-4039-bba4-df3339c65989") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("70ee8547-7219-4adc-b9ff-5ae20781f7e9") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("ec128b9a-650e-4ad1-9123-cdc0456956b9") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("9a89e85a-66d0-4215-9778-cb13d4178e2d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("13ef5794-9e54-4b38-8561-cf118e297f41") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("89cd1433-c1c8-42b5-9dcc-bd1b467c1849") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("54a5e294-cd7e-4148-8013-3613be0821c6") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("68534b4a-66ec-4ed7-9df4-f34af68b94b5") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("552c28a8-d929-4f0c-8f07-0aa5637e5224") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("8eb144f3-aceb-419c-998a-2544f18fe7c9") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("57ba6a34-b252-4b0d-86d0-126b3ac11a62") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("3f6b21b8-dfc7-4dc3-b521-11a4e716e025") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("ae81ea0a-28ac-4b30-bcd3-47548f3a1791") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("57b25249-a86b-4c2d-89d1-1bca14d3481a") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("012cda32-a2fb-43c6-9b76-2ec669f6fd35") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("09ef5812-179a-4bb9-ae83-6d62dea75d43") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("daee4f52-497e-457c-9753-bc03c880a31b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("a549899f-9ea4-47bc-b80c-7d395a8e4d5d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("13cf0cf9-a7ec-4750-b24d-2fac424eebcc") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("c08f730b-9fac-4881-a1cc-e1425b7035a4") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("84e8059b-1ab5-4a16-a86a-71576931b20c") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("a606cc31-e09b-438f-ab36-6da256be38b8") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("a7cb75be-93fd-4233-acda-fcf8f5ebb9db") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("e9a78fd1-1e37-4ce9-a6c5-2a9390417979") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("31c80f0d-6315-4794-b5e6-cdea6ef3b807") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("71e3d88a-3d34-4eb8-b785-8dc84a986d32") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("c5ee4c47-f840-4ee0-99f9-6b8e7b7616fd") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("15d664ec-bd9d-4923-a8c5-df07aee6ed86") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("71dbfe2c-c6cf-4bd1-b38f-96f91408a5a6") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("2a42c765-cedb-4b0f-9c83-dc0bac9a3b58") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("648d6d97-bde2-4e9f-92d1-16deae5cbe06"), new Guid("1390f9f1-d68e-47f3-a1ce-cf33311b9d7b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d9ae9fb8-127e-444d-9cbe-e7e4a71d46c6"), new Guid("056b4897-9453-4029-86f5-3cd533dbd33b") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("142c6afc-6c03-493d-bd81-12c573fcdb85"), new Guid("8ca3359e-526c-42a4-9af1-edc3a8ce46a3") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("a94099cc-00ae-4ffb-b436-7a976ba31ce6") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("fc80caf3-9fcf-4d34-ad8a-f5faa2080828") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("2e680f09-9e6a-407d-b4a1-c988005f72c7") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("6311122a-0edd-428e-b5fa-2b7f3be06d7d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("aa0ffbe2-72eb-41e9-8f3c-6847967d84ba") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("d3271dca-fe4c-4b84-b36f-c76347503f3f") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("edda64b2-08df-49ca-9a29-fe569ed8c662") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("5de2cbc6-89c8-43b4-aa74-a9d0b4a5bf3d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("e9138d88-16b6-4328-8000-cd199250c52e"), new Guid("e9104308-1843-4750-a147-29df6195f1df") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("cf6210e8-98c9-4c8a-a0f5-9b0394676a8d") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("dd138026-b77e-4b7a-be6a-2ae9c558e4db") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("5927c638-909c-4411-8bac-0feaf977ae13") },
                    { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), new Guid("9cb4f820-f76e-442e-920d-7a7805cc46b2") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("09b0711a-6966-4440-8c22-8b03cb9199fe"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("161cb133-76ec-47aa-8e11-9106ad3db918"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("2ba03fd0-8d4f-45eb-9f3c-7e60e037a8cd"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("73189c40-606d-46ed-9d8e-426e9b5e08ad"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("89d1aacb-3209-448c-8fa5-1117e792a273"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("b91d7ee0-7519-4931-94ff-7c2a7ebfa5cf"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("dd5ce7ac-86dd-484b-a158-aac8e0f05713"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("df598876-a501-468e-a2d2-3ab605b044be"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("e2ac5b99-e9d3-482c-9df0-69f0c07d5538"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("f8d1359f-3029-47af-9af4-dd9cd334036b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("01391115-b139-4712-b555-8b241ab356f5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("92355936-3b04-41a4-bc8d-692836d0935b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a15625b7-1fd1-4116-b4de-4a1cd7b26885"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c2556e1e-8d4a-4b20-9fe6-85a1310dc65e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("efce0453-d19a-4171-8caf-8b8d6dee3688"));

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("1028415e-4daf-438f-bbf6-2c4b63119424") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("58885f2a-cc81-42e3-8d33-5495a9f62e2a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("6c4923e0-b13d-4604-b32d-a03235e24c53") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"), new Guid("fbb83a98-faeb-4198-9b70-ad7a13595a77") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("142c6afc-6c03-493d-bd81-12c573fcdb85"), new Guid("8ca3359e-526c-42a4-9af1-edc3a8ce46a3") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), new Guid("5183be46-2d4e-4418-affe-d7bfd02b603b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"), new Guid("8d5fe15e-6304-40c3-9efd-e7f3cd77912c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("441d1453-662c-4227-810b-345ada55a063") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("a248465e-0469-4d43-9d85-dab7e4c2ee35") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("a4ef5f38-c096-4a41-8ce6-2659b95f2222") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"), new Guid("f1a7d4cf-039b-423f-8f15-eb024016c271") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), new Guid("075b2343-2578-4227-ae94-f60a5dacbeb6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"), new Guid("ffda1e5b-1ab8-42a5-86e8-56dfd94153c4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), new Guid("9cb4f820-f76e-442e-920d-7a7805cc46b2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"), new Guid("d4a8ce4c-d623-47cb-9772-772c59a44968") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("1069195a-0207-4bba-813c-e67af4b7077e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("4837cff0-0a49-4d3a-932f-a2971fa4e9e1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("4d7333bc-191f-44f1-9db8-a8f60f7d724c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"), new Guid("f00a4640-dc72-436b-81e4-5ae24b1a8165") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("1aad03c0-cbf4-4039-bba4-df3339c65989") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("31c80f0d-6315-4794-b5e6-cdea6ef3b807") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("71e3d88a-3d34-4eb8-b785-8dc84a986d32") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"), new Guid("a94099cc-00ae-4ffb-b436-7a976ba31ce6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("a606cc31-e09b-438f-ab36-6da256be38b8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("a7cb75be-93fd-4233-acda-fcf8f5ebb9db") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("cf6210e8-98c9-4c8a-a0f5-9b0394676a8d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("dd138026-b77e-4b7a-be6a-2ae9c558e4db") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"), new Guid("e9a78fd1-1e37-4ce9-a6c5-2a9390417979") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("648d6d97-bde2-4e9f-92d1-16deae5cbe06"), new Guid("1390f9f1-d68e-47f3-a1ce-cf33311b9d7b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("046641cc-41ac-4937-b621-f769dbc425d8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("347b9448-aa51-41c0-9e4f-a9f9ff7a829c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("48bbc7e8-2bd3-42b8-901f-77a4529f6db0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("6a7d097f-9945-418d-82d7-f40544fdce37") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("91f6e8f6-f550-410f-8fec-633d7689f24a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("bd32aeb7-168c-4a67-90ac-1ee5280d289a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("c9bfee7a-c77f-4cea-87c2-63514ebb3219") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"), new Guid("def600da-e197-4dcf-b83b-4f9a291a5b20") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("13ef5794-9e54-4b38-8561-cf118e297f41") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("54a5e294-cd7e-4148-8013-3613be0821c6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("68534b4a-66ec-4ed7-9df4-f34af68b94b5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"), new Guid("89cd1433-c1c8-42b5-9dcc-bd1b467c1849") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), new Guid("09902b31-1c05-4094-a7e1-3af8b88a5565") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"), new Guid("de2bea7f-c84c-4b71-9d27-83fb608138fc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("0ba90fe1-ff93-45ff-b5dd-34bb191913a1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("4e95416d-fc6a-4990-87a8-9f6bf97d0110") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("718a2127-2b7f-4dff-bfbd-bd523b87b065") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"), new Guid("9dd59eba-7a0f-4f34-938b-1ef9e0f108a7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("70ee8547-7219-4adc-b9ff-5ae20781f7e9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("84e8059b-1ab5-4a16-a86a-71576931b20c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("9a89e85a-66d0-4215-9778-cb13d4178e2d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"), new Guid("ec128b9a-650e-4ad1-9123-cdc0456956b9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("13cf0cf9-a7ec-4750-b24d-2fac424eebcc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("1d69715a-8bd6-4ce5-9922-0ae6f8d72aba") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("a549899f-9ea4-47bc-b80c-7d395a8e4d5d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("c08f730b-9fac-4881-a1cc-e1425b7035a4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"), new Guid("daee4f52-497e-457c-9753-bc03c880a31b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("012cda32-a2fb-43c6-9b76-2ec669f6fd35") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("09ef5812-179a-4bb9-ae83-6d62dea75d43") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("57b25249-a86b-4c2d-89d1-1bca14d3481a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"), new Guid("ae81ea0a-28ac-4b30-bcd3-47548f3a1791") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("5de2cbc6-89c8-43b4-aa74-a9d0b4a5bf3d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("aa0ffbe2-72eb-41e9-8f3c-6847967d84ba") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("d3271dca-fe4c-4b84-b36f-c76347503f3f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"), new Guid("edda64b2-08df-49ca-9a29-fe569ed8c662") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b407ee58-dd9e-46b3-ab02-489f3ca8a240"), new Guid("c1ec031a-5b4f-4881-9076-25a5ebdc401f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("683055b8-6d45-4d3d-b0cc-f1f001e02f21") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("68624aca-6794-47af-9b2c-e5163c723ec0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("9be7938d-3053-43d8-85fd-f6f6769d016d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"), new Guid("f87689fa-6ff5-45ae-b53e-e9fb6cb6b7df") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), new Guid("28c73fcb-3334-417c-a2b8-7acf9fa53d11") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"), new Guid("7a6b5d07-e2c7-4b72-979e-de0464a6f3e9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("2ae7e99c-a6d5-44d4-a8f3-507d4cfa4c1d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("50e243d1-2b09-4d6d-87a3-2c71e5c5d180") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("751e709a-6320-493e-8ae8-6373155aeb1b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("be04a468-225f-45a0-b417-13f3da3618d6"), new Guid("a5e3dda1-6c94-4124-8c33-a84c17078465") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("3f6b21b8-dfc7-4dc3-b521-11a4e716e025") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("552c28a8-d929-4f0c-8f07-0aa5637e5224") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("57ba6a34-b252-4b0d-86d0-126b3ac11a62") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"), new Guid("8eb144f3-aceb-419c-998a-2544f18fe7c9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), new Guid("89c69f20-bda0-479d-b194-4727a9c389ff") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"), new Guid("b3171048-ab03-4ee7-a1f9-55b823909ca4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("2e680f09-9e6a-407d-b4a1-c988005f72c7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("5927c638-909c-4411-8bac-0feaf977ae13") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("6311122a-0edd-428e-b5fa-2b7f3be06d7d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"), new Guid("fc80caf3-9fcf-4d34-ad8a-f5faa2080828") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("d9ae9fb8-127e-444d-9cbe-e7e4a71d46c6"), new Guid("056b4897-9453-4029-86f5-3cd533dbd33b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("e9138d88-16b6-4328-8000-cd199250c52e"), new Guid("e9104308-1843-4750-a147-29df6195f1df") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("15d664ec-bd9d-4923-a8c5-df07aee6ed86") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("2a42c765-cedb-4b0f-9c83-dc0bac9a3b58") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("71dbfe2c-c6cf-4bd1-b38f-96f91408a5a6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"), new Guid("c5ee4c47-f840-4ee0-99f9-6b8e7b7616fd") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"), new Guid("364ec6c5-4962-4610-b907-6c189c91b1db") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"), new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"), new Guid("c155eb39-5b7b-4787-b8e3-dfd27b3e2d5b") });

            migrationBuilder.DeleteData(
                table: "UserDepartmentRole",
                keyColumns: new[] { "UserId", "DepartmentId", "RoleId" },
                keyValues: new object[] { new Guid("dc09a30c-699c-420a-82fe-37476dda1890"), new Guid("7f0d9e25-b4b3-4607-a568-fd503eaf5da7"), new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f") });

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("012cda32-a2fb-43c6-9b76-2ec669f6fd35"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("046641cc-41ac-4937-b621-f769dbc425d8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("056b4897-9453-4029-86f5-3cd533dbd33b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("075b2343-2578-4227-ae94-f60a5dacbeb6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("09902b31-1c05-4094-a7e1-3af8b88a5565"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("09ef5812-179a-4bb9-ae83-6d62dea75d43"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0ba90fe1-ff93-45ff-b5dd-34bb191913a1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1028415e-4daf-438f-bbf6-2c4b63119424"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1069195a-0207-4bba-813c-e67af4b7077e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1390f9f1-d68e-47f3-a1ce-cf33311b9d7b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("13cf0cf9-a7ec-4750-b24d-2fac424eebcc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("13ef5794-9e54-4b38-8561-cf118e297f41"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("15d664ec-bd9d-4923-a8c5-df07aee6ed86"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1aad03c0-cbf4-4039-bba4-df3339c65989"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1d69715a-8bd6-4ce5-9922-0ae6f8d72aba"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("28c73fcb-3334-417c-a2b8-7acf9fa53d11"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2a42c765-cedb-4b0f-9c83-dc0bac9a3b58"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2ae7e99c-a6d5-44d4-a8f3-507d4cfa4c1d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2e680f09-9e6a-407d-b4a1-c988005f72c7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("31c80f0d-6315-4794-b5e6-cdea6ef3b807"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("347b9448-aa51-41c0-9e4f-a9f9ff7a829c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("364ec6c5-4962-4610-b907-6c189c91b1db"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3f6b21b8-dfc7-4dc3-b521-11a4e716e025"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("441d1453-662c-4227-810b-345ada55a063"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4837cff0-0a49-4d3a-932f-a2971fa4e9e1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("48bbc7e8-2bd3-42b8-901f-77a4529f6db0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4d7333bc-191f-44f1-9db8-a8f60f7d724c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4e95416d-fc6a-4990-87a8-9f6bf97d0110"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("50e243d1-2b09-4d6d-87a3-2c71e5c5d180"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5183be46-2d4e-4418-affe-d7bfd02b603b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("54a5e294-cd7e-4148-8013-3613be0821c6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("552c28a8-d929-4f0c-8f07-0aa5637e5224"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("57b25249-a86b-4c2d-89d1-1bca14d3481a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("57ba6a34-b252-4b0d-86d0-126b3ac11a62"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("58885f2a-cc81-42e3-8d33-5495a9f62e2a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5927c638-909c-4411-8bac-0feaf977ae13"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5de2cbc6-89c8-43b4-aa74-a9d0b4a5bf3d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6311122a-0edd-428e-b5fa-2b7f3be06d7d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("683055b8-6d45-4d3d-b0cc-f1f001e02f21"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("68534b4a-66ec-4ed7-9df4-f34af68b94b5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("68624aca-6794-47af-9b2c-e5163c723ec0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6a7d097f-9945-418d-82d7-f40544fdce37"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6c4923e0-b13d-4604-b32d-a03235e24c53"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("70ee8547-7219-4adc-b9ff-5ae20781f7e9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("718a2127-2b7f-4dff-bfbd-bd523b87b065"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("71dbfe2c-c6cf-4bd1-b38f-96f91408a5a6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("71e3d88a-3d34-4eb8-b785-8dc84a986d32"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("751e709a-6320-493e-8ae8-6373155aeb1b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7a6b5d07-e2c7-4b72-979e-de0464a6f3e9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("84e8059b-1ab5-4a16-a86a-71576931b20c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("89c69f20-bda0-479d-b194-4727a9c389ff"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("89cd1433-c1c8-42b5-9dcc-bd1b467c1849"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8ca3359e-526c-42a4-9af1-edc3a8ce46a3"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8d5fe15e-6304-40c3-9efd-e7f3cd77912c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8eb144f3-aceb-419c-998a-2544f18fe7c9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("91f6e8f6-f550-410f-8fec-633d7689f24a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9a89e85a-66d0-4215-9778-cb13d4178e2d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9be7938d-3053-43d8-85fd-f6f6769d016d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9cb4f820-f76e-442e-920d-7a7805cc46b2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9dd59eba-7a0f-4f34-938b-1ef9e0f108a7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a248465e-0469-4d43-9d85-dab7e4c2ee35"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a4ef5f38-c096-4a41-8ce6-2659b95f2222"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a549899f-9ea4-47bc-b80c-7d395a8e4d5d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a5e3dda1-6c94-4124-8c33-a84c17078465"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a606cc31-e09b-438f-ab36-6da256be38b8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a7cb75be-93fd-4233-acda-fcf8f5ebb9db"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a94099cc-00ae-4ffb-b436-7a976ba31ce6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("aa0ffbe2-72eb-41e9-8f3c-6847967d84ba"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ae81ea0a-28ac-4b30-bcd3-47548f3a1791"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b3171048-ab03-4ee7-a1f9-55b823909ca4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bd32aeb7-168c-4a67-90ac-1ee5280d289a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c08f730b-9fac-4881-a1cc-e1425b7035a4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c155eb39-5b7b-4787-b8e3-dfd27b3e2d5b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c1ec031a-5b4f-4881-9076-25a5ebdc401f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c5ee4c47-f840-4ee0-99f9-6b8e7b7616fd"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c9bfee7a-c77f-4cea-87c2-63514ebb3219"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cf6210e8-98c9-4c8a-a0f5-9b0394676a8d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d3271dca-fe4c-4b84-b36f-c76347503f3f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d4a8ce4c-d623-47cb-9772-772c59a44968"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("daee4f52-497e-457c-9753-bc03c880a31b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dd138026-b77e-4b7a-be6a-2ae9c558e4db"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("de2bea7f-c84c-4b71-9d27-83fb608138fc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("def600da-e197-4dcf-b83b-4f9a291a5b20"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e9104308-1843-4750-a147-29df6195f1df"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e9a78fd1-1e37-4ce9-a6c5-2a9390417979"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ec128b9a-650e-4ad1-9123-cdc0456956b9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("edda64b2-08df-49ca-9a29-fe569ed8c662"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f00a4640-dc72-436b-81e4-5ae24b1a8165"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f1a7d4cf-039b-423f-8f15-eb024016c271"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f87689fa-6ff5-45ae-b53e-e9fb6cb6b7df"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fbb83a98-faeb-4198-9b70-ad7a13595a77"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fc80caf3-9fcf-4d34-ad8a-f5faa2080828"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ffda1e5b-1ab8-42a5-86e8-56dfd94153c4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7f0d9e25-b4b3-4607-a568-fd503eaf5da7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fbfe945e-f89a-4fbc-8f2a-ee002044e320"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aa50c096-e0cd-4ace-8b88-1d968172f22f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc09a30c-699c-420a-82fe-37476dda1890"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("10e18a05-6a25-4f54-b5ff-7f39bbfe0664"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("142c6afc-6c03-493d-bd81-12c573fcdb85"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("19e0f45f-e3b0-4faa-a920-29b15617474a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("1a2722f4-661d-4946-9819-109f9a910dcf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("23f2cc65-939f-4ddd-8535-32eda765fc5a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("265c5849-a45e-4ad1-90ff-20a03f380163"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2e0574c5-cac2-4f0e-a3a9-c63a1cb6f789"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("32e10c4c-fc5c-47a8-8ad8-33d69855d656"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4d04bdbe-df93-4fec-b41a-484b1d2fc3ed"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("648d6d97-bde2-4e9f-92d1-16deae5cbe06"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7b469257-3a7d-49cf-a4b0-a3edc8fac2a0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("88c8bf66-8cf7-48d4-910b-316413f39725"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8a3f1440-446f-4210-b924-411a1e391fe9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8d92b9d4-b622-4afd-81b4-adaf4458864e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8dc13613-f35f-4050-acea-56e3143c2c1e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9030326b-a5b4-4616-a41b-62624572fdb6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("95fe9deb-b8b1-4edc-a045-fcf450c49069"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a1fc86d7-8d7d-40ba-98a1-a066fd3b4746"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b407ee58-dd9e-46b3-ab02-489f3ca8a240"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b7d6ab23-0595-4c2f-8c72-9ee2b0ab66ae"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bbdf1ef5-7f83-4be2-bb57-73f61ee99fbb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("be04a468-225f-45a0-b417-13f3da3618d6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c1884e1a-5cb2-46c0-bb11-efbca217cec8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c6a3b1ff-9a7b-4432-a46c-8b7ba677daba"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d2ff92e9-35c6-4df9-b3a8-f33d50315367"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d9ae9fb8-127e-444d-9cbe-e7e4a71d46c6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e9138d88-16b6-4328-8000-cd199250c52e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0cf415b-d352-413d-9df8-c5d9a25291c4"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ContactNumber", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Manager", "Name", "OrdinalNumber", "ParentId" },
                values: new object[] { new Guid("28189d8c-466f-42b7-aab8-9e2592bd6961"), "13245679856", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(1495), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "张三", "深圳镁伽", 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Component", "CreatedAt", "Hidden", "Icon", "IsActive", "IsDeleted", "LastModifiedAt", "Name", "OrdinalNumber", "ParentId", "Path", "Redirect", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), "Protocol Step管理", "items/proStep/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7934), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_protocol", 21, new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "protocol", null, "Protocol Step管理", 1, "protocol" },
                    { new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), "节点管理", "items/node/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7943), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_node", 22, new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "node", null, "节点管理", 1, "node" },
                    { new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), "项目管理", "items/project/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7950), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_project", 23, new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "project", null, "项目管理", 1, "project" },
                    { new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), "Take管理", "items/task/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7959), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_take", 24, new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "take", null, "Take管理", 1, "take" },
                    { new Guid("46f040e7-6e9c-4876-989f-8aca2a43892a"), "排程", "items/aps/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7968), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_aps", 25, new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "aps", null, "排程", 1, "aps" },
                    { new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "生产管理", "Layout", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7972), false, "el-icon-s-cooperation", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce", 26, new Guid("00000000-0000-0000-0000-000000000000"), "/produce", "/produce", "生产管理", 0, "/produce" },
                    { new Guid("12c57331-1a3f-4159-8f54-d9abccb4ce5b"), "项目管理", "Layout", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7931), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itiems", 20, new Guid("00000000-0000-0000-0000-000000000000"), "/items", "/items", "项目管理", 0, "/items" },
                    { new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), "订单", "produce/order/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7975), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_order", 27, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "order", null, "订单", 1, "order" },
                    { new Guid("e5561cfc-191f-4e8f-b639-03549c7e8e69"), "质粒纯化", "produce/plasmid/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7991), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_plasmid", 29, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "plasmid", null, "质粒纯化", 1, "plasmid" },
                    { new Guid("57cd18af-26e3-4aa0-91b4-f6127ce80265"), "qPCR检测", "produce/qPCR/indexproduce/qPCR/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7994), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_qPCR", 30, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "qPCR", null, "qPCR检测", 1, "qPCR" },
                    { new Guid("938926df-4c75-4a4e-88d0-487e5bf2ff1f"), "SDS-PAGE检测", "produce/SDS/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7999), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_SDS", 31, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "SDS", null, "SDS-PAGE检测", 1, "SDS" },
                    { new Guid("d4c5e07b-a663-4c58-a3a8-1268e416f5c0"), "无菌检测", "produce/asepticCheck/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(8002), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_asepticCheck", 32, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "asepticCheck", null, "无菌检测", 1, "asepticCheck" },
                    { new Guid("a44c25a1-b4e0-4925-a929-f7bcda3031f3"), "入库登记", "produce/wareHouse/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(8005), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_wareHouse", 33, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "wareHouse", null, "入库登记", 1, "wareHouse" },
                    { new Guid("ac5ecc27-d7ae-44d3-831d-2486c854f740"), "发货记录", "produce/deliverGoods/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(8008), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_deliverGoods", 34, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "deliverGoods", null, "发货记录", 1, "deliverGoods" },
                    { new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), "分子克隆", "produce/clone/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7984), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_clone", 28, new Guid("0b7c2088-f307-4a75-9c0a-8b4968649402"), "clone", null, "分子克隆", 1, "clone" },
                    { new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), "今日任务", "task/today/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7921), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_today", 19, new Guid("bef5a4e2-4581-4a44-9163-1390306f1c68"), "today", null, "今日任务", 1, "today" },
                    { new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), "我的任务", "task/myTask/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7867), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_owner", 18, new Guid("bef5a4e2-4581-4a44-9163-1390306f1c68"), "owner", null, "我的任务", 1, "owner" },
                    { new Guid("fd518834-4281-4cab-a7d5-efcfa69b3632"), "日志管理", "system/logs/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7801), false, "el-icon-edit-outline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_log", 8, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "log", null, "日志管理", 1, "log" },
                    { new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), "技能管理", "system/skill/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7753), false, "skill", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_skill", 3, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "skill", null, "技能管理", 1, "skill" },
                    { new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), "部门管理", "system/department/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7765), false, "peoples", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_department", 4, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "department", null, "部门管理", 1, "department" },
                    { new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), "角色管理", "system/role/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7775), false, "el-icon-s-opportunity", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_role", 5, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "role", null, "角色管理", 1, "role" },
                    { new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), "菜单管理", "system/menu/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7784), false, "el-icon-menu", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_menu", 6, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "menu", null, "菜单管理", 1, "menu" },
                    { new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "字典项管理", "system/dictionary/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7791), false, "el-icon-tickets", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_dictionary", 7, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "dictionary", null, "字典项管理", 1, "dictionary" },
                    { new Guid("bef5a4e2-4581-4a44-9163-1390306f1c68"), "任务管理", "Layout", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7864), false, "el-icon-document-copy", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task", 17, new Guid("00000000-0000-0000-0000-000000000000"), "/task", "/task/today", "任务管理", 0, "/task" },
                    { new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "用户管理", "system/user/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(6977), false, "el-icon-user", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_user", 2, new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "user", null, "用户管理", 1, "user" },
                    { new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "基础数据配置", "Layout", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7805), false, "el-icon-files", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic", 9, new Guid("00000000-0000-0000-0000-000000000000"), "/basic", "/basic/user", "基础数据配置", 0, "/basic" },
                    { new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), "细胞管理", "basic/cells/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7825), false, "cells", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_cells", 11, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "cells", null, "细胞管理", 1, "cells" },
                    { new Guid("2806e5f6-0913-4c86-a6fd-d3712b47b75b"), "位置管理", "basic/place/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7834), false, "el-icon-location", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_place", 12, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "place", null, "位置管理", 1, "place" },
                    { new Guid("8b1a27cc-d6b0-4663-940e-84bd94ec003b"), "耗材管理", "basic/material/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7838), false, "el-icon-printer", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_material", 13, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "material", null, "耗材管理", 1, "material" },
                    { new Guid("c08903f4-e213-4b0b-92cc-94215e3c5231"), "试剂管理", "basic/reagent/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7842), false, "chemistry", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_reagent", 14, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "reagent", null, "试剂管理", 1, "reagent" },
                    { new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), "设备管理", "basic/equipment/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7846), false, "el-icon-suitcase", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_equipment", 15, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "equipment", null, "设备管理", 1, "equipment" },
                    { new Guid("354ccee8-859b-44f5-8069-b053190ee170"), "样本管理", "sample/sample/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7855), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample_sample", 16, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "sample", null, "样本管理", 1, "sample" },
                    { new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), "物种管理", "basic/species/index", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(7815), false, "el-icon-more", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_species", 10, new Guid("05ab016f-5856-42f8-8ed4-4730b306941c"), "species", null, "物种管理", 1, "species" },
                    { new Guid("947c1cfb-fc85-4ae6-89a2-fdaac07adb33"), "系统管理", "Layout", new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(5243), false, "el-icon-s-tools", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", 1, new Guid("00000000-0000-0000-0000-000000000000"), "/system", "/system/user", "系统管理", 0, "/system" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Name" },
                values: new object[] { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new DateTime(2021, 8, 4, 12, 0, 53, 51, DateTimeKind.Local).AddTicks(3263), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "超级管理员" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "IsActive", "IsDeleted", "LastModifiedAt", "MobileNumber", "Password", "UserName", "WorkTime" },
                values: new object[] { new Guid("9525002b-2459-4dec-bd40-c5ebb2060cf4"), new DateTime(2021, 8, 4, 12, 0, 53, 48, DateTimeKind.Local).AddTicks(6836), "234298234@qq.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13523429876", null, "admin@admin.com", "8:00-9:00" });

            migrationBuilder.InsertData(
                table: "Button",
                columns: new[] { "Id", "Code", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("fe5b706c-cf43-4467-8341-6e20980d2d6e"), "QueryUser", new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "查询用户" },
                    { new Guid("4a2675e0-78c9-4339-90f8-fd5f6d1a2c0a"), "DeleteProtocolStep", new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), "删除ProtocolStep" },
                    { new Guid("048c83ab-38a7-4583-a9f6-54b510387921"), "UpdateProtocolStep", new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), "修改ProtocolStep" },
                    { new Guid("7d0f42de-cee3-459b-9766-c84c19efefbc"), "AddProtocolStep", new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), "新增ProtocolStep" },
                    { new Guid("ebeffd64-2c62-4fbe-9b07-c8fc9ed82160"), "QueryProtocolStep", new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), "查询ProtocolStep" },
                    { new Guid("c3dc9cfb-72c1-46bf-a6e1-c1f27472a2cf"), "DeleteTask", new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), "删除今日任务" },
                    { new Guid("3a167599-4fc9-4b5e-a3d2-e819151c5a10"), "UpdateTask", new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), "修改今日任务" },
                    { new Guid("8e88541e-a7b8-413d-9763-305a0db06cb1"), "AddTask", new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), "新增今日任务" },
                    { new Guid("e69066d2-051c-465c-9ddc-794cfe62a692"), "QueryNode", new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), "查询节点" },
                    { new Guid("c3b44418-a8a5-44e0-acc0-139b2ed7a45c"), "QueryTask", new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), "查询今日任务" },
                    { new Guid("cbf711ac-7fcd-4567-b9d9-1002878d35f7"), "UpdateMyTask", new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), "修改我的任务" },
                    { new Guid("cdc1ddd8-c48b-4fa5-8900-6b30806a6175"), "AddMyTask", new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), "新增我的任务" },
                    { new Guid("40d2ede0-becc-428f-bfd4-fe5bbbbd5749"), "QueryMyTask", new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), "查询我的任务" },
                    { new Guid("0448d884-5b0c-456b-8feb-0d9fa3990415"), "DeleteSample", new Guid("354ccee8-859b-44f5-8069-b053190ee170"), "删除样本" },
                    { new Guid("dd499b8a-6d66-4d9a-8937-4cb576ddae76"), "UpdateSample", new Guid("354ccee8-859b-44f5-8069-b053190ee170"), "修改样本" },
                    { new Guid("504048ee-fbde-40df-90cc-7ae074eab642"), "AddSample", new Guid("354ccee8-859b-44f5-8069-b053190ee170"), "新增样本" },
                    { new Guid("1651bd6b-1c41-4fa5-8653-ba50fd87a306"), "QuerySample", new Guid("354ccee8-859b-44f5-8069-b053190ee170"), "查询样本" },
                    { new Guid("934c1c56-8ca0-4ee1-abcc-3b6620b0cade"), "DeleteMyTask", new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), "删除我的任务" },
                    { new Guid("fd0b874f-bd7a-432f-a94d-f7694fb63fdc"), "DeleteDevice", new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), "删除设备" },
                    { new Guid("72d159ef-0b5e-4ed7-b109-f85c816163fd"), "AddNode", new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), "新增节点" },
                    { new Guid("8bf1c7ca-34d6-4f8d-8d18-7bc204879ed5"), "DeleteNode", new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), "删除节点" },
                    { new Guid("82903849-06bb-4a6e-92c9-d40dbf20625f"), "UpdateCloning", new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), "修改分子克隆" },
                    { new Guid("a66410d3-df7e-46f2-8535-7dab18f1b191"), "AddCloning", new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), "新增分子克隆" },
                    { new Guid("2470d27f-5194-4871-aefc-22ce13c82681"), "QueryCloning", new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), "查询分子克隆" },
                    { new Guid("e43f67ea-6a39-475d-8e33-2e17bc31a110"), "DeleteOrder", new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), "删除订单" },
                    { new Guid("919e89fc-e015-4cab-a931-16fd197a32ae"), "UpdateOrder", new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), "修改订单" },
                    { new Guid("7f179360-1bdf-4578-9e91-6501030bc380"), "AddOrder", new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), "新增订单" },
                    { new Guid("147c1e94-df99-407c-bc5d-32db5ef4d2c2"), "QueryOrder", new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), "查询订单" },
                    { new Guid("663ec245-a1fa-488f-9ce6-09f8a2b8c246"), "UpdateNode", new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), "修改节点" },
                    { new Guid("6a9f2a8d-a381-435b-be9c-cf13d0aefb39"), "QuerySchedule", new Guid("46f040e7-6e9c-4876-989f-8aca2a43892a"), "查询排程" },
                    { new Guid("ae756e5a-80f7-4920-b594-edc9db4a2326"), "UpdateTake", new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), "修改Take" },
                    { new Guid("13348422-197b-4ea6-b19c-e21463ea713f"), "AddTake", new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), "新增Take" },
                    { new Guid("d1367b99-84bf-4a19-9e21-ec344dceb17d"), "QueryTake", new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), "查询Take" },
                    { new Guid("d39ffa41-7160-4cce-8a06-ffbf4101821c"), "DeleteProject", new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), "删除项目" },
                    { new Guid("a3895501-2917-47d4-951e-3234134f30ea"), "UpdateProject", new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), "修改项目" },
                    { new Guid("9bf5c256-b15c-4350-a958-df4c2a3d9f13"), "AddProject", new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), "新增项目" },
                    { new Guid("7d03be34-6fb6-4dea-9085-27ee5f4f1323"), "QueryProject", new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), "查询项目" },
                    { new Guid("c1c6209c-4021-4a56-a32e-7d88ea92d336"), "DeleteTake", new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), "删除Take" },
                    { new Guid("e727894f-d0fe-4a61-9c55-058dbb807485"), "UpdateDevice", new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), "修改设备" },
                    { new Guid("d1154d60-f1d3-46d1-87b8-14abd32dfd4e"), "AddDevice", new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), "新增设备" },
                    { new Guid("8f99a12a-332d-43f2-8d95-d20f80cfb90d"), "QueryDevice", new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), "查询设备" },
                    { new Guid("50211a2f-9aa9-4431-829b-c0e355c9cd07"), "DeleteRole", new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), "删除角色" },
                    { new Guid("45b5c253-94c1-4c5f-b3cb-e283a8711243"), "UpdateRole", new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), "修改角色" },
                    { new Guid("7526a5cd-9635-4b4e-8281-15b9b00ebcb7"), "AddRole", new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), "新增角色" },
                    { new Guid("4c4d2f31-aa9b-4321-a1fc-591eab8bfb32"), "QueryRole", new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), "查询角色" },
                    { new Guid("ad833ada-c1fe-4f77-aee7-1bf014487cc5"), "DeleteDepartment", new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), "删除部门" },
                    { new Guid("cd8b207c-4b13-4cc2-9b18-d9bf28a0c362"), "UpdateDepartment", new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), "修改部门" },
                    { new Guid("5bb11723-1d83-42b1-bf40-5f91e321a387"), "AddDepartment", new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), "新增部门" },
                    { new Guid("b7070bc7-7ac0-4f66-a874-b131486e7893"), "QueryMenu", new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), "查询菜单" },
                    { new Guid("f96aa350-94b6-4437-a9f6-f64a13305a85"), "QueryDepartment", new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), "查询部门" },
                    { new Guid("2027f88f-3562-4e02-948d-8ebc6b06f77a"), "UpdateSkill", new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), "修改技能" },
                    { new Guid("549db880-e764-4273-b489-e004dde5c19d"), "AddSkill", new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), "新增技能" },
                    { new Guid("d2ed3697-438a-482a-a9a7-d2d090df27c0"), "QuerySkill", new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), "查询技能" },
                    { new Guid("f65bcbd0-8426-4c13-9d20-8f2550d7ea35"), "ResetUser", new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "重置用户" },
                    { new Guid("0fc0ecbc-6470-465a-9b01-9db147698428"), "DeleteUser", new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "删除用户" },
                    { new Guid("4ad196d3-5ed8-47af-9ca4-45a731dbc4b2"), "UpdateUser", new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "修改用户" },
                    { new Guid("a3d61144-4e3e-46f3-a445-f7f9be882844"), "AddUser", new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), "新增用户" },
                    { new Guid("f1c22dba-0990-4ac2-80a6-dcd50e150bd0"), "DeleteSkill", new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), "删除技能" },
                    { new Guid("d74bdbf7-c019-41e2-81c9-9c7f57228234"), "AddMenu", new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), "新增菜单" },
                    { new Guid("99d0b4bb-12cc-4f97-8d3d-d9a870ebe814"), "UpdateMenu", new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), "修改菜单" },
                    { new Guid("0bad6c29-27a7-4cab-b154-f1db3732fd40"), "DeleteMenu", new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), "删除菜单" },
                    { new Guid("22f252e5-c3e8-4501-aca4-118b8cfd2600"), "QueryReagent", new Guid("c08903f4-e213-4b0b-92cc-94215e3c5231"), "查询试剂" },
                    { new Guid("42248e94-7021-4b3e-a959-4b552fe783fa"), "QueryLabware", new Guid("8b1a27cc-d6b0-4663-940e-84bd94ec003b"), "查询耗材" },
                    { new Guid("87c3e722-b69c-4480-b0ec-0b42243fa21a"), "QueryPosition", new Guid("2806e5f6-0913-4c86-a6fd-d3712b47b75b"), "查询位置" },
                    { new Guid("2a141afe-0acf-4437-90c6-bc7bbf96307c"), "DeleteCell", new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), "删除细胞" },
                    { new Guid("71ad007d-3fb8-4a1b-bfe2-4e68aa62da6c"), "UpdateCell", new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), "修改细胞" },
                    { new Guid("cc8714d0-2f55-4eb6-9951-34e7a31b2896"), "AddCell", new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), "新增细胞" },
                    { new Guid("d1acf2f5-c2a9-452e-9489-c6bb970a0aea"), "QueryCell", new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), "查询细胞" },
                    { new Guid("b18609d3-cfb3-480f-bb6b-6e68d2858d46"), "DeleteSpecies", new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), "删除物种" },
                    { new Guid("b7919203-5b26-4aad-82cc-dfcba56bcb89"), "UpdateSpecies", new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), "修改物种" },
                    { new Guid("772d87c0-87a8-4a9f-9eed-ac03789badf6"), "AddSpecies", new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), "新增物种" },
                    { new Guid("f171f9a2-d4fa-4c4f-99a7-aec74e91e956"), "QuerySpecies", new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), "查询物种" },
                    { new Guid("d99b42e1-db69-42a4-9e5d-b8b780a9a23a"), "QueryLog", new Guid("fd518834-4281-4cab-a7d5-efcfa69b3632"), "查询日志" },
                    { new Guid("c690cc78-aa0b-4898-a81b-9b7c9c2e7ac5"), "UpdateDictValue", new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "修改字典项值" },
                    { new Guid("4533bbb4-6b8d-4333-9882-d340910ca371"), "DeleteDict", new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "删除字典项" },
                    { new Guid("55e8ae74-5705-4d5a-b504-2de42c712593"), "UpdateDict", new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "修改字典项" },
                    { new Guid("c08e1bb1-cc50-4dc1-b633-76efb7824b21"), "AddDict", new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "新增字典项" },
                    { new Guid("ce9ce7b3-c7af-4c51-b1b5-6d2492eac5c6"), "QueryDict", new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), "查询字典项" },
                    { new Guid("11299edd-571d-4aee-983c-a45dd27b81e7"), "DeleteCloning", new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), "删除分子克隆" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartmentRole",
                columns: new[] { "UserId", "DepartmentId", "RoleId" },
                values: new object[] { new Guid("9525002b-2459-4dec-bd40-c5ebb2060cf4"), new Guid("28189d8c-466f-42b7-aab8-9e2592bd6961"), new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81") });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" },
                values: new object[,]
                {
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("fe5b706c-cf43-4467-8341-6e20980d2d6e") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("048c83ab-38a7-4583-a9f6-54b510387921") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("7d0f42de-cee3-459b-9766-c84c19efefbc") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("ebeffd64-2c62-4fbe-9b07-c8fc9ed82160") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("c3dc9cfb-72c1-46bf-a6e1-c1f27472a2cf") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("3a167599-4fc9-4b5e-a3d2-e819151c5a10") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("8e88541e-a7b8-413d-9763-305a0db06cb1") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("169af775-c9e0-417c-950d-190bc12cc65a"), new Guid("c3b44418-a8a5-44e0-acc0-139b2ed7a45c") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("0c487d71-8d6e-4c2f-b209-0b1bc007e61a"), new Guid("4a2675e0-78c9-4339-90f8-fd5f6d1a2c0a") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("934c1c56-8ca0-4ee1-abcc-3b6620b0cade") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("cdc1ddd8-c48b-4fa5-8900-6b30806a6175") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("40d2ede0-becc-428f-bfd4-fe5bbbbd5749") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("0448d884-5b0c-456b-8feb-0d9fa3990415") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("dd499b8a-6d66-4d9a-8937-4cb576ddae76") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("504048ee-fbde-40df-90cc-7ae074eab642") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("354ccee8-859b-44f5-8069-b053190ee170"), new Guid("1651bd6b-1c41-4fa5-8653-ba50fd87a306") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("fd0b874f-bd7a-432f-a94d-f7694fb63fdc") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e6363a3-0e62-4f8c-ab37-b437e4905a3f"), new Guid("cbf711ac-7fcd-4567-b9d9-1002878d35f7") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("e727894f-d0fe-4a61-9c55-058dbb807485") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("e69066d2-051c-465c-9ddc-794cfe62a692") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("663ec245-a1fa-488f-9ce6-09f8a2b8c246") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("a66410d3-df7e-46f2-8535-7dab18f1b191") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("2470d27f-5194-4871-aefc-22ce13c82681") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("e43f67ea-6a39-475d-8e33-2e17bc31a110") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("919e89fc-e015-4cab-a931-16fd197a32ae") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("7f179360-1bdf-4578-9e91-6501030bc380") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5699239b-1dae-4d5f-8b30-67641b1389b1"), new Guid("147c1e94-df99-407c-bc5d-32db5ef4d2c2") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("46f040e7-6e9c-4876-989f-8aca2a43892a"), new Guid("6a9f2a8d-a381-435b-be9c-cf13d0aefb39") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("72d159ef-0b5e-4ed7-b109-f85c816163fd") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("c1c6209c-4021-4a56-a32e-7d88ea92d336") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("13348422-197b-4ea6-b19c-e21463ea713f") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("d1367b99-84bf-4a19-9e21-ec344dceb17d") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("d39ffa41-7160-4cce-8a06-ffbf4101821c") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("a3895501-2917-47d4-951e-3234134f30ea") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("9bf5c256-b15c-4350-a958-df4c2a3d9f13") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("7b82ae08-06ee-442b-94ec-7b1d0ec5771d"), new Guid("7d03be34-6fb6-4dea-9085-27ee5f4f1323") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("63ec3388-7f67-46f0-9e5b-4cd3b76fb8bb"), new Guid("8bf1c7ca-34d6-4f8d-8d18-7bc204879ed5") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("81a58059-f201-43cd-9474-d32d0a6154e6"), new Guid("ae756e5a-80f7-4920-b594-edc9db4a2326") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("82903849-06bb-4a6e-92c9-d40dbf20625f") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("d1154d60-f1d3-46d1-87b8-14abd32dfd4e") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c08903f4-e213-4b0b-92cc-94215e3c5231"), new Guid("22f252e5-c3e8-4501-aca4-118b8cfd2600") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("50211a2f-9aa9-4431-829b-c0e355c9cd07") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("45b5c253-94c1-4c5f-b3cb-e283a8711243") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("7526a5cd-9635-4b4e-8281-15b9b00ebcb7") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("16844e51-6f7e-4502-bc4e-33193aa57c61"), new Guid("4c4d2f31-aa9b-4321-a1fc-591eab8bfb32") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("ad833ada-c1fe-4f77-aee7-1bf014487cc5") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("cd8b207c-4b13-4cc2-9b18-d9bf28a0c362") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("5bb11723-1d83-42b1-bf40-5f91e321a387") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("b7070bc7-7ac0-4f66-a874-b131486e7893") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("3e0e871a-dd1a-4403-97fe-e006dd424918"), new Guid("f96aa350-94b6-4437-a9f6-f64a13305a85") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("2027f88f-3562-4e02-948d-8ebc6b06f77a") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("549db880-e764-4273-b489-e004dde5c19d") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("d2ed3697-438a-482a-a9a7-d2d090df27c0") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("f65bcbd0-8426-4c13-9d20-8f2550d7ea35") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("0fc0ecbc-6470-465a-9b01-9db147698428") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("4ad196d3-5ed8-47af-9ca4-45a731dbc4b2") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("e2331e8c-f238-40c4-abfa-956e03ed9ba5"), new Guid("a3d61144-4e3e-46f3-a445-f7f9be882844") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("23a329c1-02dd-47b6-9d67-5d3591f984e8"), new Guid("f1c22dba-0990-4ac2-80a6-dcd50e150bd0") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("5368cdcd-ccde-40a1-b8d3-52ec8fab80e2"), new Guid("8f99a12a-332d-43f2-8d95-d20f80cfb90d") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("d74bdbf7-c019-41e2-81c9-9c7f57228234") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("0bad6c29-27a7-4cab-b154-f1db3732fd40") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("8b1a27cc-d6b0-4663-940e-84bd94ec003b"), new Guid("42248e94-7021-4b3e-a959-4b552fe783fa") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("2806e5f6-0913-4c86-a6fd-d3712b47b75b"), new Guid("87c3e722-b69c-4480-b0ec-0b42243fa21a") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("2a141afe-0acf-4437-90c6-bc7bbf96307c") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("71ad007d-3fb8-4a1b-bfe2-4e68aa62da6c") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("cc8714d0-2f55-4eb6-9951-34e7a31b2896") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("ef7b2ce5-0a62-4ab8-8085-cfb25e516105"), new Guid("d1acf2f5-c2a9-452e-9489-c6bb970a0aea") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("b18609d3-cfb3-480f-bb6b-6e68d2858d46") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("810a01d1-a1d5-475a-bc64-7229682722d3"), new Guid("99d0b4bb-12cc-4f97-8d3d-d9a870ebe814") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("b7919203-5b26-4aad-82cc-dfcba56bcb89") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("f171f9a2-d4fa-4c4f-99a7-aec74e91e956") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("fd518834-4281-4cab-a7d5-efcfa69b3632"), new Guid("d99b42e1-db69-42a4-9e5d-b8b780a9a23a") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("c690cc78-aa0b-4898-a81b-9b7c9c2e7ac5") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("4533bbb4-6b8d-4333-9882-d340910ca371") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("55e8ae74-5705-4d5a-b504-2de42c712593") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("c08e1bb1-cc50-4dc1-b633-76efb7824b21") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("bf5c77c9-bdea-4aeb-ba3e-f293699a5cdd"), new Guid("ce9ce7b3-c7af-4c51-b1b5-6d2492eac5c6") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("01f8b333-d9c9-46ff-a8af-1b8ffe38d966"), new Guid("772d87c0-87a8-4a9f-9eed-ac03789badf6") },
                    { new Guid("ce4eced7-848d-4959-88ce-3d5b6d10fb81"), new Guid("c6bd3005-6b00-4be9-840d-a3eefb7cd2a1"), new Guid("11299edd-571d-4aee-983c-a45dd27b81e7") }
                });
        }
    }
}
