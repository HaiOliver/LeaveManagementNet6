using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UserRole3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6", "31d27d23-41a5-4219-a3dc-07d5e2a5d4b6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "90caefd0-fc04-42a4-b9eb-024bd6b448ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca85b558-1975-90d9-bb79-9ea5a406587c", "146a65be-9114-4076-a9fd-5e18825ce194", "OliverAdministrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ca85b558-1975-45d9-bb79-9ea5a406587c", "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca85b558-1975-90d9-bb79-9ea5a406587c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca85b558-1975-45d9-bb79-9ea5a406587c", "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "5722a2f4-5778-47ae-aa8f-74dbf90212ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6", "c8ac93f1-916a-416a-93f8-debbc2f44fe4", "OliverAdministrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6", "31d27d23-41a5-4219-a3dc-07d5e2a5d4b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5dfea72-2a5d-4334-8e61-87ee9ca464c4", "AQAAAAEAACcQAAAAEKOnY9anGBlXi1bOtOHrzYIWWhTnB570NaYLIMQUIaR1gOFwkVqst1W6gz/k1LD8jg==", "c8a5037a-4cb8-469f-a13c-d9beab7e4fff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb4b893-b173-4009-89e7-474ff2d7c05b", "AQAAAAEAACcQAAAAENyy+Db0a4/v91RXunTCN3qzsHBEpstS6j/RZgDLfr8Qhx6hpIsUi0QRSm6evVHodg==", "ceff563d-b8a1-4a5f-a1f3-ad096e28b73d" });
        }
    }
}
