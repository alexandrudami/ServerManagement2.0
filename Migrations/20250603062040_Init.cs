﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerManagement2._0.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerID);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ServerID", "City", "IsOnline", "Name" },
                values: new object[,]
                {
                    { 1, "Toronto", false, "Server1" },
                    { 2, "Toronto", false, "Server2" },
                    { 3, "Toronto", true, "Server3" },
                    { 4, "Toronto", true, "Server4" },
                    { 5, "Montreal", true, "Server5" },
                    { 6, "Montreal", true, "Server6" },
                    { 7, "Montreal", false, "Server7" },
                    { 8, "Ottawa", false, "Server8" },
                    { 9, "Ottawa", false, "Server9" },
                    { 10, "Calgary", true, "Server10" },
                    { 11, "Calgary", true, "Server11" },
                    { 12, "Halifax", false, "Server12" },
                    { 13, "Halifax", true, "Server13" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
