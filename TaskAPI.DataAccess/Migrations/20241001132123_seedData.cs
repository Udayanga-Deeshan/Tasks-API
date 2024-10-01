using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2024, 10, 1, 18, 51, 23, 589, DateTimeKind.Local).AddTicks(6105), "text books for the school", new DateTime(2024, 10, 6, 18, 51, 23, 589, DateTimeKind.Local).AddTicks(6116), 0, "Get boooks for school-DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
