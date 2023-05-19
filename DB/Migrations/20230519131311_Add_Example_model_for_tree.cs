using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class Add_Example_model_for_tree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Example",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParent = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RefAppId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Example", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3554), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3563), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3566), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3567), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3570), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3571), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3572), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3572), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3574), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3576), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3577), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3581), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9252), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9256), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9258), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9262), new DateTime(2023, 5, 19, 13, 13, 11, 604, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.InsertData(
                table: "Example",
                columns: new[] { "Id", "Created", "IdParent", "Name", "Path", "RefAppId", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7131), 0, "Delete", "", 0, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7132) },
                    { 2, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7138), 1, "Edit", "", 1, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7138) },
                    { 3, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7139), 2, "Read", "", 1, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7139) },
                    { 4, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7140), 3, "Delete", "", 2, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7140) },
                    { 5, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7141), 4, "Edit", "", 2, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7141) },
                    { 6, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7143), 4, "Read", "", 2, new DateTime(2023, 5, 19, 13, 13, 11, 605, DateTimeKind.Utc).AddTicks(7143) }
                });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2548), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2552), new DateTime(2023, 5, 19, 13, 13, 11, 606, DateTimeKind.Utc).AddTicks(2552) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Example");

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5127), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5135), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151), new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1248), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "TreeView",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777) });
        }
    }
}
