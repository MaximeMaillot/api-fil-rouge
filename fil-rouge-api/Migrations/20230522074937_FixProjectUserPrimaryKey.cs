using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fil_rouge_api.Migrations
{
    /// <inheritdoc />
    public partial class FixProjectUserPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser",
                columns: new[] { "UserId", "ProjectId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser",
                column: "UserId");
        }
    }
}
