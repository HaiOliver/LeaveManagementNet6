using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedUserRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6",
                column: "ConcurrencyStamp",
                value: "c8ac93f1-916a-416a-93f8-debbc2f44fe4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "5722a2f4-5778-47ae-aa8f-74dbf90212ef");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6",
                column: "ConcurrencyStamp",
                value: "9e41ffd3-7366-41c4-99cc-858b5f8dcb04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                column: "ConcurrencyStamp",
                value: "aea59fc8-5726-4133-a790-127d0d9033d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce47c3f0-48b1-4df4-bcdb-f98288b8f530", "AQAAAAEAACcQAAAAEFR+9pNPUU7h5i7N1sQnAmTN9Mmq95/cZl/BYPHoX6qF7+uXlHh3WlYQpZWhHtutAQ==", "ca11d55e-eeb4-4a02-bdeb-6dc12210aaec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1935a5-bc6a-474d-9d40-6895e74760c7", "AQAAAAEAACcQAAAAEPYFFcn8eTtNU5o5HzDCI15IjC8ck8p5m71gzxjspKasyy6jTKj+kUNmHHL9RFBORA==", "33b67586-3cec-46d1-9aa3-0716ad1ed204" });
        }
    }
}
