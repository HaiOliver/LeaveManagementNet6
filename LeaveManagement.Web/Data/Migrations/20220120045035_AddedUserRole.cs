using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6", "9e41ffd3-7366-41c4-99cc-858b5f8dcb04", "OliverAdministrator", "ADMINISTRATOR" },
                    { "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d", "aea59fc8-5726-4133-a790-127d0d9033d5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6", "31d27d23-41a5-4219-a3dc-07d5e2a5d4b6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6", 0, "ce47c3f0-48b1-4df4-bcdb-f98288b8f530", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "captainamericanwhoknow@gmail.com", false, "System-Oliver", "Make Admin", false, null, "Haioliver993@gmail.com", null, "AQAAAAEAACcQAAAAEFR+9pNPUU7h5i7N1sQnAmTN9Mmq95/cZl/BYPHoX6qF7+uXlHh3WlYQpZWhHtutAQ==", null, false, "ca11d55e-eeb4-4a02-bdeb-6dc12210aaec", null, false, null },
                    { "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d", 0, "9f1935a5-bc6a-474d-9d40-6895e74760c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "captainamericanwhoknow12@gmail.com", false, "captainamericanwhoknow12@gmail.com", "captainamericanwhoknow12@gmail.com", false, null, "captainamericanwhoknow12@gmail.com", null, "AQAAAAEAACcQAAAAEPYFFcn8eTtNU5o5HzDCI15IjC8ck8p5m71gzxjspKasyy6jTKj+kUNmHHL9RFBORA==", null, false, "33b67586-3cec-46d1-9aa3-0716ad1ed204", null, false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d27d23-41a5-4219-a3dc-07d5e2a5d4b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6", "31d27d23-41a5-4219-a3dc-07d5e2a5d4b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27d23-41a5-4269-a3dc-07d5e2a5d4b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2bf25e7-5e59-431d-b1f1-a7a4dd3cae8d");
        }
    }
}
