using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddShipmentMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3686c957-edd5-461b-b697-b9d603db60c3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b1c1d0db-d0b6-4f54-bab2-bed7fa247779"));

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("18962658-0157-4b19-8687-059ae542a05d"), new Guid("7c550b69-5ec1-4f26-8179-89e35f04b413") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("07c33006-2f49-4dfa-ac67-af5dc7477fce") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("3f05a015-0d24-4e8c-b72f-bed3e146f5e1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("55a29b85-4be3-4598-95b9-9719dc5c2847") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("9b805cde-c0a4-4389-ab41-d1710bdf82ac") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("2d75fd69-be11-43ce-a88d-f618cb318248") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("65c1b920-fe0a-4f7c-a473-e2be1b9088d9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("a7477f64-252e-4792-b439-730f3fa8a109") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("dcd021c2-6ae4-40ed-9830-9453ae935103") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("405dbfc2-6728-42c8-98dc-ad896f65d03c"), new Guid("6cc1c906-8730-46f6-9c65-619070db0d00") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("032b5097-ed6c-48df-8cd5-b8a502474f02") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("8b1c54c8-f0a1-48ba-8337-04a1ddc7ac6c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("a1838bf7-3ab3-4190-ac6d-1c610d59cf20") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("bf712af0-a843-4a04-aa68-6bbd873ddbab") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("e007b218-cd17-4881-a638-1334d446d1d9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("23170dc3-ea7d-4bd3-9cb8-9fce3ac90410") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("3721cb3f-bd2f-4c05-98d6-b782a448b994") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("4d983b17-4d34-4206-9527-ef2d1d5212b7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("9c795bed-c9ee-4af7-881d-8310fa5e2ec4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("55c9d00b-d7f9-433d-a12d-9a05525e2838"), new Guid("c463fa8f-1ccb-4004-a6e1-c61e712a840f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("598ea3ae-262f-485f-8017-be3e45b36741") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("953e3c9f-c648-493c-a17a-92f7fcee6422") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("bf570b4d-b3c7-46b7-87fd-4e60887588f0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("eac75ad8-c65a-41b2-aeb3-6b68a3771ad4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("01a6c4d6-8c7b-4cfe-b1fa-022641a436bb") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("0fccfbd3-26db-4dfc-a7da-38afc820c0ee") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("26c67e24-a662-4784-8dac-5d3019ad96a3") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("7a6b1f68-8a9e-47d6-98ff-5fd73a04163f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("96cb3c26-3c42-4d27-86f6-7d573133dc0f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c1d795f4-c36f-4dc9-9be9-c1fcbd3776e2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c4cb610a-be3e-4e43-9cb1-aa44497f7012") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c8fba0cf-cf75-498e-92b3-a361f0e45990") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("2a19e86d-691a-45cb-97d0-aa462e82b128") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("3903f7e0-800c-472d-9056-9280dc7fee85") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("3cd9bfaa-0804-4e63-a5c5-88eb48904aba") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("af85023c-b3f6-4251-b21b-5185b1322c54") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("1c6b0d7a-ff79-46e4-a989-0fa87bc713ba") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("1fc6f7c1-c041-4fa8-993b-ccbe43fac3a0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("7c613761-706e-4c6f-8ec8-9ab19cf95f7d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("dc309dec-f340-4128-9278-e072a3be2609") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("009d1ed9-dd20-425b-a9be-6efa30217f7d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("7aee416a-a3e1-4b85-b9a0-1e64f519d5c9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("f52804c7-e413-47f4-bdac-d90e5800e2c1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("f9bf9f52-4a97-455b-a925-a6ae30623f98") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("072b38c3-b7df-48d3-a2f0-e7894d420455") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("83bede36-2944-44ed-bd6c-4236863326ac") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("a9270634-897e-4da3-9efa-f625e00d5dc4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("eca11d90-9930-4ec2-a8ba-83a712c7bb0c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("bc37e0ef-a2a5-4b2a-8d43-41a4212b4660"), new Guid("50bef62f-8a71-4995-9b81-6230f9b9a0a5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("0bb1dccd-2ed9-495e-b5b6-c38fe8a60038") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("5dbbffe2-c9cf-4401-818f-74b48dad39ac") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("9ca95f44-55a9-47d0-b54d-acc31c2d8195") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("dffcb380-a0df-4ba3-a2b7-d426699eb51d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("3b67ff3f-9419-4344-8346-194ccc597207") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("4d0ff55c-37e4-4120-8f4c-f2b350c43f7a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("7ede79e8-3720-4bb3-93a5-66c6e71d2a46") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("befdbeb9-b943-4929-9efe-2bda694672d3") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("13968f94-4723-453c-b485-1e81382c62f7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("7a79aad3-8974-4c55-aa3a-99d2b983a236") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("912cb8ba-7666-46e2-a948-1ca6e7e6802e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("cc45a9c3-f522-4d3b-8e0c-b1c6a4f17d77") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("94b077f5-6020-4c3b-9ce6-38057b45d775") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("a37ecd7f-c235-4d3e-b350-c991c0e78590") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("f4c4f8d5-163d-41ea-9519-84513a3b5db4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("fe8f919f-2c46-43e7-8ecd-ff72187d96a2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("6181ea92-177b-4f49-81f7-c6c9dea25755") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("b8776a37-49e1-4e26-9cf8-9bc6857d747e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("dc2ab682-a0cd-4379-976a-a7dd35e21aad") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("e255c2b8-f00a-4b41-8629-df0321029d79") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("f09ce904-3eb8-489e-8e6a-86d4a953e07d"), new Guid("bd488e50-04d4-4845-8960-eddc6b99ce74") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("32cd9d88-cf63-4d8f-bc02-abef629ed94b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("6d846116-b8df-434a-addb-dd5c7f83721c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("d72050d3-7ff6-4f5d-94a2-4ff15a9c63f7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("dbb69650-c913-4c45-b4b4-ee2bb9cb06ef") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("f88a11c4-22fe-41b5-99aa-21824609d0e5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("04a62669-a3c6-4304-84f0-98dbc43292ec") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("72d8fdb9-b7de-4408-b831-12947d66c797") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("960e53c5-1995-44ea-a2c4-ec6769bc45c8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("bc44ed28-992e-4133-a3e0-19df1aa98970") });

            migrationBuilder.DeleteData(
                table: "UserDepartmentRole",
                keyColumns: new[] { "UserId", "DepartmentId", "RoleId" },
                keyValues: new object[] { new Guid("8ebb78c0-2703-4632-8f94-998666788413"), new Guid("d328f396-f9e3-476c-a7e9-1687c21f0a0f"), new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc") });

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("009d1ed9-dd20-425b-a9be-6efa30217f7d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("01a6c4d6-8c7b-4cfe-b1fa-022641a436bb"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("032b5097-ed6c-48df-8cd5-b8a502474f02"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("04a62669-a3c6-4304-84f0-98dbc43292ec"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("072b38c3-b7df-48d3-a2f0-e7894d420455"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("07c33006-2f49-4dfa-ac67-af5dc7477fce"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0bb1dccd-2ed9-495e-b5b6-c38fe8a60038"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0fccfbd3-26db-4dfc-a7da-38afc820c0ee"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("13968f94-4723-453c-b485-1e81382c62f7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1c6b0d7a-ff79-46e4-a989-0fa87bc713ba"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1fc6f7c1-c041-4fa8-993b-ccbe43fac3a0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("23170dc3-ea7d-4bd3-9cb8-9fce3ac90410"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("26c67e24-a662-4784-8dac-5d3019ad96a3"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2a19e86d-691a-45cb-97d0-aa462e82b128"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2d75fd69-be11-43ce-a88d-f618cb318248"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("32cd9d88-cf63-4d8f-bc02-abef629ed94b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3721cb3f-bd2f-4c05-98d6-b782a448b994"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3903f7e0-800c-472d-9056-9280dc7fee85"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3b67ff3f-9419-4344-8346-194ccc597207"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3cd9bfaa-0804-4e63-a5c5-88eb48904aba"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3f05a015-0d24-4e8c-b72f-bed3e146f5e1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4d0ff55c-37e4-4120-8f4c-f2b350c43f7a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4d983b17-4d34-4206-9527-ef2d1d5212b7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("50bef62f-8a71-4995-9b81-6230f9b9a0a5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("55a29b85-4be3-4598-95b9-9719dc5c2847"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("598ea3ae-262f-485f-8017-be3e45b36741"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5dbbffe2-c9cf-4401-818f-74b48dad39ac"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6181ea92-177b-4f49-81f7-c6c9dea25755"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("65c1b920-fe0a-4f7c-a473-e2be1b9088d9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6cc1c906-8730-46f6-9c65-619070db0d00"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6d846116-b8df-434a-addb-dd5c7f83721c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("72d8fdb9-b7de-4408-b831-12947d66c797"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7a6b1f68-8a9e-47d6-98ff-5fd73a04163f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7a79aad3-8974-4c55-aa3a-99d2b983a236"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7aee416a-a3e1-4b85-b9a0-1e64f519d5c9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7c550b69-5ec1-4f26-8179-89e35f04b413"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7c613761-706e-4c6f-8ec8-9ab19cf95f7d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7ede79e8-3720-4bb3-93a5-66c6e71d2a46"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("83bede36-2944-44ed-bd6c-4236863326ac"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8b1c54c8-f0a1-48ba-8337-04a1ddc7ac6c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("912cb8ba-7666-46e2-a948-1ca6e7e6802e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("94b077f5-6020-4c3b-9ce6-38057b45d775"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("953e3c9f-c648-493c-a17a-92f7fcee6422"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("960e53c5-1995-44ea-a2c4-ec6769bc45c8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("96cb3c26-3c42-4d27-86f6-7d573133dc0f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9b805cde-c0a4-4389-ab41-d1710bdf82ac"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9c795bed-c9ee-4af7-881d-8310fa5e2ec4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9ca95f44-55a9-47d0-b54d-acc31c2d8195"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a1838bf7-3ab3-4190-ac6d-1c610d59cf20"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a37ecd7f-c235-4d3e-b350-c991c0e78590"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a7477f64-252e-4792-b439-730f3fa8a109"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a9270634-897e-4da3-9efa-f625e00d5dc4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("af85023c-b3f6-4251-b21b-5185b1322c54"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b8776a37-49e1-4e26-9cf8-9bc6857d747e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bc44ed28-992e-4133-a3e0-19df1aa98970"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bd488e50-04d4-4845-8960-eddc6b99ce74"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("befdbeb9-b943-4929-9efe-2bda694672d3"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bf570b4d-b3c7-46b7-87fd-4e60887588f0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bf712af0-a843-4a04-aa68-6bbd873ddbab"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c1d795f4-c36f-4dc9-9be9-c1fcbd3776e2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c463fa8f-1ccb-4004-a6e1-c61e712a840f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c4cb610a-be3e-4e43-9cb1-aa44497f7012"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c8fba0cf-cf75-498e-92b3-a361f0e45990"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cc45a9c3-f522-4d3b-8e0c-b1c6a4f17d77"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d72050d3-7ff6-4f5d-94a2-4ff15a9c63f7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dbb69650-c913-4c45-b4b4-ee2bb9cb06ef"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dc2ab682-a0cd-4379-976a-a7dd35e21aad"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dc309dec-f340-4128-9278-e072a3be2609"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dcd021c2-6ae4-40ed-9830-9453ae935103"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("dffcb380-a0df-4ba3-a2b7-d426699eb51d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e007b218-cd17-4881-a638-1334d446d1d9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e255c2b8-f00a-4b41-8629-df0321029d79"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("eac75ad8-c65a-41b2-aeb3-6b68a3771ad4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("eca11d90-9930-4ec2-a8ba-83a712c7bb0c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f4c4f8d5-163d-41ea-9519-84513a3b5db4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f52804c7-e413-47f4-bdac-d90e5800e2c1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f88a11c4-22fe-41b5-99aa-21824609d0e5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f9bf9f52-4a97-455b-a925-a6ae30623f98"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fe8f919f-2c46-43e7-8ecd-ff72187d96a2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d328f396-f9e3-476c-a7e9-1687c21f0a0f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ebb78c0-2703-4632-8f94-998666788413"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("18962658-0157-4b19-8687-059ae542a05d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("405dbfc2-6728-42c8-98dc-ad896f65d03c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("41d94627-6e49-4f97-b577-9103db3e5760"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("55c9d00b-d7f9-433d-a12d-9a05525e2838"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bc37e0ef-a2a5-4b2a-8d43-41a4212b4660"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f09ce904-3eb8-489e-8e6a-86d4a953e07d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("d328f396-f9e3-476c-a7e9-1687c21f0a0f"), "13245679856", new DateTime(2021, 8, 3, 16, 14, 47, 170, DateTimeKind.Local).AddTicks(5625), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "张三", "深圳镁伽", 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Component", "CreatedAt", "Hidden", "Icon", "IsActive", "IsDeleted", "LastModifiedAt", "Name", "OrdinalNumber", "ParentId", "Path", "Redirect", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), "分子克隆", "produce/clone/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2287), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_clone", 28, new Guid("3686c957-edd5-461b-b697-b9d603db60c3"), "clone", null, "分子克隆", 1, "clone" },
                    { new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), "订单", "produce/order/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2278), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_order", 27, new Guid("3686c957-edd5-461b-b697-b9d603db60c3"), "order", null, "订单", 1, "order" },
                    { new Guid("3686c957-edd5-461b-b697-b9d603db60c3"), "生产管理", "Layout", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2275), false, "el-icon-s-cooperation", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce", 26, new Guid("00000000-0000-0000-0000-000000000000"), "/produce", "/produce", "生产管理", 0, "/produce" },
                    { new Guid("f09ce904-3eb8-489e-8e6a-86d4a953e07d"), "排程", "items/aps/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2271), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_aps", 25, new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "aps", null, "排程", 1, "aps" },
                    { new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), "Take管理", "items/task/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2262), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_take", 24, new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "take", null, "Take管理", 1, "take" },
                    { new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), "项目管理", "items/project/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2229), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_project", 23, new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "project", null, "项目管理", 1, "project" },
                    { new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), "节点管理", "items/node/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2220), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_node", 22, new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "node", null, "节点管理", 1, "node" },
                    { new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), "Protocol Step管理", "items/proStep/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2211), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_protocol", 21, new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "protocol", null, "Protocol Step管理", 1, "protocol" },
                    { new Guid("5fce4782-d3b7-40de-b9d1-70f30f3c8115"), "项目管理", "Layout", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2208), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itiems", 20, new Guid("00000000-0000-0000-0000-000000000000"), "/items", "/items", "项目管理", 0, "/items" },
                    { new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), "今日任务", "task/today/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2201), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_today", 19, new Guid("b1c1d0db-d0b6-4f54-bab2-bed7fa247779"), "today", null, "今日任务", 1, "today" },
                    { new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), "我的任务", "task/myTask/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2193), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_owner", 18, new Guid("b1c1d0db-d0b6-4f54-bab2-bed7fa247779"), "owner", null, "我的任务", 1, "owner" },
                    { new Guid("b1c1d0db-d0b6-4f54-bab2-bed7fa247779"), "任务管理", "Layout", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2189), false, "el-icon-document-copy", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task", 17, new Guid("00000000-0000-0000-0000-000000000000"), "/task", "/task/today", "任务管理", 0, "/task" },
                    { new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), "样本管理", "sample/sample/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2181), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample_sample", 16, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "sample", null, "样本管理", 1, "sample" },
                    { new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), "设备管理", "basic/equipment/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2173), false, "el-icon-suitcase", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_equipment", 15, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "equipment", null, "设备管理", 1, "equipment" },
                    { new Guid("55c9d00b-d7f9-433d-a12d-9a05525e2838"), "耗材管理", "basic/material/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2163), false, "el-icon-printer", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_material", 13, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "material", null, "耗材管理", 1, "material" },
                    { new Guid("bc37e0ef-a2a5-4b2a-8d43-41a4212b4660"), "位置管理", "basic/place/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2159), false, "el-icon-location", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_place", 12, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "place", null, "位置管理", 1, "place" },
                    { new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), "细胞管理", "basic/cells/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2151), false, "cells", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_cells", 11, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "cells", null, "细胞管理", 1, "cells" },
                    { new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), "物种管理", "basic/species/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2142), false, "el-icon-more", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_species", 10, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "species", null, "物种管理", 1, "species" },
                    { new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "基础数据配置", "Layout", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2132), false, "el-icon-files", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic", 9, new Guid("00000000-0000-0000-0000-000000000000"), "/basic", "/basic/user", "基础数据配置", 0, "/basic" },
                    { new Guid("405dbfc2-6728-42c8-98dc-ad896f65d03c"), "日志管理", "system/logs/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2126), false, "el-icon-edit-outline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_log", 8, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "log", null, "日志管理", 1, "log" },
                    { new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "字典项管理", "system/dictionary/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2117), false, "el-icon-tickets", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_dictionary", 7, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "dictionary", null, "字典项管理", 1, "dictionary" },
                    { new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), "菜单管理", "system/menu/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2108), false, "el-icon-menu", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_menu", 6, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "menu", null, "菜单管理", 1, "menu" },
                    { new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), "角色管理", "system/role/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2099), false, "el-icon-s-opportunity", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_role", 5, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "role", null, "角色管理", 1, "role" },
                    { new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), "部门管理", "system/department/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2088), false, "peoples", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_department", 4, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "department", null, "部门管理", 1, "department" },
                    { new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), "技能管理", "system/skill/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2032), false, "skill", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_skill", 3, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "skill", null, "技能管理", 1, "skill" },
                    { new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "用户管理", "system/user/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(1107), false, "el-icon-user", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_user", 2, new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "user", null, "用户管理", 1, "user" },
                    { new Guid("005f028c-3656-4316-b09c-c7a2dbb63867"), "系统管理", "Layout", new DateTime(2021, 8, 3, 16, 14, 47, 170, DateTimeKind.Local).AddTicks(9370), false, "el-icon-s-tools", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", 1, new Guid("00000000-0000-0000-0000-000000000000"), "/system", "/system/user", "系统管理", 0, "/system" },
                    { new Guid("18962658-0157-4b19-8687-059ae542a05d"), "试剂管理", "basic/reagent/index", new DateTime(2021, 8, 3, 16, 14, 47, 171, DateTimeKind.Local).AddTicks(2167), false, "chemistry", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_reagent", 14, new Guid("84d017c4-1bea-48e8-94a5-adfddd11fc20"), "reagent", null, "试剂管理", 1, "reagent" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Name" },
                values: new object[] { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new DateTime(2021, 8, 3, 16, 14, 47, 170, DateTimeKind.Local).AddTicks(7352), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "超级管理员" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "IsActive", "IsDeleted", "LastModifiedAt", "MobileNumber", "Password", "UserName", "WorkTime" },
                values: new object[] { new Guid("8ebb78c0-2703-4632-8f94-998666788413"), new DateTime(2021, 8, 3, 16, 14, 47, 167, DateTimeKind.Local).AddTicks(8802), "234298234@qq.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13523429876", null, "admin@admin.com", "8:00-9:00" });

            migrationBuilder.InsertData(
                table: "Button",
                columns: new[] { "Id", "Code", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("dbb69650-c913-4c45-b4b4-ee2bb9cb06ef"), "QueryUser", new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "查询用户" },
                    { new Guid("009d1ed9-dd20-425b-a9be-6efa30217f7d"), "DeleteProtocolStep", new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), "删除ProtocolStep" },
                    { new Guid("7aee416a-a3e1-4b85-b9a0-1e64f519d5c9"), "UpdateProtocolStep", new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), "修改ProtocolStep" },
                    { new Guid("f52804c7-e413-47f4-bdac-d90e5800e2c1"), "AddProtocolStep", new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), "新增ProtocolStep" },
                    { new Guid("f9bf9f52-4a97-455b-a925-a6ae30623f98"), "QueryProtocolStep", new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), "查询ProtocolStep" },
                    { new Guid("72d8fdb9-b7de-4408-b831-12947d66c797"), "DeleteTask", new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), "删除今日任务" },
                    { new Guid("bc44ed28-992e-4133-a3e0-19df1aa98970"), "UpdateTask", new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), "修改今日任务" },
                    { new Guid("04a62669-a3c6-4304-84f0-98dbc43292ec"), "AddTask", new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), "新增今日任务" },
                    { new Guid("eca11d90-9930-4ec2-a8ba-83a712c7bb0c"), "QueryNode", new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), "查询节点" },
                    { new Guid("960e53c5-1995-44ea-a2c4-ec6769bc45c8"), "QueryTask", new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), "查询今日任务" },
                    { new Guid("598ea3ae-262f-485f-8017-be3e45b36741"), "UpdateMyTask", new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), "修改我的任务" },
                    { new Guid("eac75ad8-c65a-41b2-aeb3-6b68a3771ad4"), "AddMyTask", new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), "新增我的任务" },
                    { new Guid("953e3c9f-c648-493c-a17a-92f7fcee6422"), "QueryMyTask", new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), "查询我的任务" },
                    { new Guid("1fc6f7c1-c041-4fa8-993b-ccbe43fac3a0"), "DeleteSample", new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), "删除样本" },
                    { new Guid("7c613761-706e-4c6f-8ec8-9ab19cf95f7d"), "UpdateSample", new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), "修改样本" },
                    { new Guid("dc309dec-f340-4128-9278-e072a3be2609"), "AddSample", new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), "新增样本" },
                    { new Guid("1c6b0d7a-ff79-46e4-a989-0fa87bc713ba"), "QuerySample", new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), "查询样本" },
                    { new Guid("bf570b4d-b3c7-46b7-87fd-4e60887588f0"), "DeleteMyTask", new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), "删除我的任务" },
                    { new Guid("f4c4f8d5-163d-41ea-9519-84513a3b5db4"), "DeleteDevice", new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), "删除设备" },
                    { new Guid("a9270634-897e-4da3-9efa-f625e00d5dc4"), "AddNode", new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), "新增节点" },
                    { new Guid("072b38c3-b7df-48d3-a2f0-e7894d420455"), "DeleteNode", new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), "删除节点" },
                    { new Guid("912cb8ba-7666-46e2-a948-1ca6e7e6802e"), "UpdateCloning", new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), "修改分子克隆" },
                    { new Guid("7a79aad3-8974-4c55-aa3a-99d2b983a236"), "AddCloning", new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), "新增分子克隆" },
                    { new Guid("13968f94-4723-453c-b485-1e81382c62f7"), "QueryCloning", new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), "查询分子克隆" },
                    { new Guid("7ede79e8-3720-4bb3-93a5-66c6e71d2a46"), "DeleteOrder", new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), "删除订单" },
                    { new Guid("4d0ff55c-37e4-4120-8f4c-f2b350c43f7a"), "UpdateOrder", new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), "修改订单" },
                    { new Guid("befdbeb9-b943-4929-9efe-2bda694672d3"), "AddOrder", new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), "新增订单" },
                    { new Guid("3b67ff3f-9419-4344-8346-194ccc597207"), "QueryOrder", new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), "查询订单" },
                    { new Guid("83bede36-2944-44ed-bd6c-4236863326ac"), "UpdateNode", new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), "修改节点" },
                    { new Guid("bd488e50-04d4-4845-8960-eddc6b99ce74"), "QuerySchedule", new Guid("f09ce904-3eb8-489e-8e6a-86d4a953e07d"), "查询排程" },
                    { new Guid("6181ea92-177b-4f49-81f7-c6c9dea25755"), "UpdateTake", new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), "修改Take" },
                    { new Guid("b8776a37-49e1-4e26-9cf8-9bc6857d747e"), "AddTake", new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), "新增Take" },
                    { new Guid("dc2ab682-a0cd-4379-976a-a7dd35e21aad"), "QueryTake", new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), "查询Take" },
                    { new Guid("01a6c4d6-8c7b-4cfe-b1fa-022641a436bb"), "DeleteProject", new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), "删除项目" },
                    { new Guid("7a6b1f68-8a9e-47d6-98ff-5fd73a04163f"), "UpdateProject", new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), "修改项目" },
                    { new Guid("0fccfbd3-26db-4dfc-a7da-38afc820c0ee"), "AddProject", new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), "新增项目" },
                    { new Guid("26c67e24-a662-4784-8dac-5d3019ad96a3"), "QueryProject", new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), "查询项目" },
                    { new Guid("e255c2b8-f00a-4b41-8629-df0321029d79"), "DeleteTake", new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), "删除Take" },
                    { new Guid("fe8f919f-2c46-43e7-8ecd-ff72187d96a2"), "UpdateDevice", new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), "修改设备" },
                    { new Guid("94b077f5-6020-4c3b-9ce6-38057b45d775"), "AddDevice", new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), "新增设备" },
                    { new Guid("a37ecd7f-c235-4d3e-b350-c991c0e78590"), "QueryDevice", new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), "查询设备" },
                    { new Guid("c8fba0cf-cf75-498e-92b3-a361f0e45990"), "DeleteRole", new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), "删除角色" },
                    { new Guid("96cb3c26-3c42-4d27-86f6-7d573133dc0f"), "UpdateRole", new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), "修改角色" },
                    { new Guid("c4cb610a-be3e-4e43-9cb1-aa44497f7012"), "AddRole", new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), "新增角色" },
                    { new Guid("c1d795f4-c36f-4dc9-9be9-c1fcbd3776e2"), "QueryRole", new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), "查询角色" },
                    { new Guid("3903f7e0-800c-472d-9056-9280dc7fee85"), "DeleteDepartment", new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), "删除部门" },
                    { new Guid("af85023c-b3f6-4251-b21b-5185b1322c54"), "UpdateDepartment", new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), "修改部门" },
                    { new Guid("3cd9bfaa-0804-4e63-a5c5-88eb48904aba"), "AddDepartment", new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), "新增部门" },
                    { new Guid("3f05a015-0d24-4e8c-b72f-bed3e146f5e1"), "QueryMenu", new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), "查询菜单" },
                    { new Guid("2a19e86d-691a-45cb-97d0-aa462e82b128"), "QueryDepartment", new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), "查询部门" },
                    { new Guid("a7477f64-252e-4792-b439-730f3fa8a109"), "UpdateSkill", new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), "修改技能" },
                    { new Guid("65c1b920-fe0a-4f7c-a473-e2be1b9088d9"), "AddSkill", new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), "新增技能" },
                    { new Guid("dcd021c2-6ae4-40ed-9830-9453ae935103"), "QuerySkill", new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), "查询技能" },
                    { new Guid("6d846116-b8df-434a-addb-dd5c7f83721c"), "ResetUser", new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "重置用户" },
                    { new Guid("d72050d3-7ff6-4f5d-94a2-4ff15a9c63f7"), "DeleteUser", new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "删除用户" },
                    { new Guid("32cd9d88-cf63-4d8f-bc02-abef629ed94b"), "UpdateUser", new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "修改用户" },
                    { new Guid("f88a11c4-22fe-41b5-99aa-21824609d0e5"), "AddUser", new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), "新增用户" },
                    { new Guid("2d75fd69-be11-43ce-a88d-f618cb318248"), "DeleteSkill", new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), "删除技能" },
                    { new Guid("55a29b85-4be3-4598-95b9-9719dc5c2847"), "AddMenu", new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), "新增菜单" },
                    { new Guid("07c33006-2f49-4dfa-ac67-af5dc7477fce"), "UpdateMenu", new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), "修改菜单" },
                    { new Guid("9b805cde-c0a4-4389-ab41-d1710bdf82ac"), "DeleteMenu", new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), "删除菜单" },
                    { new Guid("7c550b69-5ec1-4f26-8179-89e35f04b413"), "QueryReagent", new Guid("18962658-0157-4b19-8687-059ae542a05d"), "查询试剂" },
                    { new Guid("c463fa8f-1ccb-4004-a6e1-c61e712a840f"), "QueryLabware", new Guid("55c9d00b-d7f9-433d-a12d-9a05525e2838"), "查询耗材" },
                    { new Guid("50bef62f-8a71-4995-9b81-6230f9b9a0a5"), "QueryPosition", new Guid("bc37e0ef-a2a5-4b2a-8d43-41a4212b4660"), "查询位置" },
                    { new Guid("0bb1dccd-2ed9-495e-b5b6-c38fe8a60038"), "DeleteCell", new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), "删除细胞" },
                    { new Guid("dffcb380-a0df-4ba3-a2b7-d426699eb51d"), "UpdateCell", new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), "修改细胞" },
                    { new Guid("5dbbffe2-c9cf-4401-818f-74b48dad39ac"), "AddCell", new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), "新增细胞" },
                    { new Guid("9ca95f44-55a9-47d0-b54d-acc31c2d8195"), "QueryCell", new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), "查询细胞" },
                    { new Guid("4d983b17-4d34-4206-9527-ef2d1d5212b7"), "DeleteSpecies", new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), "删除物种" },
                    { new Guid("9c795bed-c9ee-4af7-881d-8310fa5e2ec4"), "UpdateSpecies", new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), "修改物种" },
                    { new Guid("3721cb3f-bd2f-4c05-98d6-b782a448b994"), "AddSpecies", new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), "新增物种" },
                    { new Guid("23170dc3-ea7d-4bd3-9cb8-9fce3ac90410"), "QuerySpecies", new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), "查询物种" },
                    { new Guid("6cc1c906-8730-46f6-9c65-619070db0d00"), "QueryLog", new Guid("405dbfc2-6728-42c8-98dc-ad896f65d03c"), "查询日志" },
                    { new Guid("a1838bf7-3ab3-4190-ac6d-1c610d59cf20"), "UpdateDictValue", new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "修改字典项值" },
                    { new Guid("032b5097-ed6c-48df-8cd5-b8a502474f02"), "DeleteDict", new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "删除字典项" },
                    { new Guid("bf712af0-a843-4a04-aa68-6bbd873ddbab"), "UpdateDict", new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "修改字典项" },
                    { new Guid("8b1c54c8-f0a1-48ba-8337-04a1ddc7ac6c"), "AddDict", new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "新增字典项" },
                    { new Guid("e007b218-cd17-4881-a638-1334d446d1d9"), "QueryDict", new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), "查询字典项" },
                    { new Guid("cc45a9c3-f522-4d3b-8e0c-b1c6a4f17d77"), "DeleteCloning", new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), "删除分子克隆" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartmentRole",
                columns: new[] { "UserId", "DepartmentId", "RoleId" },
                values: new object[] { new Guid("8ebb78c0-2703-4632-8f94-998666788413"), new Guid("d328f396-f9e3-476c-a7e9-1687c21f0a0f"), new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc") });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" },
                values: new object[,]
                {
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("dbb69650-c913-4c45-b4b4-ee2bb9cb06ef") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("7aee416a-a3e1-4b85-b9a0-1e64f519d5c9") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("f52804c7-e413-47f4-bdac-d90e5800e2c1") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("f9bf9f52-4a97-455b-a925-a6ae30623f98") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("72d8fdb9-b7de-4408-b831-12947d66c797") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("bc44ed28-992e-4133-a3e0-19df1aa98970") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("04a62669-a3c6-4304-84f0-98dbc43292ec") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fb1c4b54-dbb5-489a-a024-d4e5912d1a7b"), new Guid("960e53c5-1995-44ea-a2c4-ec6769bc45c8") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("aa378fda-8d94-4d4b-9803-246c7da7c7c2"), new Guid("009d1ed9-dd20-425b-a9be-6efa30217f7d") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("bf570b4d-b3c7-46b7-87fd-4e60887588f0") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("eac75ad8-c65a-41b2-aeb3-6b68a3771ad4") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("953e3c9f-c648-493c-a17a-92f7fcee6422") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("1fc6f7c1-c041-4fa8-993b-ccbe43fac3a0") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("7c613761-706e-4c6f-8ec8-9ab19cf95f7d") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("dc309dec-f340-4128-9278-e072a3be2609") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("99b2f202-ee6a-47be-b8db-288740882a3d"), new Guid("1c6b0d7a-ff79-46e4-a989-0fa87bc713ba") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("f4c4f8d5-163d-41ea-9519-84513a3b5db4") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("60b0c0c6-b9ad-4226-bf46-4e6ae46ada25"), new Guid("598ea3ae-262f-485f-8017-be3e45b36741") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("fe8f919f-2c46-43e7-8ecd-ff72187d96a2") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("eca11d90-9930-4ec2-a8ba-83a712c7bb0c") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("83bede36-2944-44ed-bd6c-4236863326ac") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("7a79aad3-8974-4c55-aa3a-99d2b983a236") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("13968f94-4723-453c-b485-1e81382c62f7") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("7ede79e8-3720-4bb3-93a5-66c6e71d2a46") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("4d0ff55c-37e4-4120-8f4c-f2b350c43f7a") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("befdbeb9-b943-4929-9efe-2bda694672d3") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("db56dac2-5935-4925-b105-4ffa507f7a8b"), new Guid("3b67ff3f-9419-4344-8346-194ccc597207") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("f09ce904-3eb8-489e-8e6a-86d4a953e07d"), new Guid("bd488e50-04d4-4845-8960-eddc6b99ce74") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("a9270634-897e-4da3-9efa-f625e00d5dc4") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("e255c2b8-f00a-4b41-8629-df0321029d79") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("b8776a37-49e1-4e26-9cf8-9bc6857d747e") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("dc2ab682-a0cd-4379-976a-a7dd35e21aad") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("01a6c4d6-8c7b-4cfe-b1fa-022641a436bb") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("7a6b1f68-8a9e-47d6-98ff-5fd73a04163f") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("0fccfbd3-26db-4dfc-a7da-38afc820c0ee") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("6baf94eb-2a25-4635-91d1-3e507a14c381"), new Guid("26c67e24-a662-4784-8dac-5d3019ad96a3") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("b8c0e30e-9af4-474e-aaaa-a41728e14eb7"), new Guid("072b38c3-b7df-48d3-a2f0-e7894d420455") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9d6f900-122e-4e31-ba33-c4787677b457"), new Guid("6181ea92-177b-4f49-81f7-c6c9dea25755") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("912cb8ba-7666-46e2-a948-1ca6e7e6802e") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("94b077f5-6020-4c3b-9ce6-38057b45d775") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("18962658-0157-4b19-8687-059ae542a05d"), new Guid("7c550b69-5ec1-4f26-8179-89e35f04b413") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c8fba0cf-cf75-498e-92b3-a361f0e45990") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("96cb3c26-3c42-4d27-86f6-7d573133dc0f") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c4cb610a-be3e-4e43-9cb1-aa44497f7012") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("729c372c-872a-4aa5-a223-f50dbfb7cadd"), new Guid("c1d795f4-c36f-4dc9-9be9-c1fcbd3776e2") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("3903f7e0-800c-472d-9056-9280dc7fee85") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("af85023c-b3f6-4251-b21b-5185b1322c54") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("3cd9bfaa-0804-4e63-a5c5-88eb48904aba") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("3f05a015-0d24-4e8c-b72f-bed3e146f5e1") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("8a6c8b20-d03f-49ad-96ec-94a10b4966a5"), new Guid("2a19e86d-691a-45cb-97d0-aa462e82b128") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("a7477f64-252e-4792-b439-730f3fa8a109") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("65c1b920-fe0a-4f7c-a473-e2be1b9088d9") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("dcd021c2-6ae4-40ed-9830-9453ae935103") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("6d846116-b8df-434a-addb-dd5c7f83721c") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("d72050d3-7ff6-4f5d-94a2-4ff15a9c63f7") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("32cd9d88-cf63-4d8f-bc02-abef629ed94b") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("fab8cd31-d860-4134-9298-fc736892fb6f"), new Guid("f88a11c4-22fe-41b5-99aa-21824609d0e5") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2a688a7f-5845-4aed-8908-ac1cdb30889e"), new Guid("2d75fd69-be11-43ce-a88d-f618cb318248") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e9cd9ca7-63b7-40bb-8abf-261db166a3c6"), new Guid("a37ecd7f-c235-4d3e-b350-c991c0e78590") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("55a29b85-4be3-4598-95b9-9719dc5c2847") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("9b805cde-c0a4-4389-ab41-d1710bdf82ac") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("55c9d00b-d7f9-433d-a12d-9a05525e2838"), new Guid("c463fa8f-1ccb-4004-a6e1-c61e712a840f") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("bc37e0ef-a2a5-4b2a-8d43-41a4212b4660"), new Guid("50bef62f-8a71-4995-9b81-6230f9b9a0a5") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("0bb1dccd-2ed9-495e-b5b6-c38fe8a60038") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("dffcb380-a0df-4ba3-a2b7-d426699eb51d") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("5dbbffe2-c9cf-4401-818f-74b48dad39ac") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("c92356bf-1162-43dc-8ed2-7edf6b2135ea"), new Guid("9ca95f44-55a9-47d0-b54d-acc31c2d8195") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("4d983b17-4d34-4206-9527-ef2d1d5212b7") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("2026cca2-d896-4d27-8cd0-af3c65761933"), new Guid("07c33006-2f49-4dfa-ac67-af5dc7477fce") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("9c795bed-c9ee-4af7-881d-8310fa5e2ec4") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("23170dc3-ea7d-4bd3-9cb8-9fce3ac90410") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("405dbfc2-6728-42c8-98dc-ad896f65d03c"), new Guid("6cc1c906-8730-46f6-9c65-619070db0d00") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("a1838bf7-3ab3-4190-ac6d-1c610d59cf20") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("032b5097-ed6c-48df-8cd5-b8a502474f02") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("bf712af0-a843-4a04-aa68-6bbd873ddbab") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("8b1c54c8-f0a1-48ba-8337-04a1ddc7ac6c") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("41d94627-6e49-4f97-b577-9103db3e5760"), new Guid("e007b218-cd17-4881-a638-1334d446d1d9") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("530611b4-cb3c-4a3b-9f44-3260951b6944"), new Guid("3721cb3f-bd2f-4c05-98d6-b782a448b994") },
                    { new Guid("e2a7fa8b-b40d-4d05-98c6-9087176640bc"), new Guid("e1ebe261-b19e-459d-8a7c-164523e26f0f"), new Guid("cc45a9c3-f522-4d3b-8e0c-b1c6a4f17d77") }
                });
        }
    }
}
