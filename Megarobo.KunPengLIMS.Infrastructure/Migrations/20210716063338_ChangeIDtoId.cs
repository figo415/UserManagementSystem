using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class ChangeIDtoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceParameters_Devices_DeviceID",
                table: "DeviceParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_LabwarePositions_Labwares_LabwareID",
                table: "LabwarePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_LabwarePositions_Positions_PositionID",
                table: "LabwarePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeDevices_Devices_DeviceID",
                table: "NodeDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeDevices_Nodes_NodeID",
                table: "NodeDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeLabwares_Labwares_LabwareID",
                table: "NodeLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeLabwares_Nodes_NodeID",
                table: "NodeLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeProtocolSteps_Nodes_NodeID",
                table: "NodeProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeProtocolSteps_ProtocolSteps_ProtocolStepID",
                table: "NodeProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeReagents_Nodes_NodeID",
                table: "NodeReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeReagents_Reagents_ReagentID",
                table: "NodeReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_Nodes_NodeTypes_NodeTypeID",
                table: "Nodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ARDID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_FRDID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Processes_ProcessID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_SRDID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Tasks_TaskID",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSteps_DeviceParameters_DeviceParameterID",
                table: "ProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSteps_Solutions_SoluationID",
                table: "ProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentDosages_Reagents_ReagentID",
                table: "ReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentPositions_Positions_PositionID",
                table: "ReagentPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentPositions_Reagents_ReagentID",
                table: "ReagentPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenu_Menus_MenuID",
                table: "RoleMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenu_Roles_RoleID",
                table: "RoleMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleDosages_Samples_SampleID",
                table: "SampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageID",
                table: "SolutionReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionReagentDosages_Solutions_SolutionID",
                table: "SolutionReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageID",
                table: "SolutionSampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionSampleDosages_Solutions_SolutionID",
                table: "SolutionSampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_Takes_Projects_ProjectID",
                table: "Takes");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeTasks_Takes_TakeID",
                table: "TakeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeTasks_Tasks_TaskID",
                table: "TakeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLabwares_Labwares_LabwareID",
                table: "TaskLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLabwares_Tasks_TaskID",
                table: "TaskLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReagents_Reagents_ReagentID",
                table: "TaskReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReagents_Tasks_TaskID",
                table: "TaskReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Devices_DeviceID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Nodes_NodeID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ProtocolSteps_ProtocolID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskSamples_Samples_SampleID",
                table: "TaskSamples");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskSamples_Tasks_TaskID",
                table: "TaskSamples");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_Tasks_TaskID",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_Users_UserID",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Departments_DepartmentID",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Roles_RoleID",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Users_UserID",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillID",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Users_UserID",
                table: "UserSkills");

            migrationBuilder.DropTable(
                name: "NodeTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProtocolSteps_SoluationID",
                table: "ProtocolSteps");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ARDID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_FRDID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectManagerID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_SRDID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SoluationID",
                table: "ProtocolSteps");

            migrationBuilder.DropColumn(
                name: "SolutionID",
                table: "ProtocolSteps");

            migrationBuilder.DropColumn(
                name: "ARDID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "FRDID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectManagerID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SRDID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DeviceSearchString",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "LabwareSearchString",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "ReagentSearchString",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "ResultSample",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "Samples",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "InteractiveTimes_End",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "InteractiveTimes_Start",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "InteractiveTimes_Unit",
                table: "Nodes");

            migrationBuilder.RenameColumn(
                name: "SkillID",
                table: "UserSkills",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserSkills",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_SkillID",
                table: "UserSkills",
                newName: "IX_UserSkills_SkillId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "UserDepartmentRole",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "UserDepartmentRole",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserDepartmentRole",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserDepartmentRole_RoleID",
                table: "UserDepartmentRole",
                newName: "IX_UserDepartmentRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserDepartmentRole_DepartmentID",
                table: "UserDepartmentRole",
                newName: "IX_UserDepartmentRole_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "TaskUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "TaskUser",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskUser_UserID",
                table: "TaskUser",
                newName: "IX_TaskUser_UserId");

            migrationBuilder.RenameColumn(
                name: "SampleID",
                table: "TaskSamples",
                newName: "SampleId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "TaskSamples",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskSamples_SampleID",
                table: "TaskSamples",
                newName: "IX_TaskSamples_SampleId");

            migrationBuilder.RenameColumn(
                name: "TakeID",
                table: "Tasks",
                newName: "TakeId");

            migrationBuilder.RenameColumn(
                name: "ProtocolID",
                table: "Tasks",
                newName: "ProtocolId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "Tasks",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "NodeID",
                table: "Tasks",
                newName: "NodeId");

            migrationBuilder.RenameColumn(
                name: "DeviceID",
                table: "Tasks",
                newName: "DeviceId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ProtocolID",
                table: "Tasks",
                newName: "IX_Tasks_ProtocolId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_NodeID",
                table: "Tasks",
                newName: "IX_Tasks_NodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_DeviceID",
                table: "Tasks",
                newName: "IX_Tasks_DeviceId");

            migrationBuilder.RenameColumn(
                name: "ReagentID",
                table: "TaskReagents",
                newName: "ReagentId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "TaskReagents",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskReagents_ReagentID",
                table: "TaskReagents",
                newName: "IX_TaskReagents_ReagentId");

            migrationBuilder.RenameColumn(
                name: "LabwareID",
                table: "TaskLabwares",
                newName: "LabwareId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "TaskLabwares",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskLabwares_LabwareID",
                table: "TaskLabwares",
                newName: "IX_TaskLabwares_LabwareId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "TakeTasks",
                newName: "TaskId");

            migrationBuilder.RenameColumn(
                name: "TakeID",
                table: "TakeTasks",
                newName: "TakeId");

            migrationBuilder.RenameIndex(
                name: "IX_TakeTasks_TaskID",
                table: "TakeTasks",
                newName: "IX_TakeTasks_TaskId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Takes",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "CurrentTaskID",
                table: "Takes",
                newName: "CurrentTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Takes_ProjectID",
                table: "Takes",
                newName: "IX_Takes_ProjectId");

            migrationBuilder.RenameColumn(
                name: "SampleDosageID",
                table: "SolutionSampleDosages",
                newName: "SampleDosageId");

            migrationBuilder.RenameColumn(
                name: "SolutionID",
                table: "SolutionSampleDosages",
                newName: "SolutionId");

            migrationBuilder.RenameIndex(
                name: "IX_SolutionSampleDosages_SampleDosageID",
                table: "SolutionSampleDosages",
                newName: "IX_SolutionSampleDosages_SampleDosageId");

            migrationBuilder.RenameColumn(
                name: "ReagentDosageID",
                table: "SolutionReagentDosages",
                newName: "ReagentDosageId");

            migrationBuilder.RenameColumn(
                name: "SolutionID",
                table: "SolutionReagentDosages",
                newName: "SolutionId");

            migrationBuilder.RenameIndex(
                name: "IX_SolutionReagentDosages_ReagentDosageID",
                table: "SolutionReagentDosages",
                newName: "IX_SolutionReagentDosages_ReagentDosageId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "Skills",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "SampleID",
                table: "SampleDosages",
                newName: "SampleId");

            migrationBuilder.RenameIndex(
                name: "IX_SampleDosages_SampleID",
                table: "SampleDosages",
                newName: "IX_SampleDosages_SampleId");

            migrationBuilder.RenameColumn(
                name: "MenuID",
                table: "RoleMenu",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "RoleMenu",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleMenu_MenuID",
                table: "RoleMenu",
                newName: "IX_RoleMenu_MenuId");

            migrationBuilder.RenameColumn(
                name: "PositionID",
                table: "ReagentPositions",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "ReagentID",
                table: "ReagentPositions",
                newName: "ReagentId");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentPositions_PositionID",
                table: "ReagentPositions",
                newName: "IX_ReagentPositions_PositionId");

            migrationBuilder.RenameColumn(
                name: "ReagentID",
                table: "ReagentDosages",
                newName: "ReagentId");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentDosages_ReagentID",
                table: "ReagentDosages",
                newName: "IX_ReagentDosages_ReagentId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "ProtocolSteps",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "DeviceParameterID",
                table: "ProtocolSteps",
                newName: "DeviceParameterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProtocolSteps_DeviceParameterID",
                table: "ProtocolSteps",
                newName: "IX_ProtocolSteps_DeviceParameterId");

            migrationBuilder.RenameColumn(
                name: "TaskID",
                table: "ProjectTasks",
                newName: "TaskId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "ProjectTasks",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTasks_TaskID",
                table: "ProjectTasks",
                newName: "IX_ProjectTasks_TaskId");

            migrationBuilder.RenameColumn(
                name: "ProcessID",
                table: "Projects",
                newName: "ProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProcessID",
                table: "Projects",
                newName: "IX_Projects_ProcessId");

            migrationBuilder.RenameColumn(
                name: "NodeTypeID",
                table: "Nodes",
                newName: "NodeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Nodes_NodeTypeID",
                table: "Nodes",
                newName: "IX_Nodes_NodeTypeId");

            migrationBuilder.RenameColumn(
                name: "ReagentID",
                table: "NodeReagents",
                newName: "ReagentId");

            migrationBuilder.RenameColumn(
                name: "NodeID",
                table: "NodeReagents",
                newName: "NodeId");

            migrationBuilder.RenameIndex(
                name: "IX_NodeReagents_ReagentID",
                table: "NodeReagents",
                newName: "IX_NodeReagents_ReagentId");

            migrationBuilder.RenameColumn(
                name: "ProtocolStepID",
                table: "NodeProtocolSteps",
                newName: "ProtocolStepId");

            migrationBuilder.RenameColumn(
                name: "NodeID",
                table: "NodeProtocolSteps",
                newName: "NodeId");

            migrationBuilder.RenameIndex(
                name: "IX_NodeProtocolSteps_ProtocolStepID",
                table: "NodeProtocolSteps",
                newName: "IX_NodeProtocolSteps_ProtocolStepId");

            migrationBuilder.RenameColumn(
                name: "LabwareID",
                table: "NodeLabwares",
                newName: "LabwareId");

            migrationBuilder.RenameColumn(
                name: "NodeID",
                table: "NodeLabwares",
                newName: "NodeId");

            migrationBuilder.RenameIndex(
                name: "IX_NodeLabwares_LabwareID",
                table: "NodeLabwares",
                newName: "IX_NodeLabwares_LabwareId");

            migrationBuilder.RenameColumn(
                name: "DeviceID",
                table: "NodeDevices",
                newName: "DeviceId");

            migrationBuilder.RenameColumn(
                name: "NodeID",
                table: "NodeDevices",
                newName: "NodeId");

            migrationBuilder.RenameIndex(
                name: "IX_NodeDevices_DeviceID",
                table: "NodeDevices",
                newName: "IX_NodeDevices_DeviceId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "LogItems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PositionID",
                table: "LabwarePositions",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "LabwareID",
                table: "LabwarePositions",
                newName: "LabwareId");

            migrationBuilder.RenameIndex(
                name: "IX_LabwarePositions_PositionID",
                table: "LabwarePositions",
                newName: "IX_LabwarePositions_PositionId");

            migrationBuilder.RenameColumn(
                name: "DeviceID",
                table: "DeviceParameters",
                newName: "DeviceId");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceParameters_DeviceID",
                table: "DeviceParameters",
                newName: "IX_DeviceParameters_DeviceId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProtocolStepId",
                table: "Solutions",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsCell",
                table: "SampleDosages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SampleDosages",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SolutionId",
                table: "SampleDosages",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProtocolSteps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProtocolSteps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "ProtocolSteps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedStartTime",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Processes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Processes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Processes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "CanGenerateResultFile",
                table: "Nodes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanGenerateResultSample",
                table: "Nodes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Nodes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InteractiveTime",
                table: "Nodes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Nodes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Nodes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Nodes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeWaitToRun",
                table: "Nodes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LabwareUsage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ProtocolStepId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabwareUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabwareUsage_ProtocolSteps_ProtocolStepId",
                        column: x => x.ProtocolStepId,
                        principalTable: "ProtocolSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReagentUsage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Cubage_Unit = table.Column<string>(nullable: true),
                    Cubage_Value = table.Column<float>(nullable: true),
                    Quality_Unit = table.Column<string>(nullable: true),
                    Quality_Value = table.Column<float>(nullable: true),
                    SolutionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReagentUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReagentUsage_Solutions_SolutionId",
                        column: x => x.SolutionId,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_ProtocolStepId",
                table: "Solutions",
                column: "ProtocolStepId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleDosages_SolutionId",
                table: "SampleDosages",
                column: "SolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_LabwareUsage_ProtocolStepId",
                table: "LabwareUsage",
                column: "ProtocolStepId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReagentUsage_SolutionId",
                table: "ReagentUsage",
                column: "SolutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceParameters_Devices_DeviceId",
                table: "DeviceParameters",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabwarePositions_Labwares_LabwareId",
                table: "LabwarePositions",
                column: "LabwareId",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabwarePositions_Positions_PositionId",
                table: "LabwarePositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeDevices_Devices_DeviceId",
                table: "NodeDevices",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeDevices_Nodes_NodeId",
                table: "NodeDevices",
                column: "NodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeLabwares_Labwares_LabwareId",
                table: "NodeLabwares",
                column: "LabwareId",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeLabwares_Nodes_NodeId",
                table: "NodeLabwares",
                column: "NodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeProtocolSteps_Nodes_NodeId",
                table: "NodeProtocolSteps",
                column: "NodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeProtocolSteps_ProtocolSteps_ProtocolStepId",
                table: "NodeProtocolSteps",
                column: "ProtocolStepId",
                principalTable: "ProtocolSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeReagents_Nodes_NodeId",
                table: "NodeReagents",
                column: "NodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeReagents_Reagents_ReagentId",
                table: "NodeReagents",
                column: "ReagentId",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nodes_Skills_NodeTypeId",
                table: "Nodes",
                column: "NodeTypeId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Processes_ProcessId",
                table: "Projects",
                column: "ProcessId",
                principalTable: "Processes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectId",
                table: "ProjectTasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Tasks_TaskId",
                table: "ProjectTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSteps_DeviceParameters_DeviceParameterId",
                table: "ProtocolSteps",
                column: "DeviceParameterId",
                principalTable: "DeviceParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentDosages_Reagents_ReagentId",
                table: "ReagentDosages",
                column: "ReagentId",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentPositions_Positions_PositionId",
                table: "ReagentPositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentPositions_Reagents_ReagentId",
                table: "ReagentPositions",
                column: "ReagentId",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenu_Menus_MenuId",
                table: "RoleMenu",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenu_Roles_RoleId",
                table: "RoleMenu",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleDosages_Samples_SampleId",
                table: "SampleDosages",
                column: "SampleId",
                principalTable: "Samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleDosages_Solutions_SolutionId",
                table: "SampleDosages",
                column: "SolutionId",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageId",
                table: "SolutionReagentDosages",
                column: "ReagentDosageId",
                principalTable: "ReagentDosages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionReagentDosages_Solutions_SolutionId",
                table: "SolutionReagentDosages",
                column: "SolutionId",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_ProtocolSteps_ProtocolStepId",
                table: "Solutions",
                column: "ProtocolStepId",
                principalTable: "ProtocolSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageId",
                table: "SolutionSampleDosages",
                column: "SampleDosageId",
                principalTable: "SampleDosages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionSampleDosages_Solutions_SolutionId",
                table: "SolutionSampleDosages",
                column: "SolutionId",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Takes_Projects_ProjectId",
                table: "Takes",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeTasks_Takes_TakeId",
                table: "TakeTasks",
                column: "TakeId",
                principalTable: "Takes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeTasks_Tasks_TaskId",
                table: "TakeTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLabwares_Labwares_LabwareId",
                table: "TaskLabwares",
                column: "LabwareId",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLabwares_Tasks_TaskId",
                table: "TaskLabwares",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReagents_Reagents_ReagentId",
                table: "TaskReagents",
                column: "ReagentId",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReagents_Tasks_TaskId",
                table: "TaskReagents",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Devices_DeviceId",
                table: "Tasks",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Nodes_NodeId",
                table: "Tasks",
                column: "NodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ProtocolSteps_ProtocolId",
                table: "Tasks",
                column: "ProtocolId",
                principalTable: "ProtocolSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskSamples_Samples_SampleId",
                table: "TaskSamples",
                column: "SampleId",
                principalTable: "Samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskSamples_Tasks_TaskId",
                table: "TaskSamples",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_Tasks_TaskId",
                table: "TaskUser",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_Users_UserId",
                table: "TaskUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Departments_DepartmentId",
                table: "UserDepartmentRole",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Roles_RoleId",
                table: "UserDepartmentRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Users_UserId",
                table: "UserDepartmentRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Users_UserId",
                table: "UserSkills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceParameters_Devices_DeviceId",
                table: "DeviceParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_LabwarePositions_Labwares_LabwareId",
                table: "LabwarePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_LabwarePositions_Positions_PositionId",
                table: "LabwarePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeDevices_Devices_DeviceId",
                table: "NodeDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeDevices_Nodes_NodeId",
                table: "NodeDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeLabwares_Labwares_LabwareId",
                table: "NodeLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeLabwares_Nodes_NodeId",
                table: "NodeLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeProtocolSteps_Nodes_NodeId",
                table: "NodeProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeProtocolSteps_ProtocolSteps_ProtocolStepId",
                table: "NodeProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeReagents_Nodes_NodeId",
                table: "NodeReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_NodeReagents_Reagents_ReagentId",
                table: "NodeReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_Nodes_Skills_NodeTypeId",
                table: "Nodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Processes_ProcessId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectId",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Tasks_TaskId",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolSteps_DeviceParameters_DeviceParameterId",
                table: "ProtocolSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentDosages_Reagents_ReagentId",
                table: "ReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentPositions_Positions_PositionId",
                table: "ReagentPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentPositions_Reagents_ReagentId",
                table: "ReagentPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenu_Menus_MenuId",
                table: "RoleMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMenu_Roles_RoleId",
                table: "RoleMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleDosages_Samples_SampleId",
                table: "SampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleDosages_Solutions_SolutionId",
                table: "SampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageId",
                table: "SolutionReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionReagentDosages_Solutions_SolutionId",
                table: "SolutionReagentDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_ProtocolSteps_ProtocolStepId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageId",
                table: "SolutionSampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_SolutionSampleDosages_Solutions_SolutionId",
                table: "SolutionSampleDosages");

            migrationBuilder.DropForeignKey(
                name: "FK_Takes_Projects_ProjectId",
                table: "Takes");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeTasks_Takes_TakeId",
                table: "TakeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeTasks_Tasks_TaskId",
                table: "TakeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLabwares_Labwares_LabwareId",
                table: "TaskLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLabwares_Tasks_TaskId",
                table: "TaskLabwares");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReagents_Reagents_ReagentId",
                table: "TaskReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReagents_Tasks_TaskId",
                table: "TaskReagents");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Devices_DeviceId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Nodes_NodeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ProtocolSteps_ProtocolId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskSamples_Samples_SampleId",
                table: "TaskSamples");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskSamples_Tasks_TaskId",
                table: "TaskSamples");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_Tasks_TaskId",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_Users_UserId",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Departments_DepartmentId",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Roles_RoleId",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDepartmentRole_Users_UserId",
                table: "UserDepartmentRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Users_UserId",
                table: "UserSkills");

            migrationBuilder.DropTable(
                name: "LabwareUsage");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "ReagentUsage");

            migrationBuilder.DropIndex(
                name: "IX_Solutions_ProtocolStepId",
                table: "Solutions");

            migrationBuilder.DropIndex(
                name: "IX_SampleDosages_SolutionId",
                table: "SampleDosages");

            migrationBuilder.DropColumn(
                name: "ProtocolStepId",
                table: "Solutions");

            migrationBuilder.DropColumn(
                name: "IsCell",
                table: "SampleDosages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SampleDosages");

            migrationBuilder.DropColumn(
                name: "SolutionId",
                table: "SampleDosages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProtocolSteps");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProtocolSteps");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "ProtocolSteps");

            migrationBuilder.DropColumn(
                name: "PlannedStartTime",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Processes");

            migrationBuilder.DropColumn(
                name: "CanGenerateResultFile",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "CanGenerateResultSample",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "InteractiveTime",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "TimeWaitToRun",
                table: "Nodes");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "UserSkills",
                newName: "SkillID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserSkills",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                newName: "IX_UserSkills_SkillID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserDepartmentRole",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "UserDepartmentRole",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserDepartmentRole",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserDepartmentRole_RoleId",
                table: "UserDepartmentRole",
                newName: "IX_UserDepartmentRole_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_UserDepartmentRole_DepartmentId",
                table: "UserDepartmentRole",
                newName: "IX_UserDepartmentRole_DepartmentID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TaskUser",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TaskUser",
                newName: "TaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TaskUser_UserId",
                table: "TaskUser",
                newName: "IX_TaskUser_UserID");

            migrationBuilder.RenameColumn(
                name: "SampleId",
                table: "TaskSamples",
                newName: "SampleID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TaskSamples",
                newName: "TaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TaskSamples_SampleId",
                table: "TaskSamples",
                newName: "IX_TaskSamples_SampleID");

            migrationBuilder.RenameColumn(
                name: "TakeId",
                table: "Tasks",
                newName: "TakeID");

            migrationBuilder.RenameColumn(
                name: "ProtocolId",
                table: "Tasks",
                newName: "ProtocolID");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Tasks",
                newName: "ParentID");

            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "Tasks",
                newName: "NodeID");

            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "Tasks",
                newName: "DeviceID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ProtocolId",
                table: "Tasks",
                newName: "IX_Tasks_ProtocolID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_NodeId",
                table: "Tasks",
                newName: "IX_Tasks_NodeID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_DeviceId",
                table: "Tasks",
                newName: "IX_Tasks_DeviceID");

            migrationBuilder.RenameColumn(
                name: "ReagentId",
                table: "TaskReagents",
                newName: "ReagentID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TaskReagents",
                newName: "TaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TaskReagents_ReagentId",
                table: "TaskReagents",
                newName: "IX_TaskReagents_ReagentID");

            migrationBuilder.RenameColumn(
                name: "LabwareId",
                table: "TaskLabwares",
                newName: "LabwareID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TaskLabwares",
                newName: "TaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TaskLabwares_LabwareId",
                table: "TaskLabwares",
                newName: "IX_TaskLabwares_LabwareID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "TakeTasks",
                newName: "TaskID");

            migrationBuilder.RenameColumn(
                name: "TakeId",
                table: "TakeTasks",
                newName: "TakeID");

            migrationBuilder.RenameIndex(
                name: "IX_TakeTasks_TaskId",
                table: "TakeTasks",
                newName: "IX_TakeTasks_TaskID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Takes",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "CurrentTaskId",
                table: "Takes",
                newName: "CurrentTaskID");

            migrationBuilder.RenameIndex(
                name: "IX_Takes_ProjectId",
                table: "Takes",
                newName: "IX_Takes_ProjectID");

            migrationBuilder.RenameColumn(
                name: "SampleDosageId",
                table: "SolutionSampleDosages",
                newName: "SampleDosageID");

            migrationBuilder.RenameColumn(
                name: "SolutionId",
                table: "SolutionSampleDosages",
                newName: "SolutionID");

            migrationBuilder.RenameIndex(
                name: "IX_SolutionSampleDosages_SampleDosageId",
                table: "SolutionSampleDosages",
                newName: "IX_SolutionSampleDosages_SampleDosageID");

            migrationBuilder.RenameColumn(
                name: "ReagentDosageId",
                table: "SolutionReagentDosages",
                newName: "ReagentDosageID");

            migrationBuilder.RenameColumn(
                name: "SolutionId",
                table: "SolutionReagentDosages",
                newName: "SolutionID");

            migrationBuilder.RenameIndex(
                name: "IX_SolutionReagentDosages_ReagentDosageId",
                table: "SolutionReagentDosages",
                newName: "IX_SolutionReagentDosages_ReagentDosageID");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Skills",
                newName: "ParentID");

            migrationBuilder.RenameColumn(
                name: "SampleId",
                table: "SampleDosages",
                newName: "SampleID");

            migrationBuilder.RenameIndex(
                name: "IX_SampleDosages_SampleId",
                table: "SampleDosages",
                newName: "IX_SampleDosages_SampleID");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "RoleMenu",
                newName: "MenuID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RoleMenu",
                newName: "RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_RoleMenu_MenuId",
                table: "RoleMenu",
                newName: "IX_RoleMenu_MenuID");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "ReagentPositions",
                newName: "PositionID");

            migrationBuilder.RenameColumn(
                name: "ReagentId",
                table: "ReagentPositions",
                newName: "ReagentID");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentPositions_PositionId",
                table: "ReagentPositions",
                newName: "IX_ReagentPositions_PositionID");

            migrationBuilder.RenameColumn(
                name: "ReagentId",
                table: "ReagentDosages",
                newName: "ReagentID");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentDosages_ReagentId",
                table: "ReagentDosages",
                newName: "IX_ReagentDosages_ReagentID");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "ProtocolSteps",
                newName: "ParentID");

            migrationBuilder.RenameColumn(
                name: "DeviceParameterId",
                table: "ProtocolSteps",
                newName: "DeviceParameterID");

            migrationBuilder.RenameIndex(
                name: "IX_ProtocolSteps_DeviceParameterId",
                table: "ProtocolSteps",
                newName: "IX_ProtocolSteps_DeviceParameterID");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "ProjectTasks",
                newName: "TaskID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ProjectTasks",
                newName: "ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTasks_TaskId",
                table: "ProjectTasks",
                newName: "IX_ProjectTasks_TaskID");

            migrationBuilder.RenameColumn(
                name: "ProcessId",
                table: "Projects",
                newName: "ProcessID");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProcessId",
                table: "Projects",
                newName: "IX_Projects_ProcessID");

            migrationBuilder.RenameColumn(
                name: "NodeTypeId",
                table: "Nodes",
                newName: "NodeTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Nodes_NodeTypeId",
                table: "Nodes",
                newName: "IX_Nodes_NodeTypeID");

            migrationBuilder.RenameColumn(
                name: "ReagentId",
                table: "NodeReagents",
                newName: "ReagentID");

            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "NodeReagents",
                newName: "NodeID");

            migrationBuilder.RenameIndex(
                name: "IX_NodeReagents_ReagentId",
                table: "NodeReagents",
                newName: "IX_NodeReagents_ReagentID");

            migrationBuilder.RenameColumn(
                name: "ProtocolStepId",
                table: "NodeProtocolSteps",
                newName: "ProtocolStepID");

            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "NodeProtocolSteps",
                newName: "NodeID");

            migrationBuilder.RenameIndex(
                name: "IX_NodeProtocolSteps_ProtocolStepId",
                table: "NodeProtocolSteps",
                newName: "IX_NodeProtocolSteps_ProtocolStepID");

            migrationBuilder.RenameColumn(
                name: "LabwareId",
                table: "NodeLabwares",
                newName: "LabwareID");

            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "NodeLabwares",
                newName: "NodeID");

            migrationBuilder.RenameIndex(
                name: "IX_NodeLabwares_LabwareId",
                table: "NodeLabwares",
                newName: "IX_NodeLabwares_LabwareID");

            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "NodeDevices",
                newName: "DeviceID");

            migrationBuilder.RenameColumn(
                name: "NodeId",
                table: "NodeDevices",
                newName: "NodeID");

            migrationBuilder.RenameIndex(
                name: "IX_NodeDevices_DeviceId",
                table: "NodeDevices",
                newName: "IX_NodeDevices_DeviceID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LogItems",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "LabwarePositions",
                newName: "PositionID");

            migrationBuilder.RenameColumn(
                name: "LabwareId",
                table: "LabwarePositions",
                newName: "LabwareID");

            migrationBuilder.RenameIndex(
                name: "IX_LabwarePositions_PositionId",
                table: "LabwarePositions",
                newName: "IX_LabwarePositions_PositionID");

            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "DeviceParameters",
                newName: "DeviceID");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceParameters_DeviceId",
                table: "DeviceParameters",
                newName: "IX_DeviceParameters_DeviceID");

            migrationBuilder.AddColumn<Guid>(
                name: "SoluationID",
                table: "ProtocolSteps",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SolutionID",
                table: "ProtocolSteps",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ARDID",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FRDID",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectManagerID",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SRDID",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DeviceSearchString",
                table: "Nodes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabwareSearchString",
                table: "Nodes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReagentSearchString",
                table: "Nodes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultSample",
                table: "Nodes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Samples",
                table: "Nodes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InteractiveTimes_End",
                table: "Nodes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InteractiveTimes_Start",
                table: "Nodes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InteractiveTimes_Unit",
                table: "Nodes",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NodeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: true),
                    GrandClass = table.Column<string>(type: "text", nullable: true),
                    SubClass = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSteps_SoluationID",
                table: "ProtocolSteps",
                column: "SoluationID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ARDID",
                table: "Projects",
                column: "ARDID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_FRDID",
                table: "Projects",
                column: "FRDID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManagerID",
                table: "Projects",
                column: "ProjectManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SRDID",
                table: "Projects",
                column: "SRDID");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceParameters_Devices_DeviceID",
                table: "DeviceParameters",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabwarePositions_Labwares_LabwareID",
                table: "LabwarePositions",
                column: "LabwareID",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabwarePositions_Positions_PositionID",
                table: "LabwarePositions",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeDevices_Devices_DeviceID",
                table: "NodeDevices",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeDevices_Nodes_NodeID",
                table: "NodeDevices",
                column: "NodeID",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeLabwares_Labwares_LabwareID",
                table: "NodeLabwares",
                column: "LabwareID",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeLabwares_Nodes_NodeID",
                table: "NodeLabwares",
                column: "NodeID",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeProtocolSteps_Nodes_NodeID",
                table: "NodeProtocolSteps",
                column: "NodeID",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeProtocolSteps_ProtocolSteps_ProtocolStepID",
                table: "NodeProtocolSteps",
                column: "ProtocolStepID",
                principalTable: "ProtocolSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeReagents_Nodes_NodeID",
                table: "NodeReagents",
                column: "NodeID",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NodeReagents_Reagents_ReagentID",
                table: "NodeReagents",
                column: "ReagentID",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nodes_NodeTypes_NodeTypeID",
                table: "Nodes",
                column: "NodeTypeID",
                principalTable: "NodeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ARDID",
                table: "Projects",
                column: "ARDID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_FRDID",
                table: "Projects",
                column: "FRDID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Processes_ProcessID",
                table: "Projects",
                column: "ProcessID",
                principalTable: "Processes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects",
                column: "ProjectManagerID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_SRDID",
                table: "Projects",
                column: "SRDID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Tasks_TaskID",
                table: "ProjectTasks",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSteps_DeviceParameters_DeviceParameterID",
                table: "ProtocolSteps",
                column: "DeviceParameterID",
                principalTable: "DeviceParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocolSteps_Solutions_SoluationID",
                table: "ProtocolSteps",
                column: "SoluationID",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentDosages_Reagents_ReagentID",
                table: "ReagentDosages",
                column: "ReagentID",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentPositions_Positions_PositionID",
                table: "ReagentPositions",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentPositions_Reagents_ReagentID",
                table: "ReagentPositions",
                column: "ReagentID",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenu_Menus_MenuID",
                table: "RoleMenu",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMenu_Roles_RoleID",
                table: "RoleMenu",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleDosages_Samples_SampleID",
                table: "SampleDosages",
                column: "SampleID",
                principalTable: "Samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageID",
                table: "SolutionReagentDosages",
                column: "ReagentDosageID",
                principalTable: "ReagentDosages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionReagentDosages_Solutions_SolutionID",
                table: "SolutionReagentDosages",
                column: "SolutionID",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageID",
                table: "SolutionSampleDosages",
                column: "SampleDosageID",
                principalTable: "SampleDosages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolutionSampleDosages_Solutions_SolutionID",
                table: "SolutionSampleDosages",
                column: "SolutionID",
                principalTable: "Solutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Takes_Projects_ProjectID",
                table: "Takes",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeTasks_Takes_TakeID",
                table: "TakeTasks",
                column: "TakeID",
                principalTable: "Takes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeTasks_Tasks_TaskID",
                table: "TakeTasks",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLabwares_Labwares_LabwareID",
                table: "TaskLabwares",
                column: "LabwareID",
                principalTable: "Labwares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLabwares_Tasks_TaskID",
                table: "TaskLabwares",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReagents_Reagents_ReagentID",
                table: "TaskReagents",
                column: "ReagentID",
                principalTable: "Reagents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReagents_Tasks_TaskID",
                table: "TaskReagents",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Devices_DeviceID",
                table: "Tasks",
                column: "DeviceID",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Nodes_NodeID",
                table: "Tasks",
                column: "NodeID",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ProtocolSteps_ProtocolID",
                table: "Tasks",
                column: "ProtocolID",
                principalTable: "ProtocolSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskSamples_Samples_SampleID",
                table: "TaskSamples",
                column: "SampleID",
                principalTable: "Samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskSamples_Tasks_TaskID",
                table: "TaskSamples",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_Tasks_TaskID",
                table: "TaskUser",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_Users_UserID",
                table: "TaskUser",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Departments_DepartmentID",
                table: "UserDepartmentRole",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Roles_RoleID",
                table: "UserDepartmentRole",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDepartmentRole_Users_UserID",
                table: "UserDepartmentRole",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillID",
                table: "UserSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Users_UserID",
                table: "UserSkills",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
