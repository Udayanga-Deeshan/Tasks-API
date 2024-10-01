using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Saman Perera" },
                    { 2, "Joshuwa Desilva" },
                    { 3, "Sasmitha Hiram" },
                    { 4, "John Doe " }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 10, 2, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 10, 7, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 1, new DateTime(2024, 10, 2, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5322), "Book Tickets and  accomedation  for vacation", new DateTime(2024, 10, 4, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5322), 0, "Plan Vacation" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2024, 10, 2, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5323), "Upgrade System Software to the latest version", new DateTime(2024, 10, 6, 0, 32, 24, 882, DateTimeKind.Local).AddTicks(5324), 0, "Update Software" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 10, 1, 18, 51, 23, 589, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 10, 6, 18, 51, 23, 589, DateTimeKind.Local).AddTicks(6116) });
        }
    }
}
