using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddFilesForOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "DetectionPicture",
                table: "SterilityDetection",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetectionPicture",
                table: "SdsPageDetection",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnzymeCuttingPicture",
                table: "PlasmidPurification",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnalysisReport",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AnalysisReportFileId",
                table: "Order",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "EnzymeCuttingPicture",
                table: "MolecularCloning",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ContactNumber", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Manager", "Name", "OrdinalNumber", "ParentId" },
                values: new object[] { new Guid("1fefd903-624b-4d9b-b3f1-59dcb278a8fb"), "13245679856", new DateTime(2021, 8, 9, 18, 19, 29, 616, DateTimeKind.Local).AddTicks(8240), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "张三", "深圳镁伽", 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "DictItems",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "KeyName", "LastModifiedAt", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("f7c3617c-b4fc-416b-84a0-9c51a106d8cf"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7568), false, "质量", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ng,μg,mg,g,kg" },
                    { new Guid("8e243a04-6a75-4581-8b77-0cdc1fb6cabb"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7566), false, "供应商", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen" },
                    { new Guid("1bd011fc-89b8-430d-8026-48405153aac5"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7561), false, "体积", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "μL,mL", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("90ccadc8-a619-426c-8b0a-7e9245eca1a1"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7552), false, "种族", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Black,Caucasian,Asian,ELSE" },
                    { new Guid("9141827f-9b79-4f83-af46-05b2ac885905"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7563), false, "浓度", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "%,mg/ml" },
                    { new Guid("dafb9026-c451-49bc-bd3b-847c050fdfe2"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7547), false, "疾病", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("b6edd245-709c-46f7-bbd6-1f8c57f8985f"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7544), false, "培养方式", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Adherent,Suspension,ELSE" },
                    { new Guid("7041b779-78b3-4171-bd49-81c70bb654f4"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7521), false, "细胞系种类", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "epithelial,ELSE" },
                    { new Guid("359ff969-4c3c-4436-8e4d-84212defae89"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7080), false, "组织类型", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "cervix,lung,ELSE" },
                    { new Guid("0466f477-7372-4eee-a0bf-1727c8ba18c1"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(7549), false, "性别", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Female,Male,ELSE" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Component", "CreatedAt", "Hidden", "Icon", "IsActive", "IsDeleted", "LastModifiedAt", "Name", "OrdinalNumber", "ParentId", "Path", "Redirect", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { new Guid("9b595b71-510d-498c-a9b2-dab20f28e8da"), "排程", "items/aps/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5145), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_aps", 25, new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "aps", null, "排程", 1, "aps" },
                    { new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "项目管理", "Layout", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5075), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itiems", 20, new Guid("00000000-0000-0000-0000-000000000000"), "/items", "/items", "项目管理", 0, "/items" },
                    { new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), "Protocol Step管理", "items/proStep/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5078), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_protocol", 21, new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "protocol", null, "Protocol Step管理", 1, "protocol" },
                    { new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), "节点管理", "items/node/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5087), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_node", 22, new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "node", null, "节点管理", 1, "node" },
                    { new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), "项目管理", "items/project/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5095), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_project", 23, new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "project", null, "项目管理", 1, "project" },
                    { new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), "Take管理", "items/task/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5134), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_take", 24, new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"), "take", null, "Take管理", 1, "take" },
                    { new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "生产管理", "Layout", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5150), false, "el-icon-s-cooperation", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce", 26, new Guid("00000000-0000-0000-0000-000000000000"), "/produce", "/produce", "生产管理", 0, "/produce" },
                    { new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), "无菌检测", "produce/asepticCheck/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5197), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_asepticCheck", 32, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "asepticCheck", null, "无菌检测", 1, "asepticCheck" },
                    { new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), "分子克隆", "produce/clone/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5170), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_clone", 28, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "clone", null, "分子克隆", 1, "clone" },
                    { new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), "质粒纯化", "produce/plasmid/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5179), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_plasmid", 29, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "plasmid", null, "质粒纯化", 1, "plasmid" },
                    { new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"), "qPCR检测", "produce/qPCR/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5184), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_qPCR", 30, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "qPCR", null, "qPCR检测", 1, "qPCR" },
                    { new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), "SDS-PAGE检测", "produce/SDS/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5190), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_SDS", 31, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "SDS", null, "SDS-PAGE检测", 1, "SDS" },
                    { new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), "今日任务", "task/today/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5065), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_today", 19, new Guid("14409391-adc2-4b1c-bb1d-4d22f426e62d"), "today", null, "今日任务", 1, "today" },
                    { new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), "入库登记", "produce/wareHouse/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5202), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_wareHouse", 33, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "wareHouse", null, "入库登记", 1, "wareHouse" },
                    { new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), "发货记录", "produce/deliverGoods/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5208), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_deliverGoods", 34, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "deliverGoods", null, "发货记录", 1, "deliverGoods" },
                    { new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "订单", "produce/order/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5154), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_order", 27, new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"), "order", null, "订单", 1, "order" },
                    { new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), "我的任务", "task/myTask/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5058), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_owner", 18, new Guid("14409391-adc2-4b1c-bb1d-4d22f426e62d"), "owner", null, "我的任务", 1, "owner" },
                    { new Guid("1edc0786-4408-44da-8d0c-aa88f2f2a9c9"), "耗材管理", "basic/material/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5028), false, "el-icon-printer", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_material", 13, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "material", null, "耗材管理", 1, "material" },
                    { new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), "样本管理", "sample/sample/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5045), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample_sample", 16, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "sample", null, "样本管理", 1, "sample" },
                    { new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "系统管理", "Layout", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(2104), false, "el-icon-s-tools", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", 1, new Guid("00000000-0000-0000-0000-000000000000"), "/system", "/system/user", "系统管理", 0, "/system" },
                    { new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "用户管理", "system/user/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4041), false, "el-icon-user", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_user", 2, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "user", null, "用户管理", 1, "user" },
                    { new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), "技能管理", "system/skill/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4792), false, "skill", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_skill", 3, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "skill", null, "技能管理", 1, "skill" },
                    { new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), "部门管理", "system/department/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4947), false, "peoples", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_department", 4, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "department", null, "部门管理", 1, "department" },
                    { new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), "角色管理", "system/role/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4961), false, "el-icon-s-opportunity", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_role", 5, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "role", null, "角色管理", 1, "role" },
                    { new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), "菜单管理", "system/menu/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4971), false, "el-icon-menu", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_menu", 6, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "menu", null, "菜单管理", 1, "menu" },
                    { new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "字典项管理", "system/dictionary/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4978), false, "el-icon-tickets", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_dictionary", 7, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "dictionary", null, "字典项管理", 1, "dictionary" },
                    { new Guid("57f96d4c-b6a2-4582-adf7-8f3d13a959db"), "日志管理", "system/logs/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4991), false, "el-icon-edit-outline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_log", 8, new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"), "log", null, "日志管理", 1, "log" },
                    { new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "基础数据配置", "Layout", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(4995), false, "el-icon-files", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic", 9, new Guid("00000000-0000-0000-0000-000000000000"), "/basic", "/basic/user", "基础数据配置", 0, "/basic" },
                    { new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), "物种管理", "basic/species/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5005), false, "el-icon-more", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_species", 10, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "species", null, "物种管理", 1, "species" },
                    { new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), "细胞管理", "basic/cells/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5014), false, "cells", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_cells", 11, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "cells", null, "细胞管理", 1, "cells" },
                    { new Guid("24d62360-b2d8-42c4-a0ae-76152e55562f"), "位置管理", "basic/place/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5023), false, "el-icon-location", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_place", 12, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "place", null, "位置管理", 1, "place" },
                    { new Guid("66cbdde8-a894-4d5d-8620-3ac8c37b0791"), "试剂管理", "basic/reagent/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5032), false, "chemistry", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_reagent", 14, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "reagent", null, "试剂管理", 1, "reagent" },
                    { new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), "设备管理", "basic/equipment/index", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5036), false, "el-icon-suitcase", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_equipment", 15, new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"), "equipment", null, "设备管理", 1, "equipment" },
                    { new Guid("14409391-adc2-4b1c-bb1d-4d22f426e62d"), "任务管理", "Layout", new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(5054), false, "el-icon-document-copy", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task", 17, new Guid("00000000-0000-0000-0000-000000000000"), "/task", "/task/today", "任务管理", 0, "/task" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Name" },
                values: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new DateTime(2021, 8, 9, 18, 19, 29, 617, DateTimeKind.Local).AddTicks(297), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "超级管理员" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "IsActive", "IsDeleted", "LastModifiedAt", "MobileNumber", "Password", "UserName", "WorkTime" },
                values: new object[] { new Guid("72871f96-9674-4322-844f-43976a0afaee"), new DateTime(2021, 8, 9, 18, 19, 29, 614, DateTimeKind.Local).AddTicks(1085), "234298234@qq.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13523429876", null, "admin@admin.com", "8:00-9:00" });

            migrationBuilder.InsertData(
                table: "Button",
                columns: new[] { "Id", "Code", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("cce54550-ce05-404e-8aa0-7ef0b087de00"), "QueryUser", new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "查询用户" },
                    { new Guid("3b5c2a85-cac6-4c5a-94b0-c1ba1d0fe165"), "AddTake", new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), "新增Take" },
                    { new Guid("7de02c05-a351-4ebe-9e5e-1da18845da52"), "QueryTake", new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), "查询Take" },
                    { new Guid("3122ca43-7098-40f5-96d7-e749d0a989c7"), "DeleteProject", new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), "删除项目" },
                    { new Guid("37c83e66-8d27-498c-855f-fa23ad8ae275"), "UpdateProject", new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), "修改项目" },
                    { new Guid("1487ac76-7a3c-4bac-930e-7cb6ba78c669"), "AddProject", new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), "新增项目" },
                    { new Guid("c11cf2b2-e4cf-49b8-b732-02f3b7d472a2"), "QueryProject", new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), "查询项目" },
                    { new Guid("7b4b9ba1-9766-4dc6-8dd9-0f19b15c0edc"), "DeleteNode", new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), "删除节点" },
                    { new Guid("945a71bd-56aa-4f53-a176-163edde7555a"), "UpdateNode", new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), "修改节点" },
                    { new Guid("21a5c012-2e03-4cfa-a5fb-48f607074823"), "AddNode", new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), "新增节点" },
                    { new Guid("607d64bf-fd28-4e89-8356-8a180e471c8a"), "QueryNode", new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), "查询节点" },
                    { new Guid("c33b2ca7-b4d7-46fd-b642-29ed3f1b0748"), "DeleteProtocolStep", new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), "删除ProtocolStep" },
                    { new Guid("ae498aa0-7bd9-4fb6-9a56-ffda934b99c4"), "UpdateProtocolStep", new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), "修改ProtocolStep" },
                    { new Guid("925d7744-a03b-49c2-817d-24d3e900208f"), "AddProtocolStep", new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), "新增ProtocolStep" },
                    { new Guid("b22e0f2a-991c-4721-a4f8-b6ece26aab7a"), "QueryProtocolStep", new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), "查询ProtocolStep" },
                    { new Guid("ae0886e7-6772-4170-96e6-d2b45987dfb2"), "DeleteTask", new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), "删除今日任务" },
                    { new Guid("f79c0c54-2055-4e6a-a761-cf66069453a9"), "UpdateTask", new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), "修改今日任务" },
                    { new Guid("f5332a01-e69a-4c32-a119-61648ce5ae40"), "AddTask", new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), "新增今日任务" },
                    { new Guid("9e068b9c-4319-407e-86df-1c48d8c3c6f7"), "QueryTask", new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), "查询今日任务" },
                    { new Guid("df22a567-a9b4-40c0-ad42-cbb8a5127a6b"), "DeleteMyTask", new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), "删除我的任务" },
                    { new Guid("8a3fea25-5f43-4a2b-b2db-21e2aaed17a4"), "UpdateTake", new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), "修改Take" },
                    { new Guid("a98060bf-80a4-4691-89be-239140d7b97b"), "DeleteTake", new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), "删除Take" },
                    { new Guid("9e61a0e9-bbd0-4969-94b3-053f9c94b3de"), "QuerySchedule", new Guid("9b595b71-510d-498c-a9b2-dab20f28e8da"), "查询排程" },
                    { new Guid("23047700-2da3-4ad4-899b-354f21d2393c"), "QueryOrder", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "查询订单" },
                    { new Guid("bd488987-79e1-41c7-93e0-a1a47ba704c5"), "QueryShipment", new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), "查询发货记录" },
                    { new Guid("0aecccce-65ea-463f-9ed7-e4a8c8934c7a"), "FinishWarehousing", new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), "完成入库记录" },
                    { new Guid("5af731de-bacc-4489-bef5-f122582779d9"), "QueryWarehousing", new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), "查询入库记录" },
                    { new Guid("9c2d0bc6-e2e0-43e6-9e93-344ca839fbf6"), "FinishSterility", new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), "完成无菌检测" },
                    { new Guid("15bd8c59-1bb5-4127-a19b-42be553d5d89"), "QuerySterility", new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), "查询无菌检测" },
                    { new Guid("16f8d431-fc74-4698-b842-2ec9187fbaf1"), "FinishSdspage", new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), "完成SDS-PAGE检测" },
                    { new Guid("bc66021f-9648-4df6-adbf-9e266a0c348b"), "QuerySdspage", new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), "查询SDS-PAGE检测" },
                    { new Guid("f926d75d-409a-4ffb-bd42-8bcf435b1e52"), "FinishPurifying", new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), "完成质粒纯化" },
                    { new Guid("d7ba2dc5-0f62-4143-a297-fbb1c0118d61"), "QueryPurifying", new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), "查询质粒纯化" },
                    { new Guid("e2461ae0-0895-44c2-8c2e-0341082ad95d"), "UpdateMyTask", new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), "修改我的任务" },
                    { new Guid("2afd4d3a-a5f9-4616-a30e-e84ce647659c"), "FinishQpcr", new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), "完成qPCR检测" },
                    { new Guid("f51f3c67-cc12-4426-8ec6-9bd7d0385b85"), "FinishCloning", new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), "完成分子克隆" },
                    { new Guid("52118ed1-1466-4ca5-a732-66f02182fc03"), "QueryCloning", new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), "查询分子克隆" },
                    { new Guid("e63afb0e-654d-46b7-af38-4aa0cbb9f27c"), "FinishOrder", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "完成" },
                    { new Guid("dce5da26-eebd-4e09-8a39-57bce1760a64"), "Warehousing", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "QC&入库" },
                    { new Guid("57d21c8f-9b2b-4d41-8af3-bc2285bce6df"), "StartProduce", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "进入生产" },
                    { new Guid("d4ae7341-ee88-4092-a4f0-99d7352e482f"), "PurifyPlasmid", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "质粒纯化" },
                    { new Guid("d480b21f-1c5c-4e4b-85ca-847438e48912"), "CloneMolecule", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "分子克隆" },
                    { new Guid("3a7fde22-602b-4449-8bfc-9cf2c0a9d6b4"), "UpdateOrder", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "修改订单" },
                    { new Guid("b7d40835-b2cb-4360-85d1-39e01f6ae0b2"), "AddOrder", new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), "新增订单" },
                    { new Guid("20ba2f97-ad6b-4562-9cd4-fc79974f284e"), "QueryQpcr", new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), "查询qPCR检测" },
                    { new Guid("04c34a70-4f89-441f-8a73-9cf9aff6265c"), "AddMyTask", new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), "新增我的任务" },
                    { new Guid("48a5f738-e261-4f2b-abda-7bd82367f7d8"), "QueryMyTask", new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), "查询我的任务" },
                    { new Guid("71ade60c-86b4-4337-b9dc-08252724b66b"), "DeleteSample", new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), "删除样本" },
                    { new Guid("0005712d-877e-47f1-8d89-5ff5b4f623a6"), "DeleteMenu", new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), "删除菜单" },
                    { new Guid("1210979c-8024-4180-bc52-403e17ccbc4c"), "UpdateMenu", new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), "修改菜单" },
                    { new Guid("7df07530-d397-4ab8-8ade-6f0068db6b35"), "AddMenu", new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), "新增菜单" },
                    { new Guid("5276710c-9a4f-41e5-9bb0-d0cf4f91e44f"), "QueryMenu", new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), "查询菜单" },
                    { new Guid("c477fbcf-8787-4b9d-8e37-8052c0f4082c"), "DeleteRole", new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), "删除角色" },
                    { new Guid("e7fcf4e3-5417-4139-bf72-4bd16b138ff1"), "UpdateRole", new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), "修改角色" },
                    { new Guid("3f0f9060-213a-4304-af2c-f5d39ace903f"), "AddRole", new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), "新增角色" },
                    { new Guid("f456c8b5-d8d8-4b71-8bb5-4895f7fecb1c"), "QueryRole", new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), "查询角色" },
                    { new Guid("1f2449fc-6e0f-4383-94a4-bd751373cec3"), "DeleteDepartment", new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), "删除部门" },
                    { new Guid("ce041e6a-779f-411b-be8b-0618bc6513eb"), "QueryDict", new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "查询字典项" },
                    { new Guid("624d5773-2520-4099-a8a0-0d6d32cf788e"), "UpdateDepartment", new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), "修改部门" },
                    { new Guid("eb5a56cf-d9e5-4c59-b6bc-6993e082634f"), "QueryDepartment", new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), "查询部门" },
                    { new Guid("5e13e970-1d23-4581-84d3-536b98f7ce1b"), "DeleteSkill", new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), "删除技能" },
                    { new Guid("bc0fd9f1-5389-40fe-91d7-39f3c486faa7"), "UpdateSkill", new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), "修改技能" },
                    { new Guid("84fef568-941e-4520-9226-d9cbbf9c4b7c"), "AddSkill", new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), "新增技能" },
                    { new Guid("845b8a96-3851-4a7c-8c02-3e9388d6f23e"), "QuerySkill", new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), "查询技能" },
                    { new Guid("d0380f84-60dd-4abd-b014-50b7ecd96e56"), "ResetUser", new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "重置用户" },
                    { new Guid("f36b3aba-8ff1-440a-a8c7-f46818f5729e"), "DeleteUser", new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "删除用户" },
                    { new Guid("e5448ea1-60f5-42da-99a5-77796285c1dc"), "UpdateUser", new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "修改用户" },
                    { new Guid("e8a50a37-eb36-4766-9fb2-d8eaed4ea5ca"), "AddUser", new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), "新增用户" },
                    { new Guid("2cc3fc36-45f9-45cc-840a-f5b9f02db2c7"), "AddDepartment", new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), "新增部门" },
                    { new Guid("49cdb677-5eee-41ac-aa27-4d5af11aee8c"), "FinishShipment", new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), "完成发货记录" },
                    { new Guid("5cc09918-fecf-494e-82e4-e808e1554318"), "AddDict", new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "新增字典项" },
                    { new Guid("67f0ee56-876b-40ad-9c56-605979a0c5d1"), "DeleteDict", new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "删除字典项" },
                    { new Guid("f5a9225c-e548-4c15-a925-1fa8502bd2c3"), "UpdateSample", new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), "修改样本" },
                    { new Guid("05b4707b-bd6b-4595-b601-5be3724e347c"), "AddSample", new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), "新增样本" },
                    { new Guid("27fd9c5a-8d2a-4b7b-8c25-83a7b3d88c65"), "QuerySample", new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), "查询样本" },
                    { new Guid("80c1c245-9c4d-4228-a65a-9f1085e133f8"), "DeleteDevice", new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), "删除设备" },
                    { new Guid("eadca0b2-6d88-4980-bdd7-5d36495ee7f1"), "UpdateDevice", new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), "修改设备" },
                    { new Guid("e49e4a1c-b9f9-4f58-b98c-3620f00ae240"), "AddDevice", new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), "新增设备" },
                    { new Guid("0d2a41e5-3627-43d3-bb84-c938a947292f"), "QueryDevice", new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), "查询设备" },
                    { new Guid("d9640d4d-baf9-47a4-a394-6d71fec9ddef"), "QueryReagent", new Guid("66cbdde8-a894-4d5d-8620-3ac8c37b0791"), "查询试剂" },
                    { new Guid("862ec34f-be37-4462-b782-e8d46d7af9d0"), "QueryLabware", new Guid("1edc0786-4408-44da-8d0c-aa88f2f2a9c9"), "查询耗材" },
                    { new Guid("511f3579-2841-4848-b80c-c4278bd11849"), "UpdateDict", new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "修改字典项" },
                    { new Guid("09b09c2f-eacf-4089-ad40-797bdda2c4ae"), "QueryPosition", new Guid("24d62360-b2d8-42c4-a0ae-76152e55562f"), "查询位置" },
                    { new Guid("792e680a-cd4e-47a8-b183-2c23d3dd535d"), "UpdateCell", new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), "修改细胞" },
                    { new Guid("ea7aaa55-d680-450c-89e1-d040017ec296"), "AddCell", new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), "新增细胞" },
                    { new Guid("b502ab49-d8d6-41ef-9bbf-e53b95cc5ceb"), "QueryCell", new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), "查询细胞" },
                    { new Guid("0c5f79bd-c397-4025-9264-9639ea49c69d"), "DeleteSpecies", new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), "删除物种" },
                    { new Guid("fef043fa-72b8-4bef-af31-41c0f839fbf6"), "UpdateSpecies", new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), "修改物种" },
                    { new Guid("97c3596c-4d39-410d-ab0f-22fa25c49155"), "AddSpecies", new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), "新增物种" },
                    { new Guid("12a92fc3-a88d-4601-96da-713dfebb0daf"), "QuerySpecies", new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), "查询物种" },
                    { new Guid("8eb5a63a-491e-41f9-a1bc-2673929037f0"), "QueryLog", new Guid("57f96d4c-b6a2-4582-adf7-8f3d13a959db"), "查询日志" },
                    { new Guid("249ad928-034a-4ea1-a9ad-9f3c17c40a07"), "UpdateDictValue", new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), "修改字典项值" },
                    { new Guid("b0151dc9-996c-4aa5-97d6-6bb880ad49e9"), "DeleteCell", new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), "删除细胞" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartmentRole",
                columns: new[] { "UserId", "DepartmentId", "RoleId" },
                values: new object[] { new Guid("72871f96-9674-4322-844f-43976a0afaee"), new Guid("1fefd903-624b-4d9b-b3f1-59dcb278a8fb"), new Guid("574ae085-4909-4123-b6c4-ca0efba05c52") });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" },
                values: new object[,]
                {
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("cce54550-ce05-404e-8aa0-7ef0b087de00") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("7de02c05-a351-4ebe-9e5e-1da18845da52") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("3122ca43-7098-40f5-96d7-e749d0a989c7") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("37c83e66-8d27-498c-855f-fa23ad8ae275") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("1487ac76-7a3c-4bac-930e-7cb6ba78c669") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("c11cf2b2-e4cf-49b8-b732-02f3b7d472a2") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("7b4b9ba1-9766-4dc6-8dd9-0f19b15c0edc") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("945a71bd-56aa-4f53-a176-163edde7555a") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("21a5c012-2e03-4cfa-a5fb-48f607074823") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("607d64bf-fd28-4e89-8356-8a180e471c8a") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("c33b2ca7-b4d7-46fd-b642-29ed3f1b0748") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("ae498aa0-7bd9-4fb6-9a56-ffda934b99c4") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("925d7744-a03b-49c2-817d-24d3e900208f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("b22e0f2a-991c-4721-a4f8-b6ece26aab7a") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("ae0886e7-6772-4170-96e6-d2b45987dfb2") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("f79c0c54-2055-4e6a-a761-cf66069453a9") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("f5332a01-e69a-4c32-a119-61648ce5ae40") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("9e068b9c-4319-407e-86df-1c48d8c3c6f7") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("df22a567-a9b4-40c0-ad42-cbb8a5127a6b") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("e2461ae0-0895-44c2-8c2e-0341082ad95d") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("3b5c2a85-cac6-4c5a-94b0-c1ba1d0fe165") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("8a3fea25-5f43-4a2b-b2db-21e2aaed17a4") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("a98060bf-80a4-4691-89be-239140d7b97b") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b595b71-510d-498c-a9b2-dab20f28e8da"), new Guid("9e61a0e9-bbd0-4969-94b3-053f9c94b3de") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), new Guid("0aecccce-65ea-463f-9ed7-e4a8c8934c7a") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), new Guid("5af731de-bacc-4489-bef5-f122582779d9") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), new Guid("9c2d0bc6-e2e0-43e6-9e93-344ca839fbf6") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), new Guid("15bd8c59-1bb5-4127-a19b-42be553d5d89") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), new Guid("16f8d431-fc74-4698-b842-2ec9187fbaf1") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), new Guid("bc66021f-9648-4df6-adbf-9e266a0c348b") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), new Guid("f926d75d-409a-4ffb-bd42-8bcf435b1e52") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), new Guid("d7ba2dc5-0f62-4143-a297-fbb1c0118d61") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"), new Guid("2afd4d3a-a5f9-4616-a30e-e84ce647659c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("04c34a70-4f89-441f-8a73-9cf9aff6265c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"), new Guid("20ba2f97-ad6b-4562-9cd4-fc79974f284e") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), new Guid("52118ed1-1466-4ca5-a732-66f02182fc03") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("e63afb0e-654d-46b7-af38-4aa0cbb9f27c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("dce5da26-eebd-4e09-8a39-57bce1760a64") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("57d21c8f-9b2b-4d41-8af3-bc2285bce6df") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("d4ae7341-ee88-4092-a4f0-99d7352e482f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("d480b21f-1c5c-4e4b-85ca-847438e48912") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("3a7fde22-602b-4449-8bfc-9cf2c0a9d6b4") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("b7d40835-b2cb-4360-85d1-39e01f6ae0b2") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("23047700-2da3-4ad4-899b-354f21d2393c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), new Guid("f51f3c67-cc12-4426-8ec6-9bd7d0385b85") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), new Guid("bd488987-79e1-41c7-93e0-a1a47ba704c5") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("48a5f738-e261-4f2b-abda-7bd82367f7d8") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("f5a9225c-e548-4c15-a925-1fa8502bd2c3") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("1210979c-8024-4180-bc52-403e17ccbc4c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("7df07530-d397-4ab8-8ade-6f0068db6b35") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("5276710c-9a4f-41e5-9bb0-d0cf4f91e44f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("c477fbcf-8787-4b9d-8e37-8052c0f4082c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("e7fcf4e3-5417-4139-bf72-4bd16b138ff1") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("3f0f9060-213a-4304-af2c-f5d39ace903f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("f456c8b5-d8d8-4b71-8bb5-4895f7fecb1c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("1f2449fc-6e0f-4383-94a4-bd751373cec3") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("624d5773-2520-4099-a8a0-0d6d32cf788e") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("2cc3fc36-45f9-45cc-840a-f5b9f02db2c7") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("eb5a56cf-d9e5-4c59-b6bc-6993e082634f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("5e13e970-1d23-4581-84d3-536b98f7ce1b") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("bc0fd9f1-5389-40fe-91d7-39f3c486faa7") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("84fef568-941e-4520-9226-d9cbbf9c4b7c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("845b8a96-3851-4a7c-8c02-3e9388d6f23e") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("d0380f84-60dd-4abd-b014-50b7ecd96e56") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("f36b3aba-8ff1-440a-a8c7-f46818f5729e") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("e5448ea1-60f5-42da-99a5-77796285c1dc") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("e8a50a37-eb36-4766-9fb2-d8eaed4ea5ca") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("0005712d-877e-47f1-8d89-5ff5b4f623a6") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("ce041e6a-779f-411b-be8b-0618bc6513eb") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("5cc09918-fecf-494e-82e4-e808e1554318") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("511f3579-2841-4848-b80c-c4278bd11849") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("05b4707b-bd6b-4595-b601-5be3724e347c") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("27fd9c5a-8d2a-4b7b-8c25-83a7b3d88c65") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("80c1c245-9c4d-4228-a65a-9f1085e133f8") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("eadca0b2-6d88-4980-bdd7-5d36495ee7f1") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("e49e4a1c-b9f9-4f58-b98c-3620f00ae240") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("0d2a41e5-3627-43d3-bb84-c938a947292f") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("66cbdde8-a894-4d5d-8620-3ac8c37b0791"), new Guid("d9640d4d-baf9-47a4-a394-6d71fec9ddef") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("1edc0786-4408-44da-8d0c-aa88f2f2a9c9"), new Guid("862ec34f-be37-4462-b782-e8d46d7af9d0") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("24d62360-b2d8-42c4-a0ae-76152e55562f"), new Guid("09b09c2f-eacf-4089-ad40-797bdda2c4ae") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("71ade60c-86b4-4337-b9dc-08252724b66b") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("b0151dc9-996c-4aa5-97d6-6bb880ad49e9") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("ea7aaa55-d680-450c-89e1-d040017ec296") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("b502ab49-d8d6-41ef-9bbf-e53b95cc5ceb") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("0c5f79bd-c397-4025-9264-9639ea49c69d") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("fef043fa-72b8-4bef-af31-41c0f839fbf6") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("97c3596c-4d39-410d-ab0f-22fa25c49155") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("12a92fc3-a88d-4601-96da-713dfebb0daf") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("57f96d4c-b6a2-4582-adf7-8f3d13a959db"), new Guid("8eb5a63a-491e-41f9-a1bc-2673929037f0") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("249ad928-034a-4ea1-a9ad-9f3c17c40a07") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("67f0ee56-876b-40ad-9c56-605979a0c5d1") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("792e680a-cd4e-47a8-b183-2c23d3dd535d") },
                    { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), new Guid("49cdb677-5eee-41ac-aa27-4d5af11aee8c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("0466f477-7372-4eee-a0bf-1727c8ba18c1"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("1bd011fc-89b8-430d-8026-48405153aac5"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("359ff969-4c3c-4436-8e4d-84212defae89"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("7041b779-78b3-4171-bd49-81c70bb654f4"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("8e243a04-6a75-4581-8b77-0cdc1fb6cabb"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("90ccadc8-a619-426c-8b0a-7e9245eca1a1"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("9141827f-9b79-4f83-af46-05b2ac885905"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("b6edd245-709c-46f7-bbd6-1f8c57f8985f"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("dafb9026-c451-49bc-bd3b-847c050fdfe2"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("f7c3617c-b4fc-416b-84a0-9c51a106d8cf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("14409391-adc2-4b1c-bb1d-4d22f426e62d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8c3a4acc-aba1-4f5c-b18d-b72516762175"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8c6618c5-a5b9-4333-9204-504289ea23a2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9aa606c8-631e-4fc5-b5fe-9235da7cd3a4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("aa00bce0-d1ce-47a3-b399-b9e7bde1e274"));

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("1edc0786-4408-44da-8d0c-aa88f2f2a9c9"), new Guid("862ec34f-be37-4462-b782-e8d46d7af9d0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("0005712d-877e-47f1-8d89-5ff5b4f623a6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("1210979c-8024-4180-bc52-403e17ccbc4c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("5276710c-9a4f-41e5-9bb0-d0cf4f91e44f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"), new Guid("7df07530-d397-4ab8-8ade-6f0068db6b35") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("24d62360-b2d8-42c4-a0ae-76152e55562f"), new Guid("09b09c2f-eacf-4089-ad40-797bdda2c4ae") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("04c34a70-4f89-441f-8a73-9cf9aff6265c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("48a5f738-e261-4f2b-abda-7bd82367f7d8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("df22a567-a9b4-40c0-ad42-cbb8a5127a6b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"), new Guid("e2461ae0-0895-44c2-8c2e-0341082ad95d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("5e13e970-1d23-4581-84d3-536b98f7ce1b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("845b8a96-3851-4a7c-8c02-3e9388d6f23e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("84fef568-941e-4520-9226-d9cbbf9c4b7c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"), new Guid("bc0fd9f1-5389-40fe-91d7-39f3c486faa7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("1487ac76-7a3c-4bac-930e-7cb6ba78c669") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("3122ca43-7098-40f5-96d7-e749d0a989c7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("37c83e66-8d27-498c-855f-fa23ad8ae275") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"), new Guid("c11cf2b2-e4cf-49b8-b732-02f3b7d472a2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), new Guid("49cdb677-5eee-41ac-aa27-4d5af11aee8c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"), new Guid("bd488987-79e1-41c7-93e0-a1a47ba704c5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("57f96d4c-b6a2-4582-adf7-8f3d13a959db"), new Guid("8eb5a63a-491e-41f9-a1bc-2673929037f0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("3f0f9060-213a-4304-af2c-f5d39ace903f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("c477fbcf-8787-4b9d-8e37-8052c0f4082c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("e7fcf4e3-5417-4139-bf72-4bd16b138ff1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"), new Guid("f456c8b5-d8d8-4b71-8bb5-4895f7fecb1c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("66cbdde8-a894-4d5d-8620-3ac8c37b0791"), new Guid("d9640d4d-baf9-47a4-a394-6d71fec9ddef") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("21a5c012-2e03-4cfa-a5fb-48f607074823") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("607d64bf-fd28-4e89-8356-8a180e471c8a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("7b4b9ba1-9766-4dc6-8dd9-0f19b15c0edc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"), new Guid("945a71bd-56aa-4f53-a176-163edde7555a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("05b4707b-bd6b-4595-b601-5be3724e347c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("27fd9c5a-8d2a-4b7b-8c25-83a7b3d88c65") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("71ade60c-86b4-4337-b9dc-08252724b66b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"), new Guid("f5a9225c-e548-4c15-a925-1fa8502bd2c3") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("9e068b9c-4319-407e-86df-1c48d8c3c6f7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("ae0886e7-6772-4170-96e6-d2b45987dfb2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("f5332a01-e69a-4c32-a119-61648ce5ae40") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"), new Guid("f79c0c54-2055-4e6a-a761-cf66069453a9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("0c5f79bd-c397-4025-9264-9639ea49c69d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("12a92fc3-a88d-4601-96da-713dfebb0daf") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("97c3596c-4d39-410d-ab0f-22fa25c49155") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"), new Guid("fef043fa-72b8-4bef-af31-41c0f839fbf6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("0d2a41e5-3627-43d3-bb84-c938a947292f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("80c1c245-9c4d-4228-a65a-9f1085e133f8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("e49e4a1c-b9f9-4f58-b98c-3620f00ae240") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"), new Guid("eadca0b2-6d88-4980-bdd7-5d36495ee7f1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("3b5c2a85-cac6-4c5a-94b0-c1ba1d0fe165") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("7de02c05-a351-4ebe-9e5e-1da18845da52") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("8a3fea25-5f43-4a2b-b2db-21e2aaed17a4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"), new Guid("a98060bf-80a4-4691-89be-239140d7b97b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("1f2449fc-6e0f-4383-94a4-bd751373cec3") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("2cc3fc36-45f9-45cc-840a-f5b9f02db2c7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("624d5773-2520-4099-a8a0-0d6d32cf788e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"), new Guid("eb5a56cf-d9e5-4c59-b6bc-6993e082634f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("9b595b71-510d-498c-a9b2-dab20f28e8da"), new Guid("9e61a0e9-bbd0-4969-94b3-053f9c94b3de") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("925d7744-a03b-49c2-817d-24d3e900208f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("ae498aa0-7bd9-4fb6-9a56-ffda934b99c4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("b22e0f2a-991c-4721-a4f8-b6ece26aab7a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"), new Guid("c33b2ca7-b4d7-46fd-b642-29ed3f1b0748") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("cce54550-ce05-404e-8aa0-7ef0b087de00") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("d0380f84-60dd-4abd-b014-50b7ecd96e56") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("e5448ea1-60f5-42da-99a5-77796285c1dc") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("e8a50a37-eb36-4766-9fb2-d8eaed4ea5ca") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"), new Guid("f36b3aba-8ff1-440a-a8c7-f46818f5729e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("792e680a-cd4e-47a8-b183-2c23d3dd535d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("b0151dc9-996c-4aa5-97d6-6bb880ad49e9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("b502ab49-d8d6-41ef-9bbf-e53b95cc5ceb") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"), new Guid("ea7aaa55-d680-450c-89e1-d040017ec296") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), new Guid("52118ed1-1466-4ca5-a732-66f02182fc03") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"), new Guid("f51f3c67-cc12-4426-8ec6-9bd7d0385b85") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"), new Guid("20ba2f97-ad6b-4562-9cd4-fc79974f284e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"), new Guid("2afd4d3a-a5f9-4616-a30e-e84ce647659c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), new Guid("16f8d431-fc74-4698-b842-2ec9187fbaf1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"), new Guid("bc66021f-9648-4df6-adbf-9e266a0c348b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("23047700-2da3-4ad4-899b-354f21d2393c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("3a7fde22-602b-4449-8bfc-9cf2c0a9d6b4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("57d21c8f-9b2b-4d41-8af3-bc2285bce6df") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("b7d40835-b2cb-4360-85d1-39e01f6ae0b2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("d480b21f-1c5c-4e4b-85ca-847438e48912") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("d4ae7341-ee88-4092-a4f0-99d7352e482f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("dce5da26-eebd-4e09-8a39-57bce1760a64") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"), new Guid("e63afb0e-654d-46b7-af38-4aa0cbb9f27c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("249ad928-034a-4ea1-a9ad-9f3c17c40a07") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("511f3579-2841-4848-b80c-c4278bd11849") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("5cc09918-fecf-494e-82e4-e808e1554318") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("67f0ee56-876b-40ad-9c56-605979a0c5d1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"), new Guid("ce041e6a-779f-411b-be8b-0618bc6513eb") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), new Guid("d7ba2dc5-0f62-4143-a297-fbb1c0118d61") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"), new Guid("f926d75d-409a-4ffb-bd42-8bcf435b1e52") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), new Guid("15bd8c59-1bb5-4127-a19b-42be553d5d89") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"), new Guid("9c2d0bc6-e2e0-43e6-9e93-344ca839fbf6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), new Guid("0aecccce-65ea-463f-9ed7-e4a8c8934c7a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"), new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"), new Guid("5af731de-bacc-4489-bef5-f122582779d9") });

            migrationBuilder.DeleteData(
                table: "UserDepartmentRole",
                keyColumns: new[] { "UserId", "DepartmentId", "RoleId" },
                keyValues: new object[] { new Guid("72871f96-9674-4322-844f-43976a0afaee"), new Guid("1fefd903-624b-4d9b-b3f1-59dcb278a8fb"), new Guid("574ae085-4909-4123-b6c4-ca0efba05c52") });

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0005712d-877e-47f1-8d89-5ff5b4f623a6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("04c34a70-4f89-441f-8a73-9cf9aff6265c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("05b4707b-bd6b-4595-b601-5be3724e347c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("09b09c2f-eacf-4089-ad40-797bdda2c4ae"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0aecccce-65ea-463f-9ed7-e4a8c8934c7a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0c5f79bd-c397-4025-9264-9639ea49c69d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0d2a41e5-3627-43d3-bb84-c938a947292f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1210979c-8024-4180-bc52-403e17ccbc4c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("12a92fc3-a88d-4601-96da-713dfebb0daf"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1487ac76-7a3c-4bac-930e-7cb6ba78c669"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("15bd8c59-1bb5-4127-a19b-42be553d5d89"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("16f8d431-fc74-4698-b842-2ec9187fbaf1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1f2449fc-6e0f-4383-94a4-bd751373cec3"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("20ba2f97-ad6b-4562-9cd4-fc79974f284e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("21a5c012-2e03-4cfa-a5fb-48f607074823"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("23047700-2da3-4ad4-899b-354f21d2393c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("249ad928-034a-4ea1-a9ad-9f3c17c40a07"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("27fd9c5a-8d2a-4b7b-8c25-83a7b3d88c65"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2afd4d3a-a5f9-4616-a30e-e84ce647659c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2cc3fc36-45f9-45cc-840a-f5b9f02db2c7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3122ca43-7098-40f5-96d7-e749d0a989c7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("37c83e66-8d27-498c-855f-fa23ad8ae275"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3a7fde22-602b-4449-8bfc-9cf2c0a9d6b4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3b5c2a85-cac6-4c5a-94b0-c1ba1d0fe165"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3f0f9060-213a-4304-af2c-f5d39ace903f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("48a5f738-e261-4f2b-abda-7bd82367f7d8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("49cdb677-5eee-41ac-aa27-4d5af11aee8c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("511f3579-2841-4848-b80c-c4278bd11849"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("52118ed1-1466-4ca5-a732-66f02182fc03"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5276710c-9a4f-41e5-9bb0-d0cf4f91e44f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("57d21c8f-9b2b-4d41-8af3-bc2285bce6df"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5af731de-bacc-4489-bef5-f122582779d9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5cc09918-fecf-494e-82e4-e808e1554318"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5e13e970-1d23-4581-84d3-536b98f7ce1b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("607d64bf-fd28-4e89-8356-8a180e471c8a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("624d5773-2520-4099-a8a0-0d6d32cf788e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("67f0ee56-876b-40ad-9c56-605979a0c5d1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("71ade60c-86b4-4337-b9dc-08252724b66b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("792e680a-cd4e-47a8-b183-2c23d3dd535d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7b4b9ba1-9766-4dc6-8dd9-0f19b15c0edc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7de02c05-a351-4ebe-9e5e-1da18845da52"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7df07530-d397-4ab8-8ade-6f0068db6b35"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("80c1c245-9c4d-4228-a65a-9f1085e133f8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("845b8a96-3851-4a7c-8c02-3e9388d6f23e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("84fef568-941e-4520-9226-d9cbbf9c4b7c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("862ec34f-be37-4462-b782-e8d46d7af9d0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8a3fea25-5f43-4a2b-b2db-21e2aaed17a4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8eb5a63a-491e-41f9-a1bc-2673929037f0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("925d7744-a03b-49c2-817d-24d3e900208f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("945a71bd-56aa-4f53-a176-163edde7555a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("97c3596c-4d39-410d-ab0f-22fa25c49155"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9c2d0bc6-e2e0-43e6-9e93-344ca839fbf6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9e068b9c-4319-407e-86df-1c48d8c3c6f7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9e61a0e9-bbd0-4969-94b3-053f9c94b3de"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a98060bf-80a4-4691-89be-239140d7b97b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ae0886e7-6772-4170-96e6-d2b45987dfb2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ae498aa0-7bd9-4fb6-9a56-ffda934b99c4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b0151dc9-996c-4aa5-97d6-6bb880ad49e9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b22e0f2a-991c-4721-a4f8-b6ece26aab7a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b502ab49-d8d6-41ef-9bbf-e53b95cc5ceb"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b7d40835-b2cb-4360-85d1-39e01f6ae0b2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bc0fd9f1-5389-40fe-91d7-39f3c486faa7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bc66021f-9648-4df6-adbf-9e266a0c348b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bd488987-79e1-41c7-93e0-a1a47ba704c5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c11cf2b2-e4cf-49b8-b732-02f3b7d472a2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c33b2ca7-b4d7-46fd-b642-29ed3f1b0748"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c477fbcf-8787-4b9d-8e37-8052c0f4082c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cce54550-ce05-404e-8aa0-7ef0b087de00"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ce041e6a-779f-411b-be8b-0618bc6513eb"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d0380f84-60dd-4abd-b014-50b7ecd96e56"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d480b21f-1c5c-4e4b-85ca-847438e48912"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d4ae7341-ee88-4092-a4f0-99d7352e482f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d7ba2dc5-0f62-4143-a297-fbb1c0118d61"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d9640d4d-baf9-47a4-a394-6d71fec9ddef"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dce5da26-eebd-4e09-8a39-57bce1760a64"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("df22a567-a9b4-40c0-ad42-cbb8a5127a6b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e2461ae0-0895-44c2-8c2e-0341082ad95d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e49e4a1c-b9f9-4f58-b98c-3620f00ae240"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e5448ea1-60f5-42da-99a5-77796285c1dc"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e63afb0e-654d-46b7-af38-4aa0cbb9f27c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e7fcf4e3-5417-4139-bf72-4bd16b138ff1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e8a50a37-eb36-4766-9fb2-d8eaed4ea5ca"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ea7aaa55-d680-450c-89e1-d040017ec296"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("eadca0b2-6d88-4980-bdd7-5d36495ee7f1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("eb5a56cf-d9e5-4c59-b6bc-6993e082634f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f36b3aba-8ff1-440a-a8c7-f46818f5729e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f456c8b5-d8d8-4b71-8bb5-4895f7fecb1c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f51f3c67-cc12-4426-8ec6-9bd7d0385b85"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f5332a01-e69a-4c32-a119-61648ce5ae40"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f5a9225c-e548-4c15-a925-1fa8502bd2c3"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f79c0c54-2055-4e6a-a761-cf66069453a9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f926d75d-409a-4ffb-bd42-8bcf435b1e52"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fef043fa-72b8-4bef-af31-41c0f839fbf6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1fefd903-624b-4d9b-b3f1-59dcb278a8fb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bda7fe73-e5d3-4ef3-a0b8-d77c512c6cfc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("574ae085-4909-4123-b6c4-ca0efba05c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72871f96-9674-4322-844f-43976a0afaee"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("1edc0786-4408-44da-8d0c-aa88f2f2a9c9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("23a3ccdb-de52-405d-81ad-e965375eeabe"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("24d62360-b2d8-42c4-a0ae-76152e55562f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("387f7cff-c6f3-42ef-baa4-592a96395af3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3ae1259f-598d-41eb-9880-338733ecb37c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("54b18211-5acb-4af7-a46e-e06ad3c04a74"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("566f37ac-bd48-429f-8298-7345c43a2c55"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("57f96d4c-b6a2-4582-adf7-8f3d13a959db"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5b437f45-ff33-4268-b8a0-1f160f9e63e2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("66cbdde8-a894-4d5d-8620-3ac8c37b0791"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6bcb1961-2903-465f-bf51-eb7504e4592b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("769b18a2-aab4-4dad-b6f2-01fac40df787"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7cd6d713-80af-41ad-b5da-7ab49256bfd8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8df97de7-9fc1-4e70-8cab-97b7874b3334"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("929d603c-06ca-4845-bf3b-ab3e8bf7ad15"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9762dea9-1cb8-45c3-af85-7fd869b69ee6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9b2010d1-d7d2-46e8-aa26-a93cfe462094"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9b595b71-510d-498c-a9b2-dab20f28e8da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b01c7f0d-2ced-443c-84e8-306ee8ba8eb2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b44cd111-64e4-4733-84a3-ad33ce3aef70"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b6a18382-345c-4703-94db-03f40b4bd21a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bbcee40b-1898-44c7-9237-ade035bee7d3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bdf03b4e-a3b2-4a23-a969-ace12f5340ec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ccb5ec96-aacb-40ad-9918-30b2803ffcfa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d3e87668-21b1-48fa-9239-b1a555873afc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d721b3be-ffd9-43c5-ac45-c39944a89e61"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e29c668c-0b92-43d8-9866-7e3cca77daaa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("feba01e4-98c8-483a-b284-dbf3eb7dbe91"));

            migrationBuilder.DropColumn(
                name: "DetectionPicture",
                table: "SterilityDetection");

            migrationBuilder.DropColumn(
                name: "DetectionPicture",
                table: "SdsPageDetection");

            migrationBuilder.DropColumn(
                name: "EnzymeCuttingPicture",
                table: "PlasmidPurification");

            migrationBuilder.DropColumn(
                name: "AnalysisReport",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AnalysisReportFileId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EnzymeCuttingPicture",
                table: "MolecularCloning");

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
    }
}
