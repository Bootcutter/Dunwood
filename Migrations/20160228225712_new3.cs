using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace DunwoodCrossing.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Karachter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Background = table.Column<string>(nullable: true),
                    Charisma = table.Column<string>(nullable: true),
                    Constitution = table.Column<string>(nullable: true),
                    Dexterity = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Hitpoints = table.Column<string>(nullable: true),
                    Intelligence = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    SquareFileName = table.Column<string>(nullable: true),
                    Strength = table.Column<string>(nullable: true),
                    Wisdom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karachter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Karachter");
        }
    }
}
