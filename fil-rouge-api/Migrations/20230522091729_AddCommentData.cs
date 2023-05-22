using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fil_rouge_api.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "Message", "TaskId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2663), null, null, "Coucou", 1, 1 },
                    { 2, new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2666), null, null, "salut", 1, 2 },
                    { 3, new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2667), null, null, "Ca va ?", 1, 1 },
                    { 4, new DateTime(2023, 5, 22, 11, 17, 29, 495, DateTimeKind.Local).AddTicks(2668), null, null, "Invisible", 3, 1 }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4020));
        }
    }
}
