using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class AddKeycloakForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "KeycloakId",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StockInDate",
                table: "StockIn",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "SterilityDetection",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipmentDate",
                table: "Shipment",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "SdsPageDetection",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "QpcrDetection",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ContactNumber", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Manager", "Name", "OrdinalNumber", "ParentId" },
                values: new object[] { new Guid("e25a0038-98fe-42d8-bc52-36a03002807e"), "13245679856", new DateTime(2021, 8, 12, 15, 17, 44, 801, DateTimeKind.Local).AddTicks(7395), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "张三", "深圳镁伽", 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "DictItems",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "KeyName", "LastModifiedAt", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("73485e1a-ef3e-471c-8ebb-c153b6335318"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6424), false, "质量", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ng,μg,mg,g,kg" },
                    { new Guid("36a362dd-a2dc-451d-84c9-9d29f7af653e"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6420), false, "供应商", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen" },
                    { new Guid("18dc1ea7-ba57-4f46-a66e-797878e6c42e"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6415), false, "体积", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "μL,mL", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("df801f66-506a-43cc-8691-d4a3680fb8df"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6412), false, "种族", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Black,Caucasian,Asian,ELSE" },
                    { new Guid("372b9baa-e758-4d4b-9b1b-5b07415663a3"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6417), false, "浓度", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "%,mg/ml" },
                    { new Guid("b2809c58-95f4-4c0b-ab49-3d2ae6d93414"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6402), false, "疾病", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Carcinoma,Adenocarcinoma,ELSE" },
                    { new Guid("0448af08-4102-4427-8fbb-e15765c07beb"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6400), false, "培养方式", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Adherent,Suspension,ELSE" },
                    { new Guid("ac7b1d2b-212f-4c81-9444-4ce7c6dab043"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6382), false, "细胞系种类", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "epithelial,ELSE" },
                    { new Guid("5d1ed805-ba2b-4490-bc2f-e56ff09f1644"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(5922), false, "组织类型", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "cervix,lung,ELSE" },
                    { new Guid("50d283fa-2baa-4b56-ba09-e0a20ce09578"), new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(6410), false, "性别", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string", "Female,Male,ELSE" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Component", "CreatedAt", "Hidden", "Icon", "IsActive", "IsDeleted", "LastModifiedAt", "Name", "OrdinalNumber", "ParentId", "Path", "Redirect", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { new Guid("cd105e87-9f3f-4ab1-b6a0-442cec8b21d3"), "排程", "items/aps/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3777), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_aps", 25, new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "aps", null, "排程", 1, "aps" },
                    { new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "项目管理", "Layout", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3716), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itiems", 20, new Guid("00000000-0000-0000-0000-000000000000"), "/items", "/items", "项目管理", 0, "/items" },
                    { new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), "Protocol Step管理", "items/proStep/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3719), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_protocol", 21, new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "protocol", null, "Protocol Step管理", 1, "protocol" },
                    { new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), "节点管理", "items/node/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3728), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_node", 22, new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "node", null, "节点管理", 1, "node" },
                    { new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), "项目管理", "items/project/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3737), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_project", 23, new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "project", null, "项目管理", 1, "project" },
                    { new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), "Take管理", "items/task/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3744), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "items_take", 24, new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"), "take", null, "Take管理", 1, "take" },
                    { new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "生产管理", "Layout", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3782), false, "el-icon-s-cooperation", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce", 26, new Guid("00000000-0000-0000-0000-000000000000"), "/produce", "/produce", "生产管理", 0, "/produce" },
                    { new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), "无菌检测", "produce/asepticCheck/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3822), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_asepticCheck", 32, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "asepticCheck", null, "无菌检测", 1, "asepticCheck" },
                    { new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), "分子克隆", "produce/clone/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3799), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_clone", 28, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "clone", null, "分子克隆", 1, "clone" },
                    { new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), "质粒纯化", "produce/plasmid/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3806), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_plasmid", 29, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "plasmid", null, "质粒纯化", 1, "plasmid" },
                    { new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), "qPCR检测", "produce/qPCR/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3811), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_qPCR", 30, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "qPCR", null, "qPCR检测", 1, "qPCR" },
                    { new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), "SDS-PAGE检测", "produce/SDS/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3817), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_SDS", 31, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "SDS", null, "SDS-PAGE检测", 1, "SDS" },
                    { new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), "今日任务", "task/today/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3709), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_today", 19, new Guid("b667994f-4214-4667-b2c1-c10b179e4d1e"), "today", null, "今日任务", 1, "today" },
                    { new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), "入库登记", "produce/wareHouse/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3827), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_wareHouse", 33, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "wareHouse", null, "入库登记", 1, "wareHouse" },
                    { new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), "发货记录", "produce/deliverGoods/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3834), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_deliverGoods", 34, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "deliverGoods", null, "发货记录", 1, "deliverGoods" },
                    { new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "订单", "produce/order/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3785), false, "el-icon-s-order", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "produce_order", 27, new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"), "order", null, "订单", 1, "order" },
                    { new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), "我的任务", "task/myTask/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3700), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task_owner", 18, new Guid("b667994f-4214-4667-b2c1-c10b179e4d1e"), "owner", null, "我的任务", 1, "owner" },
                    { new Guid("70d6fdf7-350f-4a58-9c11-f72893603f4e"), "耗材管理", "basic/material/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3671), false, "el-icon-printer", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_material", 13, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "material", null, "耗材管理", 1, "material" },
                    { new Guid("cdab005c-7450-4996-80d9-167312ebe525"), "样本管理", "sample/sample/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3688), false, "el-icon-document", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample_sample", 16, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "sample", null, "样本管理", 1, "sample" },
                    { new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "系统管理", "Layout", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(890), false, "el-icon-s-tools", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system", 1, new Guid("00000000-0000-0000-0000-000000000000"), "/system", "/system/user", "系统管理", 0, "/system" },
                    { new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "用户管理", "system/user/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(2684), false, "el-icon-user", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_user", 2, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "user", null, "用户管理", 1, "user" },
                    { new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), "技能管理", "system/skill/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3484), false, "skill", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_skill", 3, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "skill", null, "技能管理", 1, "skill" },
                    { new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), "部门管理", "system/department/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3501), false, "peoples", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_department", 4, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "department", null, "部门管理", 1, "department" },
                    { new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), "角色管理", "system/role/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3570), false, "el-icon-s-opportunity", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_role", 5, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "role", null, "角色管理", 1, "role" },
                    { new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), "菜单管理", "system/menu/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3580), false, "el-icon-menu", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_menu", 6, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "menu", null, "菜单管理", 1, "menu" },
                    { new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "字典项管理", "system/dictionary/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3587), false, "el-icon-tickets", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_dictionary", 7, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "dictionary", null, "字典项管理", 1, "dictionary" },
                    { new Guid("8acdff78-1d39-40cf-8ad5-d6115f28c430"), "日志管理", "system/logs/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3597), false, "el-icon-edit-outline", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system_log", 8, new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"), "log", null, "日志管理", 1, "log" },
                    { new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "基础数据配置", "Layout", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3601), false, "el-icon-files", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic", 9, new Guid("00000000-0000-0000-0000-000000000000"), "/basic", "/basic/user", "基础数据配置", 0, "/basic" },
                    { new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), "物种管理", "basic/species/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3613), false, "el-icon-more", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_species", 10, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "species", null, "物种管理", 1, "species" },
                    { new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), "细胞管理", "basic/cells/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3620), false, "cells", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_cells", 11, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "cells", null, "细胞管理", 1, "cells" },
                    { new Guid("e46c867e-5b51-41d8-8dad-0c60dd415733"), "位置管理", "basic/place/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3629), false, "el-icon-location", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_place", 12, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "place", null, "位置管理", 1, "place" },
                    { new Guid("0e5514fc-9d4c-4689-82e9-14b2851368f0"), "试剂管理", "basic/reagent/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3675), false, "chemistry", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_reagent", 14, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "reagent", null, "试剂管理", 1, "reagent" },
                    { new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), "设备管理", "basic/equipment/index", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3681), false, "el-icon-suitcase", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic_equipment", 15, new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"), "equipment", null, "设备管理", 1, "equipment" },
                    { new Guid("b667994f-4214-4667-b2c1-c10b179e4d1e"), "任务管理", "Layout", new DateTime(2021, 8, 12, 15, 17, 44, 802, DateTimeKind.Local).AddTicks(3697), false, "el-icon-document-copy", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "task", 17, new Guid("00000000-0000-0000-0000-000000000000"), "/task", "/task/today", "任务管理", 0, "/task" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsDeleted", "LastModifiedAt", "Name" },
                values: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new DateTime(2021, 8, 12, 15, 17, 44, 801, DateTimeKind.Local).AddTicks(8986), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "超级管理员" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EMail", "IsActive", "IsDeleted", "KeycloakId", "LastModifiedAt", "MobileNumber", "Password", "UserName", "WorkTime" },
                values: new object[] { new Guid("e011fd05-e118-4960-ba91-8c73d88e70f6"), new DateTime(2021, 8, 12, 15, 17, 44, 799, DateTimeKind.Local).AddTicks(2795), "234298234@qq.com", true, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13523429876", null, "admin@admin.com", "8:00-9:00" });

            migrationBuilder.InsertData(
                table: "Button",
                columns: new[] { "Id", "Code", "MenuId", "Name" },
                values: new object[,]
                {
                    { new Guid("41e4f028-10bd-440e-b7e7-94a9b37f2c8b"), "QueryUser", new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "查询用户" },
                    { new Guid("d892d07f-c7a1-4798-8b16-1f7c56e99780"), "UpdateTake", new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), "修改Take" },
                    { new Guid("7b0ed01d-d2de-49ef-a1c0-5d48b04bffc9"), "AddTake", new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), "新增Take" },
                    { new Guid("f65dd8ac-709b-42b9-9199-44f54e2ebbda"), "QueryTake", new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), "查询Take" },
                    { new Guid("7a4d2bf4-4c8f-4b0d-b672-48d7c5fbec77"), "DeleteProject", new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), "删除项目" },
                    { new Guid("db0b36f8-c8ed-4f06-bd4a-f9e5b08367be"), "UpdateProject", new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), "修改项目" },
                    { new Guid("f413f546-a528-490d-ab7a-53f3222a3be7"), "AddProject", new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), "新增项目" },
                    { new Guid("c0f3b370-fdd3-4450-be71-e6d0144d1356"), "QueryProject", new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), "查询项目" },
                    { new Guid("f22fc9aa-fa46-45f2-bfe9-20497d3d73db"), "DeleteNode", new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), "删除节点" },
                    { new Guid("6bac127c-eab5-4d38-8b96-0f758ae06b74"), "UpdateNode", new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), "修改节点" },
                    { new Guid("f6a1be4a-a07f-47a8-97e8-75f0ff5da92e"), "DeleteTake", new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), "删除Take" },
                    { new Guid("d2f3961c-9585-4f8e-9f19-696eca575b58"), "AddNode", new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), "新增节点" },
                    { new Guid("917477df-f210-4620-af01-5a46342cdc3f"), "DeleteProtocolStep", new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), "删除ProtocolStep" },
                    { new Guid("fe22819d-039e-4457-8c21-6deaaccdcc38"), "UpdateProtocolStep", new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), "修改ProtocolStep" },
                    { new Guid("0c4a3643-b92c-45f0-be26-d8862ba17473"), "AddProtocolStep", new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), "新增ProtocolStep" },
                    { new Guid("f2964994-982f-4bf3-8c5d-542f15ca97cf"), "QueryProtocolStep", new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), "查询ProtocolStep" },
                    { new Guid("3b6d50d5-ac68-46ef-9ded-50c59552a842"), "DeleteTask", new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), "删除今日任务" },
                    { new Guid("fe0404c0-2ce4-45b4-83aa-73e3b3f5de90"), "UpdateTask", new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), "修改今日任务" },
                    { new Guid("b85c18bb-6d8d-4701-a9be-0760478ce2fe"), "AddTask", new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), "新增今日任务" },
                    { new Guid("e37cf14f-4b2e-466c-9590-52e59e4aa027"), "QueryTask", new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), "查询今日任务" },
                    { new Guid("1bef0ea1-f45a-4077-8aa5-63759a44d009"), "DeleteMyTask", new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), "删除我的任务" },
                    { new Guid("0753780a-fec5-43d7-b4f6-7c85d6168f32"), "QueryNode", new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), "查询节点" },
                    { new Guid("d2dbfa10-b2a7-4072-9cb5-80661cbc433a"), "UpdateMyTask", new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), "修改我的任务" },
                    { new Guid("9c0cf228-3e75-42e4-a416-134f7484fbac"), "QuerySchedule", new Guid("cd105e87-9f3f-4ab1-b6a0-442cec8b21d3"), "查询排程" },
                    { new Guid("f675d4cc-d3ed-4d03-adb5-5778507543ee"), "AddOrder", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "新增订单" },
                    { new Guid("c5b9a41e-9d97-427a-a297-a9de1f80b1e8"), "QueryShipment", new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), "查询发货记录" },
                    { new Guid("3079c9ce-194f-4d35-b804-84da9bcb4ad9"), "FinishWarehousing", new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), "完成入库记录" },
                    { new Guid("5cc960fb-419a-4b2b-b47c-f6cecff9b4f8"), "QueryWarehousing", new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), "查询入库记录" },
                    { new Guid("b8277854-2e0a-448d-bb78-b3da45ca4ae1"), "FinishSterility", new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), "完成无菌检测" },
                    { new Guid("7d74d804-1e97-45c1-961f-49bef3ad6c07"), "QuerySterility", new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), "查询无菌检测" },
                    { new Guid("0b75cf62-a277-4eac-b7f3-f37248f3436a"), "FinishSdspage", new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), "完成SDS-PAGE检测" },
                    { new Guid("de735f71-af06-4c29-b988-4bb8b1bb0852"), "QuerySdspage", new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), "查询SDS-PAGE检测" },
                    { new Guid("543b82d8-d632-4ec3-813d-f8688f51f814"), "FinishQpcr", new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), "完成qPCR检测" },
                    { new Guid("82eaeecf-4a31-42df-9a95-af93cf273cd4"), "QueryQpcr", new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), "查询qPCR检测" },
                    { new Guid("2f71b5d2-214f-4493-8918-a61181c5b6c9"), "QueryOrder", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "查询订单" },
                    { new Guid("a7ba2a79-27e1-49a3-96b1-2ea605d008ac"), "FinishPurifying", new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), "完成质粒纯化" },
                    { new Guid("aab6d3ee-b714-4193-84a0-4ba63447beef"), "FinishCloning", new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), "完成分子克隆" },
                    { new Guid("15e6c97d-2cbe-4ddc-ab57-987165aceb4d"), "QueryCloning", new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), "查询分子克隆" },
                    { new Guid("c33057cd-0bc9-46ab-9462-25d86c427fe2"), "CancelOrder", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "取消订单" },
                    { new Guid("eabdf8f2-d85e-4188-94fc-524e9daae7d4"), "FinishOrder", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "完成" },
                    { new Guid("989836ea-4dd3-43d8-bf98-b8cfd1a1a063"), "Warehousing", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "QC&入库" },
                    { new Guid("25d840ae-f019-4ec3-b315-89ee62df4a5f"), "StartProduce", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "进入生产" },
                    { new Guid("e7b0cf04-fc1f-4d9a-a2fa-992439fa91d8"), "PurifyPlasmid", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "质粒纯化" },
                    { new Guid("5e5dc83a-ddfa-4a68-8312-e4e60097dd28"), "CloneMolecule", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "分子克隆" },
                    { new Guid("d1db6575-5201-402d-a40a-66aba04257e4"), "UpdateOrder", new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), "修改订单" },
                    { new Guid("5940cf4f-7f5d-4828-a871-b3af72cbebc6"), "QueryPurifying", new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), "查询质粒纯化" },
                    { new Guid("cc27065f-9106-4a66-bf29-d114c570555f"), "FinishShipment", new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), "完成发货记录" },
                    { new Guid("587bc25f-3cea-476b-b3e4-b16a558569e1"), "AddMyTask", new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), "新增我的任务" },
                    { new Guid("b517b498-2ebb-4a91-b580-e8747298479e"), "DeleteSample", new Guid("cdab005c-7450-4996-80d9-167312ebe525"), "删除样本" },
                    { new Guid("24e95cea-3ec6-41b0-9cf4-54b80ff0f80e"), "DeleteMenu", new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), "删除菜单" },
                    { new Guid("a553b22d-7c75-484f-a261-dfba1c0c9ae1"), "UpdateMenu", new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), "修改菜单" },
                    { new Guid("4e2f2827-36c9-4483-a88d-ef7e326db58e"), "AddMenu", new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), "新增菜单" },
                    { new Guid("ff6c4aae-796a-444d-ac0e-59c0972fe5a5"), "QueryMenu", new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), "查询菜单" },
                    { new Guid("b3bbaefb-7b10-4bea-9635-990abe3f3392"), "DeleteRole", new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), "删除角色" },
                    { new Guid("f660e6e5-20f3-40a0-86bf-eeae458a0f2f"), "UpdateRole", new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), "修改角色" },
                    { new Guid("864c9672-7512-4c65-8766-870451426cad"), "AddRole", new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), "新增角色" },
                    { new Guid("996e0dbb-f743-48a8-81cd-6df1ad991de8"), "QueryRole", new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), "查询角色" },
                    { new Guid("59705a12-6dd9-41ee-bd0d-37107f7b46b0"), "DeleteDepartment", new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), "删除部门" },
                    { new Guid("ed3ce10d-d04c-4df8-8eb6-5900e9a3c7be"), "QueryDict", new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "查询字典项" },
                    { new Guid("82951be4-3193-4017-85d7-6e15444401f6"), "UpdateDepartment", new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), "修改部门" },
                    { new Guid("1abe037f-a8c9-4b22-a7b9-88f3c2b30367"), "QueryDepartment", new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), "查询部门" },
                    { new Guid("7b8414ce-feda-46f7-ac30-c64992b03075"), "DeleteSkill", new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), "删除技能" },
                    { new Guid("48348da4-7785-4cbe-8bcd-71ef17e420ee"), "UpdateSkill", new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), "修改技能" },
                    { new Guid("9577a936-7543-4010-a40c-7934484dd1ad"), "AddSkill", new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), "新增技能" },
                    { new Guid("63715e6c-02fc-4605-8fb8-d3bf39684d73"), "QuerySkill", new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), "查询技能" },
                    { new Guid("3c98cec7-9a76-401a-9498-22e00db9771e"), "ResetUser", new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "重置用户" },
                    { new Guid("6afb1c9e-12e7-4472-a295-f1a14235d5fa"), "DeleteUser", new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "删除用户" },
                    { new Guid("d5e191d8-2563-4d5f-898e-23ace8ebea9b"), "UpdateUser", new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "修改用户" },
                    { new Guid("60bdd565-15ba-4e24-ad96-5726bf083bde"), "AddUser", new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), "新增用户" },
                    { new Guid("34515b31-8d97-4c29-a813-1906cb94a247"), "AddDepartment", new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), "新增部门" },
                    { new Guid("bc3933ab-b75f-4c3b-ab0e-a4dd5c1db528"), "QueryMyTask", new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), "查询我的任务" },
                    { new Guid("88095553-c22e-40f9-b091-7f62d80ffc84"), "AddDict", new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "新增字典项" },
                    { new Guid("d5be33f7-2d79-4e6f-8f89-1dabba2324c2"), "DeleteDict", new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "删除字典项" },
                    { new Guid("528f32ff-59ac-4e11-a1c4-a1d09010a78c"), "UpdateSample", new Guid("cdab005c-7450-4996-80d9-167312ebe525"), "修改样本" },
                    { new Guid("c2c8f976-e713-4aab-8f83-221c77afd2e1"), "AddSample", new Guid("cdab005c-7450-4996-80d9-167312ebe525"), "新增样本" },
                    { new Guid("2f752d77-7a78-4d24-ada8-a74578695ead"), "QuerySample", new Guid("cdab005c-7450-4996-80d9-167312ebe525"), "查询样本" },
                    { new Guid("5a004db8-44ed-493e-bb4a-25a9cf300888"), "DeleteDevice", new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), "删除设备" },
                    { new Guid("518e404f-d899-4b00-8463-d250625a1e49"), "UpdateDevice", new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), "修改设备" },
                    { new Guid("65873886-145c-43f9-8643-095f0b196ca1"), "AddDevice", new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), "新增设备" },
                    { new Guid("537bc3e6-0bbb-47e6-b255-3f099b46995e"), "QueryDevice", new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), "查询设备" },
                    { new Guid("41a5f324-732b-4d49-b12c-e9cb7f8bef36"), "QueryReagent", new Guid("0e5514fc-9d4c-4689-82e9-14b2851368f0"), "查询试剂" },
                    { new Guid("a8f8e339-db87-426b-9cb7-d8540a7a046d"), "QueryLabware", new Guid("70d6fdf7-350f-4a58-9c11-f72893603f4e"), "查询耗材" },
                    { new Guid("8da6c8f3-e8a0-452c-b85a-fcadc066e59f"), "UpdateDict", new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "修改字典项" },
                    { new Guid("44e0bb2f-1a6b-404b-8d9e-416776ac82a4"), "QueryPosition", new Guid("e46c867e-5b51-41d8-8dad-0c60dd415733"), "查询位置" },
                    { new Guid("3597e756-35bb-4113-ad15-0d76e9c22b1d"), "UpdateCell", new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), "修改细胞" },
                    { new Guid("f67edf8e-76cb-46b9-98bd-9011f5c6a3f1"), "AddCell", new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), "新增细胞" },
                    { new Guid("e9b9e587-efda-4feb-963c-267159d3bec5"), "QueryCell", new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), "查询细胞" },
                    { new Guid("7db44cad-d955-4f76-8bbd-2fd8c17295a5"), "DeleteSpecies", new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), "删除物种" },
                    { new Guid("9ef7ad4e-5fc4-46f3-a38b-095e6cff5ea8"), "UpdateSpecies", new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), "修改物种" },
                    { new Guid("569524f8-99bc-46ad-bfee-cb06abb36f2f"), "AddSpecies", new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), "新增物种" },
                    { new Guid("bea2e30f-220e-406a-9476-0edbfe879958"), "QuerySpecies", new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), "查询物种" },
                    { new Guid("d7aaf6d2-5b87-45d6-bb4b-c6776bc155f4"), "QueryLog", new Guid("8acdff78-1d39-40cf-8ad5-d6115f28c430"), "查询日志" },
                    { new Guid("7fb87582-2a8c-4b93-a056-15b677b1e8c2"), "UpdateDictValue", new Guid("62a01185-d6e6-451e-b087-72a738673f57"), "修改字典项值" },
                    { new Guid("e883adbc-4478-49b2-9118-d6f3c5fae96b"), "DeleteCell", new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), "删除细胞" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartmentRole",
                columns: new[] { "UserId", "DepartmentId", "RoleId" },
                values: new object[] { new Guid("e011fd05-e118-4960-ba91-8c73d88e70f6"), new Guid("e25a0038-98fe-42d8-bc52-36a03002807e"), new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b") });

            migrationBuilder.InsertData(
                table: "RoleMenu",
                columns: new[] { "RoleId", "MenuId", "ButtonId" },
                values: new object[,]
                {
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("41e4f028-10bd-440e-b7e7-94a9b37f2c8b") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("7b0ed01d-d2de-49ef-a1c0-5d48b04bffc9") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("f65dd8ac-709b-42b9-9199-44f54e2ebbda") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("7a4d2bf4-4c8f-4b0d-b672-48d7c5fbec77") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("db0b36f8-c8ed-4f06-bd4a-f9e5b08367be") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("f413f546-a528-490d-ab7a-53f3222a3be7") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("c0f3b370-fdd3-4450-be71-e6d0144d1356") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("f22fc9aa-fa46-45f2-bfe9-20497d3d73db") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("6bac127c-eab5-4d38-8b96-0f758ae06b74") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("d2f3961c-9585-4f8e-9f19-696eca575b58") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("0753780a-fec5-43d7-b4f6-7c85d6168f32") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("917477df-f210-4620-af01-5a46342cdc3f") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("fe22819d-039e-4457-8c21-6deaaccdcc38") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("0c4a3643-b92c-45f0-be26-d8862ba17473") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("f2964994-982f-4bf3-8c5d-542f15ca97cf") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("3b6d50d5-ac68-46ef-9ded-50c59552a842") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("fe0404c0-2ce4-45b4-83aa-73e3b3f5de90") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("b85c18bb-6d8d-4701-a9be-0760478ce2fe") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("e37cf14f-4b2e-466c-9590-52e59e4aa027") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("1bef0ea1-f45a-4077-8aa5-63759a44d009") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("d892d07f-c7a1-4798-8b16-1f7c56e99780") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("f6a1be4a-a07f-47a8-97e8-75f0ff5da92e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cd105e87-9f3f-4ab1-b6a0-442cec8b21d3"), new Guid("9c0cf228-3e75-42e4-a416-134f7484fbac") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("2f71b5d2-214f-4493-8918-a61181c5b6c9") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), new Guid("3079c9ce-194f-4d35-b804-84da9bcb4ad9") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), new Guid("5cc960fb-419a-4b2b-b47c-f6cecff9b4f8") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), new Guid("b8277854-2e0a-448d-bb78-b3da45ca4ae1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), new Guid("7d74d804-1e97-45c1-961f-49bef3ad6c07") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), new Guid("0b75cf62-a277-4eac-b7f3-f37248f3436a") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), new Guid("de735f71-af06-4c29-b988-4bb8b1bb0852") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), new Guid("543b82d8-d632-4ec3-813d-f8688f51f814") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), new Guid("82eaeecf-4a31-42df-9a95-af93cf273cd4") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), new Guid("a7ba2a79-27e1-49a3-96b1-2ea605d008ac") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("d2dbfa10-b2a7-4072-9cb5-80661cbc433a") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), new Guid("5940cf4f-7f5d-4828-a871-b3af72cbebc6") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), new Guid("15e6c97d-2cbe-4ddc-ab57-987165aceb4d") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("c33057cd-0bc9-46ab-9462-25d86c427fe2") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("eabdf8f2-d85e-4188-94fc-524e9daae7d4") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("989836ea-4dd3-43d8-bf98-b8cfd1a1a063") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("25d840ae-f019-4ec3-b315-89ee62df4a5f") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("e7b0cf04-fc1f-4d9a-a2fa-992439fa91d8") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("5e5dc83a-ddfa-4a68-8312-e4e60097dd28") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("d1db6575-5201-402d-a40a-66aba04257e4") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("f675d4cc-d3ed-4d03-adb5-5778507543ee") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), new Guid("aab6d3ee-b714-4193-84a0-4ba63447beef") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("587bc25f-3cea-476b-b3e4-b16a558569e1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("bc3933ab-b75f-4c3b-ab0e-a4dd5c1db528") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("b517b498-2ebb-4a91-b580-e8747298479e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("24e95cea-3ec6-41b0-9cf4-54b80ff0f80e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("a553b22d-7c75-484f-a261-dfba1c0c9ae1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("4e2f2827-36c9-4483-a88d-ef7e326db58e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("ff6c4aae-796a-444d-ac0e-59c0972fe5a5") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("b3bbaefb-7b10-4bea-9635-990abe3f3392") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("f660e6e5-20f3-40a0-86bf-eeae458a0f2f") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("864c9672-7512-4c65-8766-870451426cad") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("996e0dbb-f743-48a8-81cd-6df1ad991de8") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("59705a12-6dd9-41ee-bd0d-37107f7b46b0") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("ed3ce10d-d04c-4df8-8eb6-5900e9a3c7be") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("82951be4-3193-4017-85d7-6e15444401f6") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("1abe037f-a8c9-4b22-a7b9-88f3c2b30367") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("7b8414ce-feda-46f7-ac30-c64992b03075") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("48348da4-7785-4cbe-8bcd-71ef17e420ee") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("9577a936-7543-4010-a40c-7934484dd1ad") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("63715e6c-02fc-4605-8fb8-d3bf39684d73") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("3c98cec7-9a76-401a-9498-22e00db9771e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("6afb1c9e-12e7-4472-a295-f1a14235d5fa") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("d5e191d8-2563-4d5f-898e-23ace8ebea9b") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("60bdd565-15ba-4e24-ad96-5726bf083bde") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("34515b31-8d97-4c29-a813-1906cb94a247") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), new Guid("c5b9a41e-9d97-427a-a297-a9de1f80b1e8") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("88095553-c22e-40f9-b091-7f62d80ffc84") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("d5be33f7-2d79-4e6f-8f89-1dabba2324c2") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("528f32ff-59ac-4e11-a1c4-a1d09010a78c") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("c2c8f976-e713-4aab-8f83-221c77afd2e1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("2f752d77-7a78-4d24-ada8-a74578695ead") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("5a004db8-44ed-493e-bb4a-25a9cf300888") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("518e404f-d899-4b00-8463-d250625a1e49") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("65873886-145c-43f9-8643-095f0b196ca1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("537bc3e6-0bbb-47e6-b255-3f099b46995e") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0e5514fc-9d4c-4689-82e9-14b2851368f0"), new Guid("41a5f324-732b-4d49-b12c-e9cb7f8bef36") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("70d6fdf7-350f-4a58-9c11-f72893603f4e"), new Guid("a8f8e339-db87-426b-9cb7-d8540a7a046d") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("8da6c8f3-e8a0-452c-b85a-fcadc066e59f") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e46c867e-5b51-41d8-8dad-0c60dd415733"), new Guid("44e0bb2f-1a6b-404b-8d9e-416776ac82a4") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("3597e756-35bb-4113-ad15-0d76e9c22b1d") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("f67edf8e-76cb-46b9-98bd-9011f5c6a3f1") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("e9b9e587-efda-4feb-963c-267159d3bec5") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("7db44cad-d955-4f76-8bbd-2fd8c17295a5") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("9ef7ad4e-5fc4-46f3-a38b-095e6cff5ea8") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("569524f8-99bc-46ad-bfee-cb06abb36f2f") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("bea2e30f-220e-406a-9476-0edbfe879958") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8acdff78-1d39-40cf-8ad5-d6115f28c430"), new Guid("d7aaf6d2-5b87-45d6-bb4b-c6776bc155f4") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("7fb87582-2a8c-4b93-a056-15b677b1e8c2") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("e883adbc-4478-49b2-9118-d6f3c5fae96b") },
                    { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), new Guid("cc27065f-9106-4a66-bf29-d114c570555f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("0448af08-4102-4427-8fbb-e15765c07beb"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("18dc1ea7-ba57-4f46-a66e-797878e6c42e"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("36a362dd-a2dc-451d-84c9-9d29f7af653e"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("372b9baa-e758-4d4b-9b1b-5b07415663a3"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("50d283fa-2baa-4b56-ba09-e0a20ce09578"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("5d1ed805-ba2b-4490-bc2f-e56ff09f1644"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("73485e1a-ef3e-471c-8ebb-c153b6335318"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("ac7b1d2b-212f-4c81-9444-4ce7c6dab043"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("b2809c58-95f4-4c0b-ab49-3d2ae6d93414"));

            migrationBuilder.DeleteData(
                table: "DictItems",
                keyColumn: "Id",
                keyValue: new Guid("df801f66-506a-43cc-8691-d4a3680fb8df"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("09db861b-1672-4e71-87f3-82b1ffc59d49"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b667994f-4214-4667-b2c1-c10b179e4d1e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b7c2ce2c-22be-433b-97cb-db958dc497c6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ba8818ba-a0ad-44c2-a762-4402e8756147"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("eb75637e-eaa0-46f2-b2bf-563cd95c5b8d"));

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0e5514fc-9d4c-4689-82e9-14b2851368f0"), new Guid("41a5f324-732b-4d49-b12c-e9cb7f8bef36") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("48348da4-7785-4cbe-8bcd-71ef17e420ee") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("63715e6c-02fc-4605-8fb8-d3bf39684d73") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("7b8414ce-feda-46f7-ac30-c64992b03075") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"), new Guid("9577a936-7543-4010-a40c-7934484dd1ad") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("1abe037f-a8c9-4b22-a7b9-88f3c2b30367") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("34515b31-8d97-4c29-a813-1906cb94a247") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("59705a12-6dd9-41ee-bd0d-37107f7b46b0") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"), new Guid("82951be4-3193-4017-85d7-6e15444401f6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), new Guid("543b82d8-d632-4ec3-813d-f8688f51f814") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"), new Guid("82eaeecf-4a31-42df-9a95-af93cf273cd4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), new Guid("c5b9a41e-9d97-427a-a297-a9de1f80b1e8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"), new Guid("cc27065f-9106-4a66-bf29-d114c570555f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("3597e756-35bb-4113-ad15-0d76e9c22b1d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("e883adbc-4478-49b2-9118-d6f3c5fae96b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("e9b9e587-efda-4feb-963c-267159d3bec5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"), new Guid("f67edf8e-76cb-46b9-98bd-9011f5c6a3f1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("569524f8-99bc-46ad-bfee-cb06abb36f2f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("7db44cad-d955-4f76-8bbd-2fd8c17295a5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("9ef7ad4e-5fc4-46f3-a38b-095e6cff5ea8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"), new Guid("bea2e30f-220e-406a-9476-0edbfe879958") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), new Guid("0b75cf62-a277-4eac-b7f3-f37248f3436a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"), new Guid("de735f71-af06-4c29-b988-4bb8b1bb0852") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("1bef0ea1-f45a-4077-8aa5-63759a44d009") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("587bc25f-3cea-476b-b3e4-b16a558569e1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("bc3933ab-b75f-4c3b-ab0e-a4dd5c1db528") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"), new Guid("d2dbfa10-b2a7-4072-9cb5-80661cbc433a") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("7a4d2bf4-4c8f-4b0d-b672-48d7c5fbec77") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("c0f3b370-fdd3-4450-be71-e6d0144d1356") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("db0b36f8-c8ed-4f06-bd4a-f9e5b08367be") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"), new Guid("f413f546-a528-490d-ab7a-53f3222a3be7") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("7fb87582-2a8c-4b93-a056-15b677b1e8c2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("88095553-c22e-40f9-b091-7f62d80ffc84") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("8da6c8f3-e8a0-452c-b85a-fcadc066e59f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("d5be33f7-2d79-4e6f-8f89-1dabba2324c2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("62a01185-d6e6-451e-b087-72a738673f57"), new Guid("ed3ce10d-d04c-4df8-8eb6-5900e9a3c7be") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("70d6fdf7-350f-4a58-9c11-f72893603f4e"), new Guid("a8f8e339-db87-426b-9cb7-d8540a7a046d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("24e95cea-3ec6-41b0-9cf4-54b80ff0f80e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("4e2f2827-36c9-4483-a88d-ef7e326db58e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("a553b22d-7c75-484f-a261-dfba1c0c9ae1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"), new Guid("ff6c4aae-796a-444d-ac0e-59c0972fe5a5") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("518e404f-d899-4b00-8463-d250625a1e49") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("537bc3e6-0bbb-47e6-b255-3f099b46995e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("5a004db8-44ed-493e-bb4a-25a9cf300888") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"), new Guid("65873886-145c-43f9-8643-095f0b196ca1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("7b0ed01d-d2de-49ef-a1c0-5d48b04bffc9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("d892d07f-c7a1-4798-8b16-1f7c56e99780") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("f65dd8ac-709b-42b9-9199-44f54e2ebbda") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"), new Guid("f6a1be4a-a07f-47a8-97e8-75f0ff5da92e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), new Guid("5940cf4f-7f5d-4828-a871-b3af72cbebc6") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"), new Guid("a7ba2a79-27e1-49a3-96b1-2ea605d008ac") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("8acdff78-1d39-40cf-8ad5-d6115f28c430"), new Guid("d7aaf6d2-5b87-45d6-bb4b-c6776bc155f4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("0753780a-fec5-43d7-b4f6-7c85d6168f32") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("6bac127c-eab5-4d38-8b96-0f758ae06b74") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("d2f3961c-9585-4f8e-9f19-696eca575b58") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"), new Guid("f22fc9aa-fa46-45f2-bfe9-20497d3d73db") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("25d840ae-f019-4ec3-b315-89ee62df4a5f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("2f71b5d2-214f-4493-8918-a61181c5b6c9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("5e5dc83a-ddfa-4a68-8312-e4e60097dd28") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("989836ea-4dd3-43d8-bf98-b8cfd1a1a063") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("c33057cd-0bc9-46ab-9462-25d86c427fe2") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("d1db6575-5201-402d-a40a-66aba04257e4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("e7b0cf04-fc1f-4d9a-a2fa-992439fa91d8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("eabdf8f2-d85e-4188-94fc-524e9daae7d4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"), new Guid("f675d4cc-d3ed-4d03-adb5-5778507543ee") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("3b6d50d5-ac68-46ef-9ded-50c59552a842") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("b85c18bb-6d8d-4701-a9be-0760478ce2fe") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("e37cf14f-4b2e-466c-9590-52e59e4aa027") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("af173660-2653-4444-a492-d87dcc64d8e1"), new Guid("fe0404c0-2ce4-45b4-83aa-73e3b3f5de90") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("864c9672-7512-4c65-8766-870451426cad") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("996e0dbb-f743-48a8-81cd-6df1ad991de8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("b3bbaefb-7b10-4bea-9635-990abe3f3392") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"), new Guid("f660e6e5-20f3-40a0-86bf-eeae458a0f2f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cd105e87-9f3f-4ab1-b6a0-442cec8b21d3"), new Guid("9c0cf228-3e75-42e4-a416-134f7484fbac") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("2f752d77-7a78-4d24-ada8-a74578695ead") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("528f32ff-59ac-4e11-a1c4-a1d09010a78c") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("b517b498-2ebb-4a91-b580-e8747298479e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cdab005c-7450-4996-80d9-167312ebe525"), new Guid("c2c8f976-e713-4aab-8f83-221c77afd2e1") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("0c4a3643-b92c-45f0-be26-d8862ba17473") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("917477df-f210-4620-af01-5a46342cdc3f") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("f2964994-982f-4bf3-8c5d-542f15ca97cf") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"), new Guid("fe22819d-039e-4457-8c21-6deaaccdcc38") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), new Guid("3079c9ce-194f-4d35-b804-84da9bcb4ad9") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"), new Guid("5cc960fb-419a-4b2b-b47c-f6cecff9b4f8") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("3c98cec7-9a76-401a-9498-22e00db9771e") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("41e4f028-10bd-440e-b7e7-94a9b37f2c8b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("60bdd565-15ba-4e24-ad96-5726bf083bde") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("6afb1c9e-12e7-4472-a295-f1a14235d5fa") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"), new Guid("d5e191d8-2563-4d5f-898e-23ace8ebea9b") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), new Guid("15e6c97d-2cbe-4ddc-ab57-987165aceb4d") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"), new Guid("aab6d3ee-b714-4193-84a0-4ba63447beef") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("e46c867e-5b51-41d8-8dad-0c60dd415733"), new Guid("44e0bb2f-1a6b-404b-8d9e-416776ac82a4") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), new Guid("7d74d804-1e97-45c1-961f-49bef3ad6c07") });

            migrationBuilder.DeleteData(
                table: "RoleMenu",
                keyColumns: new[] { "RoleId", "MenuId", "ButtonId" },
                keyValues: new object[] { new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"), new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"), new Guid("b8277854-2e0a-448d-bb78-b3da45ca4ae1") });

            migrationBuilder.DeleteData(
                table: "UserDepartmentRole",
                keyColumns: new[] { "UserId", "DepartmentId", "RoleId" },
                keyValues: new object[] { new Guid("e011fd05-e118-4960-ba91-8c73d88e70f6"), new Guid("e25a0038-98fe-42d8-bc52-36a03002807e"), new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b") });

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0753780a-fec5-43d7-b4f6-7c85d6168f32"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0b75cf62-a277-4eac-b7f3-f37248f3436a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("0c4a3643-b92c-45f0-be26-d8862ba17473"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("15e6c97d-2cbe-4ddc-ab57-987165aceb4d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1abe037f-a8c9-4b22-a7b9-88f3c2b30367"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("1bef0ea1-f45a-4077-8aa5-63759a44d009"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("24e95cea-3ec6-41b0-9cf4-54b80ff0f80e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("25d840ae-f019-4ec3-b315-89ee62df4a5f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2f71b5d2-214f-4493-8918-a61181c5b6c9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("2f752d77-7a78-4d24-ada8-a74578695ead"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3079c9ce-194f-4d35-b804-84da9bcb4ad9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("34515b31-8d97-4c29-a813-1906cb94a247"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3597e756-35bb-4113-ad15-0d76e9c22b1d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3b6d50d5-ac68-46ef-9ded-50c59552a842"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("3c98cec7-9a76-401a-9498-22e00db9771e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("41a5f324-732b-4d49-b12c-e9cb7f8bef36"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("41e4f028-10bd-440e-b7e7-94a9b37f2c8b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("44e0bb2f-1a6b-404b-8d9e-416776ac82a4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("48348da4-7785-4cbe-8bcd-71ef17e420ee"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("4e2f2827-36c9-4483-a88d-ef7e326db58e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("518e404f-d899-4b00-8463-d250625a1e49"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("528f32ff-59ac-4e11-a1c4-a1d09010a78c"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("537bc3e6-0bbb-47e6-b255-3f099b46995e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("543b82d8-d632-4ec3-813d-f8688f51f814"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("569524f8-99bc-46ad-bfee-cb06abb36f2f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("587bc25f-3cea-476b-b3e4-b16a558569e1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5940cf4f-7f5d-4828-a871-b3af72cbebc6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("59705a12-6dd9-41ee-bd0d-37107f7b46b0"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5a004db8-44ed-493e-bb4a-25a9cf300888"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5cc960fb-419a-4b2b-b47c-f6cecff9b4f8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("5e5dc83a-ddfa-4a68-8312-e4e60097dd28"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("60bdd565-15ba-4e24-ad96-5726bf083bde"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("63715e6c-02fc-4605-8fb8-d3bf39684d73"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("65873886-145c-43f9-8643-095f0b196ca1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6afb1c9e-12e7-4472-a295-f1a14235d5fa"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("6bac127c-eab5-4d38-8b96-0f758ae06b74"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7a4d2bf4-4c8f-4b0d-b672-48d7c5fbec77"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7b0ed01d-d2de-49ef-a1c0-5d48b04bffc9"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7b8414ce-feda-46f7-ac30-c64992b03075"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7d74d804-1e97-45c1-961f-49bef3ad6c07"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7db44cad-d955-4f76-8bbd-2fd8c17295a5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("7fb87582-2a8c-4b93-a056-15b677b1e8c2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("82951be4-3193-4017-85d7-6e15444401f6"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("82eaeecf-4a31-42df-9a95-af93cf273cd4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("864c9672-7512-4c65-8766-870451426cad"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("88095553-c22e-40f9-b091-7f62d80ffc84"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("8da6c8f3-e8a0-452c-b85a-fcadc066e59f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("917477df-f210-4620-af01-5a46342cdc3f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9577a936-7543-4010-a40c-7934484dd1ad"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("989836ea-4dd3-43d8-bf98-b8cfd1a1a063"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("996e0dbb-f743-48a8-81cd-6df1ad991de8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9c0cf228-3e75-42e4-a416-134f7484fbac"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("9ef7ad4e-5fc4-46f3-a38b-095e6cff5ea8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a553b22d-7c75-484f-a261-dfba1c0c9ae1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a7ba2a79-27e1-49a3-96b1-2ea605d008ac"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("a8f8e339-db87-426b-9cb7-d8540a7a046d"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("aab6d3ee-b714-4193-84a0-4ba63447beef"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b3bbaefb-7b10-4bea-9635-990abe3f3392"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b517b498-2ebb-4a91-b580-e8747298479e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b8277854-2e0a-448d-bb78-b3da45ca4ae1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("b85c18bb-6d8d-4701-a9be-0760478ce2fe"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bc3933ab-b75f-4c3b-ab0e-a4dd5c1db528"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("bea2e30f-220e-406a-9476-0edbfe879958"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c0f3b370-fdd3-4450-be71-e6d0144d1356"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c2c8f976-e713-4aab-8f83-221c77afd2e1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c33057cd-0bc9-46ab-9462-25d86c427fe2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("c5b9a41e-9d97-427a-a297-a9de1f80b1e8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("cc27065f-9106-4a66-bf29-d114c570555f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d1db6575-5201-402d-a40a-66aba04257e4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d2dbfa10-b2a7-4072-9cb5-80661cbc433a"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d2f3961c-9585-4f8e-9f19-696eca575b58"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d5be33f7-2d79-4e6f-8f89-1dabba2324c2"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d5e191d8-2563-4d5f-898e-23ace8ebea9b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d7aaf6d2-5b87-45d6-bb4b-c6776bc155f4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("d892d07f-c7a1-4798-8b16-1f7c56e99780"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("db0b36f8-c8ed-4f06-bd4a-f9e5b08367be"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("de735f71-af06-4c29-b988-4bb8b1bb0852"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e37cf14f-4b2e-466c-9590-52e59e4aa027"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e7b0cf04-fc1f-4d9a-a2fa-992439fa91d8"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e883adbc-4478-49b2-9118-d6f3c5fae96b"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("e9b9e587-efda-4feb-963c-267159d3bec5"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("eabdf8f2-d85e-4188-94fc-524e9daae7d4"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ed3ce10d-d04c-4df8-8eb6-5900e9a3c7be"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f22fc9aa-fa46-45f2-bfe9-20497d3d73db"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f2964994-982f-4bf3-8c5d-542f15ca97cf"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f413f546-a528-490d-ab7a-53f3222a3be7"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f65dd8ac-709b-42b9-9199-44f54e2ebbda"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f660e6e5-20f3-40a0-86bf-eeae458a0f2f"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f675d4cc-d3ed-4d03-adb5-5778507543ee"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f67edf8e-76cb-46b9-98bd-9011f5c6a3f1"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("f6a1be4a-a07f-47a8-97e8-75f0ff5da92e"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fe0404c0-2ce4-45b4-83aa-73e3b3f5de90"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("fe22819d-039e-4457-8c21-6deaaccdcc38"));

            migrationBuilder.DeleteData(
                table: "Button",
                keyColumn: "Id",
                keyValue: new Guid("ff6c4aae-796a-444d-ac0e-59c0972fe5a5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e25a0038-98fe-42d8-bc52-36a03002807e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("44db0513-b302-4f1d-8bc3-1484df89a57b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e011fd05-e118-4960-ba91-8c73d88e70f6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0e5514fc-9d4c-4689-82e9-14b2851368f0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0fbe40fb-7df0-4b50-9c51-dfb08bb3e515"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2275ae11-7e97-4acc-9768-420a3273b61f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("32e55730-da04-4727-9a86-d4e237d0acb8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("35c95ea1-6026-479b-bb66-ba7073cf05df"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("483eef78-0cdc-4556-bf7a-76661fa9656e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4b47572d-a5ec-4503-9ae5-021c3a12cb63"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5214c5e6-ce9d-4238-9379-414eac3b1344"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5772a024-23b0-4580-ae7c-86d73302b65f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5b49bee1-2c1c-4a8d-a676-658b3e4430c6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("62a01185-d6e6-451e-b087-72a738673f57"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("70d6fdf7-350f-4a58-9c11-f72893603f4e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7668542f-9d4f-487d-b2e8-02f456ebd58c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8120c246-590a-4996-93d5-35bf261e2bb0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8516a30a-ddeb-4ffa-8e1f-a0f256982ea3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("89f3fc6d-ccee-4ba4-8b52-e8eeea4a3801"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8acdff78-1d39-40cf-8ad5-d6115f28c430"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9dccfd45-9e5f-42b1-8e45-4b1f5e19fa1c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9e06a75d-e518-41b1-9a05-381f079815ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("af173660-2653-4444-a492-d87dcc64d8e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b2f58900-da73-45aa-aa0e-a16e360ec083"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cd105e87-9f3f-4ab1-b6a0-442cec8b21d3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cdab005c-7450-4996-80d9-167312ebe525"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cf054f8c-fa9a-4dcf-927e-326e6d1535ff"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("dc79b3e4-55ef-4d0d-836a-59d0b66ee89a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e04e260d-191f-41fd-af75-0054eb4dbe67"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e42ebc6a-eb5e-46d8-ac16-a68f260f608b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("e46c867e-5b51-41d8-8dad-0c60dd415733"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("eacdf1bb-f6e0-43c3-b498-97e99e295706"));

            migrationBuilder.DropColumn(
                name: "KeycloakId",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StockInDate",
                table: "StockIn",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "SterilityDetection",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipmentDate",
                table: "Shipment",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "SdsPageDetection",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DetectionDate",
                table: "QpcrDetection",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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
    }
}
