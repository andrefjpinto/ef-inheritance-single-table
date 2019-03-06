using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ef_inheritance_single_table.Migrations
{
    public partial class AddEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EventType = table.Column<int>(nullable: false),
                    ProjectActivityId = table.Column<Guid>(nullable: true),
                    IsCentrallyCreated = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_ProjectActivities_ProjectActivityId",
                        column: x => x.ProjectActivityId,
                        principalTable: "ProjectActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_ProjectActivityId",
                table: "Events",
                column: "ProjectActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
