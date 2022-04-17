using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7507c408-3a72-4831-bc91-786ce750d000", true, "KEVIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJwqO9keQ8TrDklQosk8Ek9EAvI8SoA6BuVof7T2PosmrKIbqw8Js9JWoH/IMDDxQw==", "063830d1-1136-4773-a775-47b7ab754fb9", "kevin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "9748ffc2-c0ea-4a87-a037-d3b42582f452");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "76a417f8-0879-476f-920b-9cd7a2239419");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c1c427ec-0315-4dde-ac73-25546a833ff1", false, null, "AQAAAAEAACcQAAAAEE2vhmv8OyDZ8zCu/2fY0UZ8bkvmoVFbOzZn1n+448EtmNF3U4j86ZuqNzDuqnZVjA==", "798557b5-62c6-495f-8c1d-9847862a875e", null });
        }
    }
}
