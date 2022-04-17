using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a8f8b6-0607-4243-a694-5b7c1442d8f4", "9748ffc2-c0ea-4a87-a037-d3b42582f452", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4", "76a417f8-0879-476f-920b-9cd7a2239419", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9a8f8b6-0607-4243-a694-5b7c1442d8f4", 0, "c1c427ec-0315-4dde-ac73-25546a833ff1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin@gmail.com", false, "System", "Admin", false, null, "KEVIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEE2vhmv8OyDZ8zCu/2fY0UZ8bkvmoVFbOzZn1n+448EtmNF3U4j86ZuqNzDuqnZVjA==", null, false, "798557b5-62c6-495f-8c1d-9847862a875e", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c9a8f8b6-0607-4243-a694-5b7c1442d8f4", "c9a8f8b6-0607-4243-a694-5b7c1442d8f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9a8f8b6-0607-4243-a694-5b7c1442d8f4", "c9a8f8b6-0607-4243-a694-5b7c1442d8f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4");
        }
    }
}
