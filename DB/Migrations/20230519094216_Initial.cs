using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RefAppId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreeView",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefApplicationId = table.Column<int>(type: "int", nullable: false),
                    ParentApplicationId = table.Column<int>(type: "int", nullable: false),
                    ApplicationTypeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeView", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Action",
                columns: new[] { "Id", "Created", "Name", "Path", "RefAppId", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5127), "Delete", "", 0, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5128) },
                    { 2, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134), "Edit", "", 1, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134) },
                    { 3, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5135), "Read", "", 1, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136) },
                    { 4, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136), "Delete", "", 2, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137) },
                    { 5, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137), "Edit", "", 2, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5138) },
                    { 6, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140), "Read", "", 2, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140) },
                    { 7, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141), "Delete", "", 3, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141) },
                    { 8, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142), "Edit", "", 3, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142) },
                    { 9, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142), "Read", "", 3, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5143) },
                    { 10, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144), "Delete", "", 4, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144) },
                    { 11, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145), "Edit", "", 4, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145) },
                    { 12, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145), "Read", "", 4, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146) },
                    { 13, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146), "Delete", "", 5, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147) },
                    { 14, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147), "Edit", "", 5, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147) },
                    { 15, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148), "Read", "", 5, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148) },
                    { 16, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149), "Delete", "", 6, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149) },
                    { 17, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150), "Edit", "", 6, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150) },
                    { 18, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151), "Read", "", 6, new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151) }
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "Id", "ApplicationName", "Created", "Description", "Updated" },
                values: new object[,]
                {
                    { 1, "App1", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240) },
                    { 2, "App2", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245) },
                    { 3, "App3", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246) },
                    { 4, "App4", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247) },
                    { 5, "App5", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1248), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1249) },
                    { 6, "App6", new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1250), null, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1251) }
                });

            migrationBuilder.InsertData(
                table: "TreeView",
                columns: new[] { "Id", "ApplicationTypeId", "Created", "ParentApplicationId", "RefApplicationId", "Updated" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6765), 0, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6766) },
                    { 2, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6770), 0, 2, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6771) },
                    { 3, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772), 1, 3, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772) },
                    { 4, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773), 2, 4, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773) },
                    { 5, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775), 3, 5, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775) },
                    { 6, 1, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777), 5, 6, new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "TreeView");
        }
    }
}
