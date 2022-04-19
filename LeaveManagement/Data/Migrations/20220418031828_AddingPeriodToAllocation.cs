using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "5555ded7-4a6a-4341-8dcb-56b99fee8fbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "2a60d01a-9aa1-44e5-896f-b5bf677cdeb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7507c408-3a72-4831-bc91-786ce750d000", "AQAAAAEAACcQAAAAEJwqO9keQ8TrDklQosk8Ek9EAvI8SoA6BuVof7T2PosmrKIbqw8Js9JWoH/IMDDxQw==", "063830d1-1136-4773-a775-47b7ab754fb9" });
        }
    }
}
