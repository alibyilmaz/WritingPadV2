using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WritingPadV2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotepadItems",
                columns: table => new
                {
                    NotePadId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Explanation = table.Column<string>(nullable: true),
                    AppUserId = table.Column<int>(nullable: false),
                    NoteUrl = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DueAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotepadItems", x => x.NotePadId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotepadItems");
        }
    }
}
