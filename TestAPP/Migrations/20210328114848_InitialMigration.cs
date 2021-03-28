using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAPP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    match_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    match_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    team_a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    team_b = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatchOdds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    match_id = table.Column<int>(type: "int", nullable: false),
                    specifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odd = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchOdds", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "MatchOdds");
        }
    }
}
