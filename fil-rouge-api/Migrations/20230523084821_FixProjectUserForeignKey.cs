using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fil_rouge_api.Migrations
{
    /// <inheritdoc />
    public partial class FixProjectUserForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Projects_UserId",
                table: "ProjectUser");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 23, 10, 48, 21, 657, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Projects_ProjectId",
                table: "ProjectUser",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Projects_ProjectId",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Projects_UserId",
                table: "ProjectUser",
                column: "UserId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
