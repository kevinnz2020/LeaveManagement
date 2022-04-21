using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "e8672e79-8b3d-424f-addf-6edfbdd2c546");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "a4107c4f-b96a-46d6-901f-931bbc062bb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1896836e-af6d-44cd-ab50-335007f4e790", "AQAAAAEAACcQAAAAEMc05czHmhERbqvkGkx3DIpIylGPlVopBTze5GaTbCygX11O9/NkXM8VVCZhZ0JmVA==", "ba348dc2-5bce-4dc0-880d-51ae045caebf" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "d2a78ba1-43b4-4e33-b817-f567ff255751");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "0b295bee-5537-45cd-a44f-b836a675dc0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8e7c24-9ef2-4c6b-95ae-6dbfb6d3a187", "AQAAAAEAACcQAAAAEI19YMbUA6BKL7eolxe9RNfmqkkMmiJTk/zCQ73RRe3MKeMXj/olzJd+LxxVOiSCFA==", "171e4826-1d29-4932-b307-6a95db98784d" });
        }
    }
}
