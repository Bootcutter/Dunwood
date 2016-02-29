using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace DunwoodCrossing.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Karachter",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", table: "Karachter");
        }
    }
}
