using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Seniority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasksList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minute = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoursList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoursList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoursList_EmployeeList_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoursList_TasksList_TasksId",
                        column: x => x.TasksId,
                        principalTable: "TasksList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoursList_EmployeeId",
                table: "HoursList",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HoursList_TasksId",
                table: "HoursList",
                column: "TasksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoursList");

            migrationBuilder.DropTable(
                name: "EmployeeList");

            migrationBuilder.DropTable(
                name: "TasksList");
        }
    }
}
