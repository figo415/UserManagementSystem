using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Infrastructure
{
    public static class ModelBuilderExtenstion
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                CreatedAt=DateTime.Now,
                IsDeleted=false,
                UserName= "admin@admin.com",
                EMail= "234298234@qq.com",
                MobileNumber= "13523429876",
                IsActive=true,
                WorkTime= "8:00-9:00"
            };
            modelBuilder.Entity<User>().HasData(user);

            var department = new Department()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted=false,
                Name= "深圳镁伽",
                Manager= "张三",
                ContactNumber= "13245679856",
                OrdinalNumber=1,
                IsActive=true,
                ParentId=Guid.Empty
            };
            modelBuilder.Entity<Department>().HasData(department);

            var role = new Role()
            {
                Id=Guid.NewGuid(),
                CreatedAt=DateTime.Now,
                IsDeleted=false,
                Name= "超级管理员",
                IsActive=true
            };
            modelBuilder.Entity<Role>().HasData(role);

            var userdepartmentrole = new UserDepartmentRole()
            {
                UserId = user.Id,
                DepartmentId = department.Id,
                RoleId = role.Id
            };
            modelBuilder.Entity<UserDepartmentRole>().HasData(userdepartmentrole);

            var systemMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system",
                Type = 0,
                ParentId = Guid.Empty,
                Code = "系统管理",
                Url = "/system",
                OrdinalNumber = 1,
                IsActive = true,
                Component = "Layout",
                Hidden = false,
                Icon = "el-icon-s-tools",
                Path = "/system",
                Redirect = "/system/user",
                Title = "系统管理"
            };
            var userMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_user",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "用户管理",
                Url = "user",
                OrdinalNumber = 2,
                IsActive = true,
                Component = "system/user/index",
                Hidden = false,
                Icon = "el-icon-user",
                Path = "user",
                Title = "用户管理"
            };
            var userButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询用户", Code = "QueryUser", MenuId = userMenu.Id };
            var userButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增用户", Code = "AddUser", MenuId = userMenu.Id };
            var userButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改用户", Code = "UpdateUser", MenuId = userMenu.Id };
            var userButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除用户", Code = "DeleteUser", MenuId = userMenu.Id };
            var userButton5 = new Button() { Id = Guid.NewGuid(), Name = "重置用户", Code = "ResetUser", MenuId = userMenu.Id };
            var skillMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_skill",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "技能管理",
                Url = "skill",
                OrdinalNumber = 3,
                IsActive = true,
                Component = "system/skill/index",
                Hidden = false,
                Icon = "skill",
                Path = "skill",
                Title = "技能管理"
            };
            var skillButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询技能", Code = "QuerySkill", MenuId = skillMenu.Id };
            var skillButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增技能", Code = "AddSkill", MenuId = skillMenu.Id };
            var skillButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改技能", Code = "UpdateSkill", MenuId = skillMenu.Id };
            var skillButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除技能", Code = "DeleteSkill", MenuId = skillMenu.Id };
            var departmentMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_department",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "部门管理",
                Url = "department",
                OrdinalNumber = 4,
                IsActive = true,
                Component = "system/department/index",
                Hidden = false,
                Icon = "peoples",
                Path = "department",
                Title = "部门管理"
            };
            var departmentButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询部门", Code = "QueryDepartment", MenuId = departmentMenu.Id };
            var departmentButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增部门", Code = "AddDepartment", MenuId = departmentMenu.Id };
            var departmentButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改部门", Code = "UpdateDepartment", MenuId = departmentMenu.Id };
            var departmentButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除部门", Code = "DeleteDepartment", MenuId = departmentMenu.Id };
            var roleMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_role",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "角色管理",
                Url = "role",
                OrdinalNumber = 5,
                IsActive = true,
                Component = "system/role/index",
                Hidden = false,
                Icon = "el-icon-s-opportunity",
                Path = "role",
                Title = "角色管理"
            };
            var roleButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询角色", Code = "QueryRole", MenuId = roleMenu.Id };
            var roleButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增角色", Code = "AddRole", MenuId = roleMenu.Id };
            var roleButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改角色", Code = "UpdateRole", MenuId = roleMenu.Id };
            var roleButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除角色", Code = "DeleteRole", MenuId = roleMenu.Id };
            var menuMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_menu",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "菜单管理",
                Url = "menu",
                OrdinalNumber = 6,
                IsActive = true,
                Component = "system/menu/index",
                Hidden = false,
                Icon = "el-icon-menu",
                Path = "menu",
                Title = "菜单管理"
            };
            var menuButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询菜单", Code = "QueryMenu", MenuId = menuMenu.Id };
            var menuButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增菜单", Code = "AddMenu", MenuId = menuMenu.Id };
            var menuButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改菜单", Code = "UpdateMenu", MenuId = menuMenu.Id };
            var menuButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除菜单", Code = "DeleteMenu", MenuId = menuMenu.Id };
            var dictMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_dictionary",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "字典项管理",
                Url = "dictionary",
                OrdinalNumber = 7,
                IsActive = true,
                Component = "system/dictionary/index",
                Hidden = false,
                Icon = "el-icon-tickets",
                Path = "dictionary",
                Title = "字典项管理"
            };
            var dictButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询字典项", Code = "QueryDict", MenuId = dictMenu.Id };
            var dictButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增字典项", Code = "AddDict", MenuId = dictMenu.Id };
            var dictButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改字典项", Code = "UpdateDict", MenuId = dictMenu.Id };
            var dictButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除字典项", Code = "DeleteDict", MenuId = dictMenu.Id };
            var dictButton5 = new Button() { Id = Guid.NewGuid(), Name = "修改字典项值", Code = "UpdateDictValue", MenuId = dictMenu.Id };
            var logMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "system_log",
                Type = 1,
                ParentId = systemMenu.Id,
                Code = "日志管理",
                Url = "log",
                OrdinalNumber = 8,
                IsActive = true,
                Component = "system/logs/index",
                Hidden = false,
                Icon = "el-icon-edit-outline",
                Path = "log",
                Title = "日志管理"
            };
            var logButton = new Button() { Id = Guid.NewGuid(), Name = "查询日志", Code = "QueryLog", MenuId = logMenu.Id };
            var basicMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic",
                Type = 0,
                ParentId = Guid.Empty,
                Code = "基础数据配置",
                Url = "/basic",
                OrdinalNumber = 9,
                IsActive = true,
                Component = "Layout",
                Hidden = false,
                Icon = "el-icon-files",
                Path = "/basic",
                Redirect = "/basic/user",
                Title = "基础数据配置"
            };
            var speciesMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_species",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "物种管理",
                Url = "species",
                OrdinalNumber = 10,
                IsActive = true,
                Component = "basic/species/index",
                Hidden = false,
                Icon = "el-icon-more",
                Path = "species",
                Title = "物种管理"
            };
            var speciesButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询物种", Code = "QuerySpecies", MenuId = speciesMenu.Id };
            var speciesButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增物种", Code = "AddSpecies", MenuId = speciesMenu.Id };
            var speciesButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改物种", Code = "UpdateSpecies", MenuId = speciesMenu.Id };
            var speciesButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除物种", Code = "DeleteSpecies", MenuId = speciesMenu.Id };
            var cellMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_cells",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "细胞管理",
                Url = "cells",
                OrdinalNumber = 11,
                IsActive = true,
                Component = "basic/cells/index",
                Hidden = false,
                Icon = "cells",
                Path = "cells",
                Title = "细胞管理"
            };
            var cellButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询细胞", Code = "QueryCell", MenuId = cellMenu.Id };
            var cellButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增细胞", Code = "AddCell", MenuId = cellMenu.Id };
            var cellButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改细胞", Code = "UpdateCell", MenuId = cellMenu.Id };
            var cellButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除细胞", Code = "DeleteCell", MenuId = cellMenu.Id };
            var positionMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_place",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "位置管理",
                Url = "place",
                OrdinalNumber = 12,
                IsActive = true,
                Component = "basic/place/index",
                Hidden = false,
                Icon = "el-icon-location",
                Path = "place",
                Title = "位置管理"
            };
            var positionButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询位置", Code = "QueryPosition", MenuId = positionMenu.Id };
            var labwareMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_material",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "耗材管理",
                Url = "material",
                OrdinalNumber = 13,
                IsActive = true,
                Component = "basic/material/index",
                Hidden = false,
                Icon = "el-icon-printer",
                Path = "material",
                Title = "耗材管理"
            };
            var labwareButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询耗材", Code = "QueryLabware", MenuId = labwareMenu.Id };
            var reagentMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_reagent",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "试剂管理",
                Url = "reagent",
                OrdinalNumber = 14,
                IsActive = true,
                Component = "basic/reagent/index",
                Hidden = false,
                Icon = "chemistry",
                Path = "reagent",
                Title = "试剂管理"
            };
            var reagentButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询试剂", Code = "QueryReagent", MenuId = reagentMenu.Id };
            var deviceMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "basic_equipment",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "设备管理",
                Url = "equipment",
                OrdinalNumber = 15,
                IsActive = true,
                Component = "basic/equipment/index",
                Hidden = false,
                Icon = "el-icon-suitcase",
                Path = "equipment",
                Title = "设备管理"
            };
            var deviceButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询设备", Code = "QueryDevice", MenuId = deviceMenu.Id };
            var deviceButton2= new Button() { Id = Guid.NewGuid(), Name = "新增设备", Code = "AddDevice", MenuId = deviceMenu.Id };
            var deviceButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改设备", Code = "UpdateDevice", MenuId = deviceMenu.Id };
            var deviceButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除设备", Code = "DeleteDevice", MenuId = deviceMenu.Id };
            var sampleMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "sample_sample",
                Type = 1,
                ParentId = basicMenu.Id,
                Code = "样本管理",
                Url = "sample",
                OrdinalNumber = 16,
                IsActive = true,
                Component = "sample/sample/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "sample",
                Title = "样本管理"
            };
            var sampleButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询样本", Code = "QuerySample", MenuId = sampleMenu.Id };
            var sampleButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增样本", Code = "AddSample", MenuId = sampleMenu.Id };
            var sampleButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改样本", Code = "UpdateSample", MenuId = sampleMenu.Id };
            var sampleButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除样本", Code = "DeleteSample", MenuId = sampleMenu.Id };
            var taskMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "task",
                Type = 0,
                ParentId = Guid.Empty,
                Code = "任务管理",
                Url = "/task",
                OrdinalNumber = 17,
                IsActive = true,
                Component = "Layout",
                Hidden = false,
                Icon = "el-icon-document-copy",
                Path = "/task",
                Redirect = "/task/today",
                Title = "任务管理"
            };
            var ownerMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "task_owner",
                Type = 1,
                ParentId = taskMenu.Id,
                Code = "我的任务",
                Url = "owner",
                OrdinalNumber = 18,
                IsActive = true,
                Component = "task/myTask/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "owner",
                Title = "我的任务"
            };
            var ownerButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询我的任务", Code = "QueryMyTask", MenuId = ownerMenu.Id };
            var ownerButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增我的任务", Code = "AddMyTask", MenuId = ownerMenu.Id };
            var ownerButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改我的任务", Code = "UpdateMyTask", MenuId = ownerMenu.Id };
            var ownerButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除我的任务", Code = "DeleteMyTask", MenuId = ownerMenu.Id };
            var todayMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "task_today",
                Type = 1,
                ParentId = taskMenu.Id,
                Code = "今日任务",
                Url = "today",
                OrdinalNumber = 19,
                IsActive = true,
                Component = "task/today/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "today",
                Title = "今日任务"
            };
            var todayButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询今日任务", Code = "QueryTask", MenuId = todayMenu.Id };
            var todayButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增今日任务", Code = "AddTask", MenuId = todayMenu.Id };
            var todayButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改今日任务", Code = "UpdateTask", MenuId = todayMenu.Id };
            var todayButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除今日任务", Code = "DeleteTask", MenuId = todayMenu.Id };
            var projectManageMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "itiems",
                Type = 0,
                ParentId = Guid.Empty,
                Code = "项目管理",
                Url = "/items",
                OrdinalNumber = 20,
                IsActive = true,
                Component = "Layout",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "/items",
                Redirect = "/items",
                Title = "项目管理"
            };
            var protocolstepMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "items_protocol",
                Type = 1,
                ParentId = projectManageMenu.Id,
                Code = "Protocol Step管理",
                Url = "protocol",
                OrdinalNumber = 21,
                IsActive = true,
                Component = "items/proStep/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "protocol",
                Title = "Protocol Step管理"
            };
            var protocolstepButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询ProtocolStep", Code = "QueryProtocolStep", MenuId = protocolstepMenu.Id };
            var protocolstepButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增ProtocolStep", Code = "AddProtocolStep", MenuId = protocolstepMenu.Id };
            var protocolstepButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改ProtocolStep", Code = "UpdateProtocolStep", MenuId = protocolstepMenu.Id };
            var protocolstepButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除ProtocolStep", Code = "DeleteProtocolStep", MenuId = protocolstepMenu.Id };
            var nodeMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "items_node",
                Type = 1,
                ParentId = projectManageMenu.Id,
                Code = "节点管理",
                Url = "node",
                OrdinalNumber = 22,
                IsActive = true,
                Component = "items/node/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "node",
                Title = "节点管理"
            };
            var nodeButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询节点", Code = "QueryNode", MenuId = nodeMenu.Id };
            var nodeButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增节点", Code = "AddNode", MenuId = nodeMenu.Id };
            var nodeButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改节点", Code = "UpdateNode", MenuId = nodeMenu.Id };
            var nodeButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除节点", Code = "DeleteNode", MenuId = nodeMenu.Id };
            var projectMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "items_project",
                Type = 1,
                ParentId = projectManageMenu.Id,
                Code = "项目管理",
                Url = "project",
                OrdinalNumber = 23,
                IsActive = true,
                Component = "items/project/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "project",
                Title = "项目管理"
            };
            var projectButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询项目", Code = "QueryProject", MenuId = projectMenu.Id };
            var projectButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增项目", Code = "AddProject", MenuId = projectMenu.Id };
            var projectButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改项目", Code = "UpdateProject", MenuId = projectMenu.Id };
            var projectButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除项目", Code = "DeleteProject", MenuId = projectMenu.Id };
            var takeMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "items_take",
                Type = 1,
                ParentId = projectManageMenu.Id,
                Code = "Take管理",
                Url = "take",
                OrdinalNumber = 24,
                IsActive = true,
                Component = "items/task/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "take",
                Title = "Take管理"
            };
            var takeButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询Take", Code = "QueryTake", MenuId = takeMenu.Id };
            var takeButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增Take", Code = "AddTake", MenuId = takeMenu.Id };
            var takeButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改Take", Code = "UpdateTake", MenuId = takeMenu.Id };
            var takeButton4 = new Button() { Id = Guid.NewGuid(), Name = "删除Take", Code = "DeleteTake", MenuId = takeMenu.Id };
            var scheduleMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "items_aps",
                Type = 1,
                ParentId = projectManageMenu.Id,
                Code = "排程",
                Url = "aps",
                OrdinalNumber = 25,
                IsActive = true,
                Component = "items/aps/index",
                Hidden = false,
                Icon = "el-icon-document",
                Path = "aps",
                Title = "排程"
            };
            var scheduleButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询排程", Code = "QuerySchedule", MenuId = scheduleMenu.Id };
            var produceMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce",
                Type = 0,
                ParentId = Guid.Empty,
                Code = "生产管理",
                Url = "/produce",
                OrdinalNumber = 26,
                IsActive = true,
                Component = "Layout",
                Hidden = false,
                Icon = "el-icon-s-cooperation",
                Path = "/produce",
                Redirect = "/produce",
                Title = "生产管理"
            };
            var orderMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_order",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "订单",
                Url = "order",
                OrdinalNumber = 27,
                IsActive = true,
                Component = "produce/order/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "order",
                Title = "订单"
            };
            var orderButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询订单", Code = "QueryOrder", MenuId = orderMenu.Id };
            var orderButton2 = new Button() { Id = Guid.NewGuid(), Name = "新增订单", Code = "AddOrder", MenuId = orderMenu.Id };
            var orderButton3 = new Button() { Id = Guid.NewGuid(), Name = "修改订单", Code = "UpdateOrder", MenuId = orderMenu.Id };
            var orderButton4 = new Button() { Id = Guid.NewGuid(), Name = "分子克隆", Code = "CloneMolecule", MenuId = orderMenu.Id };
            var orderButton5 = new Button() { Id = Guid.NewGuid(), Name = "质粒纯化", Code = "PurifyPlasmid", MenuId = orderMenu.Id };
            var orderButton6 = new Button() { Id = Guid.NewGuid(), Name = "进入生产", Code = "StartProduce", MenuId = orderMenu.Id };
            var orderButton7 = new Button() { Id = Guid.NewGuid(), Name = "QC&入库", Code = "Warehousing", MenuId = orderMenu.Id };
            var orderButton8 = new Button() { Id = Guid.NewGuid(), Name = "完成", Code = "FinishOrder", MenuId = orderMenu.Id };
            var orderButton9 = new Button() { Id = Guid.NewGuid(), Name = "取消订单", Code = "CancelOrder", MenuId = orderMenu.Id };
            var moleculeMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_clone",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "分子克隆",
                Url = "clone",
                OrdinalNumber = 28,
                IsActive = true,
                Component = "produce/clone/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "clone",
                Title = "分子克隆"
            };
            var moleculeButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询分子克隆", Code = "QueryCloning", MenuId = moleculeMenu.Id };
            var moleculeButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成分子克隆", Code = "FinishCloning", MenuId = moleculeMenu.Id };
            var plasmidMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_plasmid",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "质粒纯化",
                Url = "plasmid",
                OrdinalNumber = 29,
                IsActive = true,
                Component = "produce/plasmid/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "plasmid",
                Title = "质粒纯化"
            };
            var plasmidButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询质粒纯化", Code = "QueryPurifying", MenuId = plasmidMenu.Id };
            var plasmidButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成质粒纯化", Code = "FinishPurifying", MenuId = plasmidMenu.Id };
            var qpcrMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_qPCR",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "qPCR检测",
                Url = "qPCR",
                OrdinalNumber = 30,
                IsActive = true,
                Component = "produce/qPCR/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "qPCR",
                Title = "qPCR检测"
            };
            var qpcrButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询qPCR检测", Code = "QueryQpcr", MenuId = qpcrMenu.Id };
            var qpcrButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成qPCR检测", Code = "FinishQpcr", MenuId = qpcrMenu.Id };
            var sdspageMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_SDS",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "SDS-PAGE检测",
                Url = "SDS",
                OrdinalNumber = 31,
                IsActive = true,
                Component = "produce/SDS/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "SDS",
                Title = "SDS-PAGE检测"
            };
            var sdspageButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询SDS-PAGE检测", Code = "QuerySdspage", MenuId = sdspageMenu.Id };
            var sdspageButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成SDS-PAGE检测", Code = "FinishSdspage", MenuId = sdspageMenu.Id };
            var sterilityMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_asepticCheck",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "无菌检测",
                Url = "asepticCheck",
                OrdinalNumber = 32,
                IsActive = true,
                Component = "produce/asepticCheck/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "asepticCheck",
                Title = "无菌检测"
            };
            var sterilityButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询无菌检测", Code = "QuerySterility", MenuId = sterilityMenu.Id };
            var sterilityButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成无菌检测", Code = "FinishSterility", MenuId = sterilityMenu.Id };
            var stockMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_wareHouse",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "入库登记",
                Url = "wareHouse",
                OrdinalNumber = 33,
                IsActive = true,
                Component = "produce/wareHouse/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "wareHouse",
                Title = "入库登记"
            };
            var stockButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询入库记录", Code = "QueryWarehousing", MenuId = stockMenu.Id };
            var stockButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成入库记录", Code = "FinishWarehousing", MenuId = stockMenu.Id };
            var shipmentMenu = new Menu()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Name = "produce_deliverGoods",
                Type = 1,
                ParentId = produceMenu.Id,
                Code = "发货记录",
                Url = "deliverGoods",
                OrdinalNumber = 34,
                IsActive = true,
                Component = "produce/deliverGoods/index",
                Hidden = false,
                Icon = "el-icon-s-order",
                Path = "deliverGoods",
                Title = "发货记录"
            };
            var shipmentButton1 = new Button() { Id = Guid.NewGuid(), Name = "查询发货记录", Code = "QueryShipment", MenuId = shipmentMenu.Id };
            var shipmentButton2 = new Button() { Id = Guid.NewGuid(), Name = "完成发货记录", Code = "FinishShipment", MenuId = shipmentMenu.Id };
            modelBuilder.Entity<Menu>().HasData(
                systemMenu, userMenu, skillMenu, departmentMenu, roleMenu, menuMenu, dictMenu, logMenu, 
                basicMenu, speciesMenu, cellMenu, positionMenu, labwareMenu, reagentMenu, deviceMenu, sampleMenu, 
                taskMenu, ownerMenu, todayMenu, 
                projectManageMenu, protocolstepMenu, nodeMenu, projectMenu, takeMenu, scheduleMenu, 
                produceMenu, orderMenu, moleculeMenu, plasmidMenu, qpcrMenu, sdspageMenu, sterilityMenu, stockMenu, shipmentMenu);
            modelBuilder.Entity<Button>().HasData(
                userButton1, userButton2, userButton3, userButton4, userButton5,
                skillButton1, skillButton2, skillButton3, skillButton4,
                departmentButton1, departmentButton2, departmentButton3, departmentButton4,
                roleButton1, roleButton2, roleButton3, roleButton4,
                menuButton1, menuButton2, menuButton3, menuButton4,
                dictButton1, dictButton2, dictButton3, dictButton4, dictButton5,
                logButton,
                speciesButton1, speciesButton2, speciesButton3, speciesButton4,
                cellButton1, cellButton2, cellButton3, cellButton4,
                positionButton1,
                labwareButton1,
                reagentButton1,
                deviceButton1, deviceButton2, deviceButton3, deviceButton4,
                sampleButton1, sampleButton2, sampleButton3, sampleButton4,
                ownerButton1, ownerButton2, ownerButton3, ownerButton4,
                todayButton1, todayButton2, todayButton3, todayButton4,
                protocolstepButton1, protocolstepButton2, protocolstepButton3, protocolstepButton4,
                nodeButton1, nodeButton2, nodeButton3, nodeButton4,
                projectButton1, projectButton2, projectButton3, projectButton4,
                takeButton1, takeButton2, takeButton3, takeButton4,
                scheduleButton1,
                orderButton1, orderButton2, orderButton3, orderButton4, orderButton5, orderButton6, orderButton7, orderButton8, orderButton9, 
                moleculeButton1, moleculeButton2,
                plasmidButton1,plasmidButton2,
                qpcrButton1,qpcrButton2,
                sdspageButton1,sdspageButton2,
                sterilityButton1,sterilityButton2,
                stockButton1,stockButton2,
                shipmentButton1,shipmentButton2);
            var rolemenu1 = new RoleMenu() { RoleId = role.Id, MenuId = userMenu.Id, ButtonId = userButton1.Id };
            var rolemenu2 = new RoleMenu() { RoleId = role.Id, MenuId = userMenu.Id, ButtonId = userButton2.Id };
            var rolemenu3 = new RoleMenu() { RoleId = role.Id, MenuId = userMenu.Id, ButtonId = userButton3.Id };
            var rolemenu4 = new RoleMenu() { RoleId = role.Id, MenuId = userMenu.Id, ButtonId = userButton4.Id };
            var rolemenu5 = new RoleMenu() { RoleId = role.Id, MenuId = userMenu.Id, ButtonId = userButton5.Id };
            var rolemenu6 = new RoleMenu() { RoleId = role.Id, MenuId = skillMenu.Id, ButtonId = skillButton1.Id };
            var rolemenu7 = new RoleMenu() { RoleId = role.Id, MenuId = skillMenu.Id, ButtonId = skillButton2.Id };
            var rolemenu8 = new RoleMenu() { RoleId = role.Id, MenuId = skillMenu.Id, ButtonId = skillButton3.Id };
            var rolemenu9 = new RoleMenu() { RoleId = role.Id, MenuId = skillMenu.Id, ButtonId = skillButton4.Id };
            var rolemenu10 = new RoleMenu() { RoleId = role.Id, MenuId = departmentMenu.Id, ButtonId = departmentButton1.Id };
            var rolemenu11 = new RoleMenu() { RoleId = role.Id, MenuId = departmentMenu.Id, ButtonId = departmentButton2.Id };
            var rolemenu12 = new RoleMenu() { RoleId = role.Id, MenuId = departmentMenu.Id, ButtonId = departmentButton3.Id };
            var rolemenu13 = new RoleMenu() { RoleId = role.Id, MenuId = departmentMenu.Id, ButtonId = departmentButton4.Id };
            var rolemenu14 = new RoleMenu() { RoleId = role.Id, MenuId = roleMenu.Id, ButtonId = roleButton1.Id };
            var rolemenu15 = new RoleMenu() { RoleId = role.Id, MenuId = roleMenu.Id, ButtonId = roleButton2.Id };
            var rolemenu16 = new RoleMenu() { RoleId = role.Id, MenuId = roleMenu.Id, ButtonId = roleButton3.Id };
            var rolemenu17 = new RoleMenu() { RoleId = role.Id, MenuId = roleMenu.Id, ButtonId = roleButton4.Id };
            var rolemenu18 = new RoleMenu() { RoleId = role.Id, MenuId = menuMenu.Id, ButtonId = menuButton1.Id };
            var rolemenu19 = new RoleMenu() { RoleId = role.Id, MenuId = menuMenu.Id, ButtonId = menuButton2.Id };
            var rolemenu20 = new RoleMenu() { RoleId = role.Id, MenuId = menuMenu.Id, ButtonId = menuButton3.Id };
            var rolemenu21 = new RoleMenu() { RoleId = role.Id, MenuId = menuMenu.Id, ButtonId = menuButton4.Id };
            var rolemenu22 = new RoleMenu() { RoleId = role.Id, MenuId = dictMenu.Id, ButtonId = dictButton1.Id };
            var rolemenu23 = new RoleMenu() { RoleId = role.Id, MenuId = dictMenu.Id, ButtonId = dictButton2.Id };
            var rolemenu24 = new RoleMenu() { RoleId = role.Id, MenuId = dictMenu.Id, ButtonId = dictButton3.Id };
            var rolemenu25 = new RoleMenu() { RoleId = role.Id, MenuId = dictMenu.Id, ButtonId = dictButton4.Id };
            var rolemenu26 = new RoleMenu() { RoleId = role.Id, MenuId = dictMenu.Id, ButtonId = dictButton5.Id };
            var rolemenu27 = new RoleMenu() { RoleId = role.Id, MenuId = logMenu.Id, ButtonId = logButton.Id };
            var rolemenu28 = new RoleMenu() { RoleId = role.Id, MenuId = speciesMenu.Id, ButtonId = speciesButton1.Id };
            var rolemenu29 = new RoleMenu() { RoleId = role.Id, MenuId = speciesMenu.Id, ButtonId = speciesButton2.Id };
            var rolemenu30 = new RoleMenu() { RoleId = role.Id, MenuId = speciesMenu.Id, ButtonId = speciesButton3.Id };
            var rolemenu31 = new RoleMenu() { RoleId = role.Id, MenuId = speciesMenu.Id, ButtonId = speciesButton4.Id };
            var rolemenu32 = new RoleMenu() { RoleId = role.Id, MenuId = cellMenu.Id, ButtonId = cellButton1.Id };
            var rolemenu33 = new RoleMenu() { RoleId = role.Id, MenuId = cellMenu.Id, ButtonId = cellButton2.Id };
            var rolemenu34 = new RoleMenu() { RoleId = role.Id, MenuId = cellMenu.Id, ButtonId = cellButton3.Id };
            var rolemenu35 = new RoleMenu() { RoleId = role.Id, MenuId = cellMenu.Id, ButtonId = cellButton4.Id };
            var rolemenu36 = new RoleMenu() { RoleId = role.Id, MenuId = positionMenu.Id, ButtonId = positionButton1.Id };
            var rolemenu37 = new RoleMenu() { RoleId = role.Id, MenuId = labwareMenu.Id, ButtonId = labwareButton1.Id };
            var rolemenu38 = new RoleMenu() { RoleId = role.Id, MenuId = reagentMenu.Id, ButtonId = reagentButton1.Id };
            var rolemenu39 = new RoleMenu() { RoleId = role.Id, MenuId = deviceMenu.Id, ButtonId = deviceButton1.Id };
            var rolemenu40 = new RoleMenu() { RoleId = role.Id, MenuId = deviceMenu.Id, ButtonId = deviceButton2.Id };
            var rolemenu41 = new RoleMenu() { RoleId = role.Id, MenuId = deviceMenu.Id, ButtonId = deviceButton3.Id };
            var rolemenu42 = new RoleMenu() { RoleId = role.Id, MenuId = deviceMenu.Id, ButtonId = deviceButton4.Id };
            var rolemenu43 = new RoleMenu() { RoleId = role.Id, MenuId = sampleMenu.Id, ButtonId = sampleButton1.Id };
            var rolemenu44 = new RoleMenu() { RoleId = role.Id, MenuId = sampleMenu.Id, ButtonId = sampleButton2.Id };
            var rolemenu45 = new RoleMenu() { RoleId = role.Id, MenuId = sampleMenu.Id, ButtonId = sampleButton3.Id };
            var rolemenu46 = new RoleMenu() { RoleId = role.Id, MenuId = sampleMenu.Id, ButtonId = sampleButton4.Id };
            var rolemenu47 = new RoleMenu() { RoleId = role.Id, MenuId = ownerMenu.Id, ButtonId = ownerButton1.Id };
            var rolemenu48 = new RoleMenu() { RoleId = role.Id, MenuId = ownerMenu.Id, ButtonId = ownerButton2.Id };
            var rolemenu49 = new RoleMenu() { RoleId = role.Id, MenuId = ownerMenu.Id, ButtonId = ownerButton3.Id };
            var rolemenu50 = new RoleMenu() { RoleId = role.Id, MenuId = ownerMenu.Id, ButtonId = ownerButton4.Id };
            var rolemenu51 = new RoleMenu() { RoleId = role.Id, MenuId = todayMenu.Id, ButtonId = todayButton1.Id };
            var rolemenu52 = new RoleMenu() { RoleId = role.Id, MenuId = todayMenu.Id, ButtonId = todayButton2.Id };
            var rolemenu53 = new RoleMenu() { RoleId = role.Id, MenuId = todayMenu.Id, ButtonId = todayButton3.Id };
            var rolemenu54= new RoleMenu() { RoleId = role.Id, MenuId = todayMenu.Id, ButtonId = todayButton4.Id };
            var rolemenu55 = new RoleMenu() { RoleId = role.Id, MenuId = protocolstepMenu.Id, ButtonId = protocolstepButton1.Id };
            var rolemenu56 = new RoleMenu() { RoleId = role.Id, MenuId = protocolstepMenu.Id, ButtonId = protocolstepButton2.Id };
            var rolemenu57 = new RoleMenu() { RoleId = role.Id, MenuId = protocolstepMenu.Id, ButtonId = protocolstepButton3.Id };
            var rolemenu58 = new RoleMenu() { RoleId = role.Id, MenuId = protocolstepMenu.Id, ButtonId = protocolstepButton4.Id };
            var rolemenu59 = new RoleMenu() { RoleId = role.Id, MenuId = nodeMenu.Id, ButtonId = nodeButton1.Id };
            var rolemenu60 = new RoleMenu() { RoleId = role.Id, MenuId = nodeMenu.Id, ButtonId = nodeButton2.Id };
            var rolemenu61 = new RoleMenu() { RoleId = role.Id, MenuId = nodeMenu.Id, ButtonId = nodeButton3.Id };
            var rolemenu62 = new RoleMenu() { RoleId = role.Id, MenuId = nodeMenu.Id, ButtonId = nodeButton4.Id };
            var rolemenu63 = new RoleMenu() { RoleId = role.Id, MenuId = projectMenu.Id, ButtonId = projectButton1.Id };
            var rolemenu64 = new RoleMenu() { RoleId = role.Id, MenuId = projectMenu.Id, ButtonId = projectButton2.Id };
            var rolemenu65 = new RoleMenu() { RoleId = role.Id, MenuId = projectMenu.Id, ButtonId = projectButton3.Id };
            var rolemenu66 = new RoleMenu() { RoleId = role.Id, MenuId = projectMenu.Id, ButtonId = projectButton4.Id };
            var rolemenu67 = new RoleMenu() { RoleId = role.Id, MenuId = takeMenu.Id, ButtonId = takeButton1.Id };
            var rolemenu68 = new RoleMenu() { RoleId = role.Id, MenuId = takeMenu.Id, ButtonId = takeButton2.Id };
            var rolemenu69 = new RoleMenu() { RoleId = role.Id, MenuId = takeMenu.Id, ButtonId = takeButton3.Id };
            var rolemenu70 = new RoleMenu() { RoleId = role.Id, MenuId = takeMenu.Id, ButtonId = takeButton4.Id };
            var rolemenu71 = new RoleMenu() { RoleId = role.Id, MenuId = scheduleMenu.Id, ButtonId = scheduleButton1.Id };
            var rolemenu72 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton1.Id };
            var rolemenu73 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton2.Id };
            var rolemenu74 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton3.Id };
            var rolemenu75 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton4.Id };
            var rolemenu76 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton5.Id };
            var rolemenu77 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton6.Id };
            var rolemenu78 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton7.Id };
            var rolemenu79 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton8.Id };
            var rolemenu80 = new RoleMenu() { RoleId = role.Id, MenuId = orderMenu.Id, ButtonId = orderButton9.Id };
            var rolemenu81 = new RoleMenu() { RoleId = role.Id, MenuId = moleculeMenu.Id, ButtonId = moleculeButton1.Id };
            var rolemenu82 = new RoleMenu() { RoleId = role.Id, MenuId = moleculeMenu.Id, ButtonId = moleculeButton2.Id };
            var rolemenu83 = new RoleMenu() { RoleId = role.Id, MenuId = plasmidMenu.Id, ButtonId = plasmidButton1.Id };
            var rolemenu84 = new RoleMenu() { RoleId = role.Id, MenuId = plasmidMenu.Id, ButtonId = plasmidButton2.Id };
            var rolemenu85 = new RoleMenu() { RoleId = role.Id, MenuId = qpcrMenu.Id, ButtonId = qpcrButton1.Id };
            var rolemenu86 = new RoleMenu() { RoleId = role.Id, MenuId = qpcrMenu.Id, ButtonId = qpcrButton2.Id };
            var rolemenu87 = new RoleMenu() { RoleId = role.Id, MenuId = sdspageMenu.Id, ButtonId = sdspageButton1.Id };
            var rolemenu88 = new RoleMenu() { RoleId = role.Id, MenuId = sdspageMenu.Id, ButtonId = sdspageButton2.Id };
            var rolemenu89 = new RoleMenu() { RoleId = role.Id, MenuId = sterilityMenu.Id, ButtonId = sterilityButton1.Id };
            var rolemenu90 = new RoleMenu() { RoleId = role.Id, MenuId = sterilityMenu.Id, ButtonId = sterilityButton2.Id };
            var rolemenu91 = new RoleMenu() { RoleId = role.Id, MenuId = stockMenu.Id, ButtonId = stockButton1.Id };
            var rolemenu92 = new RoleMenu() { RoleId = role.Id, MenuId = stockMenu.Id, ButtonId = stockButton2.Id };
            var rolemenu93 = new RoleMenu() { RoleId = role.Id, MenuId = shipmentMenu.Id, ButtonId = shipmentButton1.Id };
            var rolemenu94 = new RoleMenu() { RoleId = role.Id, MenuId = shipmentMenu.Id, ButtonId = shipmentButton2.Id };
            modelBuilder.Entity<RoleMenu>().HasData(rolemenu1, rolemenu2, rolemenu3, rolemenu4, rolemenu5, rolemenu6, rolemenu7, rolemenu8, rolemenu9,
                rolemenu10, rolemenu11, rolemenu12, rolemenu13, rolemenu14, rolemenu15, rolemenu16, rolemenu17, rolemenu18, rolemenu19, rolemenu20, rolemenu21,
                rolemenu22, rolemenu23, rolemenu24, rolemenu25, rolemenu26, rolemenu27, rolemenu28, rolemenu29, rolemenu30, rolemenu31, rolemenu32, rolemenu33,
                rolemenu34, rolemenu35, rolemenu36, rolemenu37, rolemenu38, rolemenu39, rolemenu40, rolemenu41, rolemenu42, rolemenu43, rolemenu44, rolemenu45,
                rolemenu46, rolemenu47, rolemenu48, rolemenu49, rolemenu50, rolemenu51, rolemenu52, rolemenu53, rolemenu54, rolemenu55, rolemenu56, rolemenu57,
                rolemenu58, rolemenu59, rolemenu60, rolemenu61, rolemenu62, rolemenu63, rolemenu64, rolemenu65, rolemenu66, rolemenu67, rolemenu68, rolemenu69,
                rolemenu70, rolemenu71, rolemenu72, rolemenu73, rolemenu74, rolemenu75, rolemenu76, rolemenu77, rolemenu78, rolemenu79, rolemenu80, rolemenu81, 
                rolemenu82, rolemenu83, rolemenu84, rolemenu85, rolemenu86, rolemenu87, rolemenu88, rolemenu89, rolemenu90, rolemenu91, rolemenu92, rolemenu93,
                rolemenu94);

            var dict1 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "组织类型",
                Type = "string",
                Value = "cervix,lung,ELSE"
            };
            var dict2 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "细胞系种类",
                Type = "string",
                Value = "epithelial,ELSE"
            };
            var dict3 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "培养方式",
                Type = "string",
                Value = "Adherent,Suspension,ELSE"
            };
            var dict4 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "疾病",
                Type = "string",
                Value = "Carcinoma,Adenocarcinoma,ELSE"
            };
            var dict5 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "性别",
                Type = "string",
                Value = "Female,Male,ELSE"
            };
            var dict6 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "种族",
                Type = "string",
                Value = "Black,Caucasian,Asian,ELSE"
            };
            var dict7 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "体积",
                Type = "μL,mL",
                Value = "Carcinoma,Adenocarcinoma,ELSE"
            };
            var dict8 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "浓度",
                Type = "string",
                Value = "%,mg/ml"
            };
            var dict9 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "供应商",
                Type = "string",
                Value = "ThermoFisher,全式金,诺维赞,碧云天,Gibco,Merck,invitrogen"
            };
            var dict10 = new DictItem()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                KeyName = "质量",
                Type = "string",
                Value = "ng,μg,mg,g,kg"
            };
            modelBuilder.Entity<DictItem>().HasData(dict1, dict2, dict3, dict4, dict5, dict6, dict7, dict8, dict9, dict10);
        }
    }
}
