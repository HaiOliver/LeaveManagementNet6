using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UserRole4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "ebc75b80-4635-4cbe-ac40-d1998ea1a481");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca85b558-1975-90d9-bb79-9ea5a406587c",
                column: "ConcurrencyStamp",
                value: "c90e9722-9ce5-4aa6-ab9b-f8e43af4db68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97e1c4cc-9965-4ac1-b4c8-ae7868d65b1d", "AQAAAAEAACcQAAAAEBimbphr1u0TqcVZL1QUy+PIxK0+DjmC6NgnDYRNY7h0gRGto9vTfEVrue524+hEKQ==", "7af12c3e-7ad9-4130-a5b6-a0357957bf9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73105526-1ee1-4a97-b747-d8057390f6f1", "AQAAAAEAACcQAAAAECDNX0svtDaBxLrYRKY9IOSldUznYapeRjlUyT2C2jqiSQfhgPPxOJlNR7IBA22THg==", "697e2ddb-c3f5-4789-b2ed-467d3cd26b13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "90caefd0-fc04-42a4-b9eb-024bd6b448ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca85b558-1975-90d9-bb79-9ea5a406587c",
                column: "ConcurrencyStamp",
                value: "146a65be-9114-4076-a9fd-5e18825ce194");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3061cb5-98f5-4a2e-8a9a-3d6c1e912c81", "AQAAAAEAACcQAAAAEM5m55JYEj5PrZNcW9BpHqET8Z9cMxplleTE1z+5gcT+vNscVTv89BwkRkAwzcvHvw==", "cdcd61d3-daa9-4861-bdd5-f05cdce3504e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940fc5db-8dd9-4e32-af29-9b1ccff2c12b", "AQAAAAEAACcQAAAAEDj9mw4sPscGt6fmmUPKLyBPL8s6KwgOjHb9mndKc8ZYTTsPzD0q+irrls/FaaIaiw==", "32406b80-037e-4e9c-89e2-26fc17afdce6" });
        }
    }
}
