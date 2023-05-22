using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fil_rouge_api.Migrations
{
    /// <inheritdoc />
    public partial class AddTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4033), null, null, "Je suis un déscriptif du projet fil rouge", "Projet fil rouge" },
                    { 2, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4037), null, null, "La déscription du projet test", "Un projet test" },
                    { 3, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4038), null, null, "Il ne devrait pas être visible car personne n'est assigné à celui-ci", "Le projet invisible" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(3916), null, null, "maxime@fil-rouge.com", "Maxime", "MTExMUxhIHB1aXNzYW5jZSBkZSBsYSBzZWNyZXQga2V5" },
                    { 2, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(3982), null, null, "fred@fil-rouge.com", "Fred", "MjIyMkxhIHB1aXNzYW5jZSBkZSBsYSBzZWNyZXQga2V5" },
                    { 3, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4020), null, null, "avril@fil-rouge.com", "Avril", "MzMzTGEgcHVpc3NhbmNlIGRlIGxhIHNlY3JldCBrZXk=" }
                });

            migrationBuilder.InsertData(
                table: "ProjectUser",
                columns: new[] { "ProjectId", "UserId", "IsAdmin" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 2, 1, false },
                    { 1, 2, true },
                    { 2, 2, false },
                    { 1, 3, false },
                    { 2, 3, true }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "Description", "Name", "ProjectId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4046), null, null, "C'est notre boulot", "Faire du beau code", 1, 0 },
                    { 2, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4053), null, null, "Ca on sait faire", "Déprimer", 1, 1 },
                    { 3, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4055), null, null, "La solution à tous les problèmes", "Devenir alcoolique", 1, 2 },
                    { 4, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4056), null, null, "On y croit", "Faire le projet test", 2, 0 },
                    { 5, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4058), null, null, "C'est compliqué", "Comprendre le projet test", 2, 0 },
                    { 6, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4060), null, null, "Ne faire qu'un avec les bugs", "Devenir le projet test", 2, 0 },
                    { 7, new DateTime(2023, 5, 22, 10, 22, 46, 499, DateTimeKind.Local).AddTicks(4062), null, null, "Personne ne va te voir", "La tâche invisible", 3, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
