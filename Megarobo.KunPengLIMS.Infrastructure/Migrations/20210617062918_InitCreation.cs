using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Megarobo.KunPengLIMS.Infrastructure.Migrations
{
    public partial class InitCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Manager = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    OrdinalNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SubClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    KeyName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Labwares",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AvailableHole = table.Column<int>(nullable: false),
                    AvailableQuantity = table.Column<int>(nullable: false),
                    Barcode = table.Column<string>(nullable: true),
                    BoughtFrom_Name = table.Column<string>(nullable: true),
                    BoughtFrom_Url = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price_Unit = table.Column<string>(nullable: true),
                    Price_Value = table.Column<float>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Subclass = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ModuleName = table.Column<string>(nullable: true),
                    OperationType = table.Column<string>(nullable: true),
                    OperationName = table.Column<string>(nullable: true),
                    IsSuccess = table.Column<bool>(nullable: false),
                    ErrorMessage = table.Column<string>(nullable: true),
                    Operator = table.Column<string>(nullable: true),
                    OperationTime = table.Column<DateTime>(nullable: false),
                    RequestUrl = table.Column<string>(nullable: true),
                    RequestParameters = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    OrdinalNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NodeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    GrandClass = table.Column<string>(nullable: true),
                    SubClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reagents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleNumber = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    BoughtFrom_Name = table.Column<string>(nullable: true),
                    BoughtFrom_Url = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    Cubage_Unit = table.Column<string>(nullable: true),
                    Cubage_Value = table.Column<float>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price_Unit = table.Column<string>(nullable: true),
                    Price_Value = table.Column<float>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Quality_Unit = table.Column<string>(nullable: true),
                    Quality_Value = table.Column<float>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true),
                    Thickness_Unit = table.Column<string>(nullable: true),
                    Thickness_Value = table.Column<float>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    UnusedQuality_Unit = table.Column<string>(nullable: true),
                    UnusedQuality_Value = table.Column<float>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reagents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SkillName = table.Column<string>(nullable: true),
                    ParentID = table.Column<Guid>(nullable: false),
                    OrdinalNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Total_Unit = table.Column<string>(nullable: true),
                    Total_Value = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    WorkTime_End = table.Column<int>(nullable: true),
                    WorkTime_Start = table.Column<int>(nullable: true),
                    WorkTime_Unit = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Script_Name = table.Column<string>(nullable: true),
                    Script_Url = table.Column<string>(nullable: true),
                    DeviceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceParameters_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Hole = table.Column<int>(nullable: false),
                    Layer = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Tower = table.Column<int>(nullable: false),
                    Well = table.Column<string>(nullable: true),
                    Zone = table.Column<string>(nullable: true),
                    DeviceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeviceSearchString = table.Column<string>(nullable: true),
                    Duration_Unit = table.Column<string>(nullable: true),
                    Duration_Value = table.Column<int>(nullable: true),
                    InteractiveTimes_End = table.Column<int>(nullable: true),
                    InteractiveTimes_Start = table.Column<int>(nullable: true),
                    InteractiveTimes_Unit = table.Column<string>(nullable: true),
                    LabwareSearchString = table.Column<string>(nullable: true),
                    NodeTypeID = table.Column<Guid>(nullable: false),
                    ReagentSearchString = table.Column<string>(nullable: true),
                    ResultSample = table.Column<int>(nullable: false),
                    Samples = table.Column<int>(nullable: false),
                    ProcessId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nodes_NodeTypes_NodeTypeID",
                        column: x => x.NodeTypeID,
                        principalTable: "NodeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nodes_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReagentDosages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cubage_Unit = table.Column<string>(nullable: true),
                    Cubage_Value = table.Column<float>(nullable: true),
                    Quality_Unit = table.Column<string>(nullable: true),
                    Quality_Value = table.Column<float>(nullable: true),
                    ReagentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReagentDosages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReagentDosages_Reagents_ReagentID",
                        column: x => x.ReagentID,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(nullable: false),
                    MenuID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => new { x.RoleID, x.MenuID });
                    table.ForeignKey(
                        name: "FK_RoleMenu_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenu_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ProjectManagerID = table.Column<Guid>(nullable: false),
                    ARDID = table.Column<Guid>(nullable: false),
                    FRDID = table.Column<Guid>(nullable: false),
                    SRDID = table.Column<Guid>(nullable: false),
                    ProcessID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_ARDID",
                        column: x => x.ARDID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Users_FRDID",
                        column: x => x.FRDID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Processes_ProcessID",
                        column: x => x.ProcessID,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Users_ProjectManagerID",
                        column: x => x.ProjectManagerID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Users_SRDID",
                        column: x => x.SRDID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartmentRole",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    DepartmentID = table.Column<Guid>(nullable: false),
                    RoleID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartmentRole", x => new { x.UserID, x.DepartmentID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserDepartmentRole_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartmentRole_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartmentRole_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkill",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    SkillID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkill", x => new { x.UserID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_UserSkill_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkill_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProtocolSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DeviceParameterID = table.Column<Guid>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    SolutionID = table.Column<Guid>(nullable: false),
                    SoluationID = table.Column<Guid>(nullable: true),
                    ParentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtocolSteps_DeviceParameters_DeviceParameterID",
                        column: x => x.DeviceParameterID,
                        principalTable: "DeviceParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProtocolSteps_Solutions_SoluationID",
                        column: x => x.SoluationID,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LabwarePositions",
                columns: table => new
                {
                    LabwareID = table.Column<Guid>(nullable: false),
                    PositionID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabwarePositions", x => new { x.LabwareID, x.PositionID });
                    table.ForeignKey(
                        name: "FK_LabwarePositions_Labwares_LabwareID",
                        column: x => x.LabwareID,
                        principalTable: "Labwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabwarePositions_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReagentPositions",
                columns: table => new
                {
                    ReagentID = table.Column<Guid>(nullable: false),
                    PositionID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReagentPositions", x => new { x.ReagentID, x.PositionID });
                    table.ForeignKey(
                        name: "FK_ReagentPositions_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReagentPositions_Reagents_ReagentID",
                        column: x => x.ReagentID,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BoughtFrom_Name = table.Column<string>(nullable: true),
                    BoughtFrom_Url = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NextPhotoTime = table.Column<DateTime>(nullable: false),
                    PositionID = table.Column<Guid>(nullable: false),
                    Price_Unit = table.Column<string>(nullable: true),
                    Price_Value = table.Column<float>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Lable = table.Column<string>(nullable: true),
                    StartNodeID = table.Column<Guid>(nullable: false),
                    EndNodeID = table.Column<Guid>(nullable: false),
                    ProcessID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lines_Nodes_EndNodeID",
                        column: x => x.EndNodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lines_Processes_ProcessID",
                        column: x => x.ProcessID,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lines_Nodes_StartNodeID",
                        column: x => x.StartNodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NodeDevices",
                columns: table => new
                {
                    NodeID = table.Column<Guid>(nullable: false),
                    DeviceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeDevices", x => new { x.NodeID, x.DeviceID });
                    table.ForeignKey(
                        name: "FK_NodeDevices_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NodeDevices_Nodes_NodeID",
                        column: x => x.NodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NodeLabwares",
                columns: table => new
                {
                    NodeID = table.Column<Guid>(nullable: false),
                    LabwareID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeLabwares", x => new { x.NodeID, x.LabwareID });
                    table.ForeignKey(
                        name: "FK_NodeLabwares_Labwares_LabwareID",
                        column: x => x.LabwareID,
                        principalTable: "Labwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NodeLabwares_Nodes_NodeID",
                        column: x => x.NodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NodeReagents",
                columns: table => new
                {
                    NodeID = table.Column<Guid>(nullable: false),
                    ReagentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeReagents", x => new { x.NodeID, x.ReagentID });
                    table.ForeignKey(
                        name: "FK_NodeReagents_Nodes_NodeID",
                        column: x => x.NodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NodeReagents_Reagents_ReagentID",
                        column: x => x.ReagentID,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolutionReagentDosages",
                columns: table => new
                {
                    SolutionID = table.Column<Guid>(nullable: false),
                    ReagentDosageID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionReagentDosages", x => new { x.SolutionID, x.ReagentDosageID });
                    table.ForeignKey(
                        name: "FK_SolutionReagentDosages_ReagentDosages_ReagentDosageID",
                        column: x => x.ReagentDosageID,
                        principalTable: "ReagentDosages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolutionReagentDosages_Solutions_SolutionID",
                        column: x => x.SolutionID,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Takes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TakeCode = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CurrentTaskID = table.Column<Guid>(nullable: false),
                    ProjectID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Takes_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NodeProtocolSteps",
                columns: table => new
                {
                    NodeID = table.Column<Guid>(nullable: false),
                    ProtocolStepID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeProtocolSteps", x => new { x.NodeID, x.ProtocolStepID });
                    table.ForeignKey(
                        name: "FK_NodeProtocolSteps_Nodes_NodeID",
                        column: x => x.NodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NodeProtocolSteps_ProtocolSteps_ProtocolStepID",
                        column: x => x.ProtocolStepID,
                        principalTable: "ProtocolSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeviceID = table.Column<Guid>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    NodeID = table.Column<Guid>(nullable: false),
                    ParentID = table.Column<Guid>(nullable: false),
                    ProtocolID = table.Column<Guid>(nullable: false),
                    TakeID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Nodes_NodeID",
                        column: x => x.NodeID,
                        principalTable: "Nodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_ProtocolSteps_ProtocolID",
                        column: x => x.ProtocolID,
                        principalTable: "ProtocolSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleDosages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cubage_Unit = table.Column<string>(nullable: true),
                    Cubage_Value = table.Column<float>(nullable: true),
                    Quality_Unit = table.Column<string>(nullable: true),
                    Quality_Value = table.Column<float>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SampleID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleDosages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleDosages_Samples_SampleID",
                        column: x => x.SampleID,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    ProjectID = table.Column<Guid>(nullable: false),
                    TaskID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => new { x.ProjectID, x.TaskID });
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakeTasks",
                columns: table => new
                {
                    TakeID = table.Column<Guid>(nullable: false),
                    TaskID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeTasks", x => new { x.TakeID, x.TaskID });
                    table.ForeignKey(
                        name: "FK_TakeTasks_Takes_TakeID",
                        column: x => x.TakeID,
                        principalTable: "Takes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakeTasks_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskLabwares",
                columns: table => new
                {
                    TaskID = table.Column<Guid>(nullable: false),
                    LabwareID = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLabwares", x => new { x.TaskID, x.LabwareID });
                    table.ForeignKey(
                        name: "FK_TaskLabwares_Labwares_LabwareID",
                        column: x => x.LabwareID,
                        principalTable: "Labwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskLabwares_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskReagents",
                columns: table => new
                {
                    TaskID = table.Column<Guid>(nullable: false),
                    ReagentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskReagents", x => new { x.TaskID, x.ReagentID });
                    table.ForeignKey(
                        name: "FK_TaskReagents_Reagents_ReagentID",
                        column: x => x.ReagentID,
                        principalTable: "Reagents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskReagents_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks_ResultAttachments",
                columns: table => new
                {
                    TaskId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks_ResultAttachments", x => new { x.TaskId, x.Id });
                    table.ForeignKey(
                        name: "FK_Tasks_ResultAttachments_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskSamples",
                columns: table => new
                {
                    TaskID = table.Column<Guid>(nullable: false),
                    SampleID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskSamples", x => new { x.TaskID, x.SampleID });
                    table.ForeignKey(
                        name: "FK_TaskSamples_Samples_SampleID",
                        column: x => x.SampleID,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskSamples_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskUser",
                columns: table => new
                {
                    TaskID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUser", x => new { x.TaskID, x.UserID });
                    table.ForeignKey(
                        name: "FK_TaskUser_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskUser_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolutionSampleDosages",
                columns: table => new
                {
                    SolutionID = table.Column<Guid>(nullable: false),
                    SampleDosageID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionSampleDosages", x => new { x.SolutionID, x.SampleDosageID });
                    table.ForeignKey(
                        name: "FK_SolutionSampleDosages_SampleDosages_SampleDosageID",
                        column: x => x.SampleDosageID,
                        principalTable: "SampleDosages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolutionSampleDosages_Solutions_SolutionID",
                        column: x => x.SolutionID,
                        principalTable: "Solutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceParameters_DeviceID",
                table: "DeviceParameters",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_LabwarePositions_PositionID",
                table: "LabwarePositions",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_EndNodeID",
                table: "Lines",
                column: "EndNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_ProcessID",
                table: "Lines",
                column: "ProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_StartNodeID",
                table: "Lines",
                column: "StartNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_NodeDevices_DeviceID",
                table: "NodeDevices",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_NodeLabwares_LabwareID",
                table: "NodeLabwares",
                column: "LabwareID");

            migrationBuilder.CreateIndex(
                name: "IX_NodeProtocolSteps_ProtocolStepID",
                table: "NodeProtocolSteps",
                column: "ProtocolStepID");

            migrationBuilder.CreateIndex(
                name: "IX_NodeReagents_ReagentID",
                table: "NodeReagents",
                column: "ReagentID");

            migrationBuilder.CreateIndex(
                name: "IX_Nodes_NodeTypeID",
                table: "Nodes",
                column: "NodeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Nodes_ProcessId",
                table: "Nodes",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DeviceID",
                table: "Positions",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ARDID",
                table: "Projects",
                column: "ARDID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_FRDID",
                table: "Projects",
                column: "FRDID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProcessID",
                table: "Projects",
                column: "ProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManagerID",
                table: "Projects",
                column: "ProjectManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SRDID",
                table: "Projects",
                column: "SRDID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_TaskID",
                table: "ProjectTasks",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSteps_DeviceParameterID",
                table: "ProtocolSteps",
                column: "DeviceParameterID");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolSteps_SoluationID",
                table: "ProtocolSteps",
                column: "SoluationID");

            migrationBuilder.CreateIndex(
                name: "IX_ReagentDosages_ReagentID",
                table: "ReagentDosages",
                column: "ReagentID");

            migrationBuilder.CreateIndex(
                name: "IX_ReagentPositions_PositionID",
                table: "ReagentPositions",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_MenuID",
                table: "RoleMenu",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_SampleDosages_SampleID",
                table: "SampleDosages",
                column: "SampleID");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_PositionID",
                table: "Samples",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionReagentDosages_ReagentDosageID",
                table: "SolutionReagentDosages",
                column: "ReagentDosageID");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionSampleDosages_SampleDosageID",
                table: "SolutionSampleDosages",
                column: "SampleDosageID");

            migrationBuilder.CreateIndex(
                name: "IX_Takes_ProjectID",
                table: "Takes",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TakeTasks_TaskID",
                table: "TakeTasks",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLabwares_LabwareID",
                table: "TaskLabwares",
                column: "LabwareID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskReagents_ReagentID",
                table: "TaskReagents",
                column: "ReagentID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DeviceID",
                table: "Tasks",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_NodeID",
                table: "Tasks",
                column: "NodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProtocolID",
                table: "Tasks",
                column: "ProtocolID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskSamples_SampleID",
                table: "TaskSamples",
                column: "SampleID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_UserID",
                table: "TaskUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartmentRole_DepartmentID",
                table: "UserDepartmentRole",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartmentRole_RoleID",
                table: "UserDepartmentRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkill_SkillID",
                table: "UserSkill",
                column: "SkillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictItems");

            migrationBuilder.DropTable(
                name: "LabwarePositions");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "LogItems");

            migrationBuilder.DropTable(
                name: "NodeDevices");

            migrationBuilder.DropTable(
                name: "NodeLabwares");

            migrationBuilder.DropTable(
                name: "NodeProtocolSteps");

            migrationBuilder.DropTable(
                name: "NodeReagents");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "ReagentPositions");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "SolutionReagentDosages");

            migrationBuilder.DropTable(
                name: "SolutionSampleDosages");

            migrationBuilder.DropTable(
                name: "TakeTasks");

            migrationBuilder.DropTable(
                name: "TaskLabwares");

            migrationBuilder.DropTable(
                name: "TaskReagents");

            migrationBuilder.DropTable(
                name: "Tasks_ResultAttachments");

            migrationBuilder.DropTable(
                name: "TaskSamples");

            migrationBuilder.DropTable(
                name: "TaskUser");

            migrationBuilder.DropTable(
                name: "UserDepartmentRole");

            migrationBuilder.DropTable(
                name: "UserSkill");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "ReagentDosages");

            migrationBuilder.DropTable(
                name: "SampleDosages");

            migrationBuilder.DropTable(
                name: "Takes");

            migrationBuilder.DropTable(
                name: "Labwares");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Reagents");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Nodes");

            migrationBuilder.DropTable(
                name: "ProtocolSteps");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "NodeTypes");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "DeviceParameters");

            migrationBuilder.DropTable(
                name: "Solutions");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
