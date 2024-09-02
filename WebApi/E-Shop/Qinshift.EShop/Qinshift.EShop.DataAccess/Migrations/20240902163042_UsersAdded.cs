using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinshift.EShop.DataAccess.Migrations
{
    public partial class UsersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "ModifiedBy", "ModifiedOn", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4555), "John", "Doe", 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4556), "test123#", "j_doe" },
                    { 2, 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4562), "Bob", "Bobsky", 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4563), "test1234#", "bob_bobsky" },
                    { 3, 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4564), "Boris", "Krstovski", 1, new DateTime(2024, 9, 2, 17, 30, 41, 784, DateTimeKind.Local).AddTicks(4565), "krstovskib", "bkrstovski" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2911), new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2912) });
        }
    }
}
