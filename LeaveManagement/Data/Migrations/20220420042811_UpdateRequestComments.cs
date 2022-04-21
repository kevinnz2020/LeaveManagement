using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "2d2182db-8e7b-4798-a9c3-0b3192d4e99a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-baaf-a694-5b7c1442d8f4",
                column: "ConcurrencyStamp",
                value: "3d9895fb-734c-48a9-8f7c-559ba9d67aa7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9a8f8b6-0607-4243-a694-5b7c1442d8f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94681165-89f4-4109-b20a-d3e2ddbe53cc", "AQAAAAEAACcQAAAAEHWMNiLxSl8HVK5xv9AmUGwFJ6jjPqH9/WHzi2MWfp1UoSgOpomj1TJCBVRfA7GPrg==", "4b857c84-f45b-45d8-8b0f-f1805ef3ea5c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
