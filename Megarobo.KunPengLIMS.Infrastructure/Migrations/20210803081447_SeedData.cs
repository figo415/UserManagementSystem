using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
